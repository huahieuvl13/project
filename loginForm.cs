using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.ShowDialog();
            this.Hide();

        }
        private string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1️⃣ Lấy dữ liệu từ TextBox

            string sdt = txtSDT.Text;
            string matKhau = txtMatkhau.Text;

            // 2️⃣ Kiểm tra nhập đủ chưa
            if (sdt == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ SĐT và mật khẩu");
                return;
            }

            // 3️⃣ Hash mật khẩu
            string passwordHash = HashPassword(matKhau);
            string connStr = ConfigurationManager
    .ConnectionStrings[".NET BANKING"]
    .ConnectionString;

            // 4️⃣ Kết nối CSDL và kiểm tra đăng nhập
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT ID,FullName 
                       FROM Users
                       WHERE PhoneNumber = @Phone
                       AND PasswordHash = @PasswordHash";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Phone", sdt);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string fullName = reader.GetString(1);
                    MessageBox.Show($"Đăng nhập thành công! Xin chào {fullName}");
                    FormDashboard dashboard = new FormDashboard(userId);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại SĐT và mật khẩu.");
                }

  
            }
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
