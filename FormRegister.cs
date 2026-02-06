using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;

namespace project
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string hoten = txtFullName.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string pass = txtPass.Text; // don't trim yet so whitespace can be detected
            string cpass = txtConfirmPass.Text;

            // Basic required fields check (except passwords handled separately)
            if (string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Check password specifically
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtPass.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cpass))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu");
                txtConfirmPass.Focus();
                return;
            }

            // Trim passwords now and compare
            pass = pass.Trim();
            cpass = cpass.Trim();

            if (pass != cpass)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txtPass.Focus();
                return;
            }
            string connStr = ConfigurationManager
    .ConnectionStrings[".NET BANKING"]
    .ConnectionString;

using (SqlConnection conn = new SqlConnection(connStr))
{
    try
    {
        string sql = @"
        INSERT INTO Users (FullName, CCCD, SDT, [Password], CreatedAt)
        VALUES (@name, @cccd, @sdt, @pass, GETDATE())";

        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
        // Use PBKDF2 to hash the password with a salt
        const int iterations = 10000;
        byte[] salt = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt);
        }
        byte[] hash;
        using (var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, iterations))
        {
            hash = pbkdf2.GetBytes(32);
        }
        // store as iterations:salt:hash (base64)
        string storedPassword = string.Format("{0}:{1}:{2}", iterations, Convert.ToBase64String(salt), Convert.ToBase64String(hash));

        // Use explicit parameter types to avoid unexpected type/NULL inference
        cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 200).Value = (object)hoten ?? string.Empty;
        cmd.Parameters.Add("@cccd", System.Data.SqlDbType.NVarChar, 50).Value = (object)cccd ?? string.Empty;
        cmd.Parameters.Add("@sdt", System.Data.SqlDbType.NVarChar, 50).Value = (object)sdt ?? string.Empty;
        cmd.Parameters.Add("@pass", System.Data.SqlDbType.NVarChar, 512).Value = (object)storedPassword ?? string.Empty;

        // Defensive check: ensure parameter values are not null/DBNull
        var passParam = cmd.Parameters["@pass"].Value;
        if (passParam == null || passParam == DBNull.Value)
        {
            MessageBox.Show("Lỗi nội bộ: tham số mật khẩu rỗng trước khi lưu. Vui lòng thử lại.");
            return;
        }

        conn.Open();
        cmd.ExecuteNonQuery();
        }

        MessageBox.Show("Đăng ký thành công");
    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

        }

        private void btnRegister_Enter(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
