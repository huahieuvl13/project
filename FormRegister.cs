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


        private void btnRegister_Enter(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        private string GenerateAccountNumber()
        {
            Random random = new Random();
            return "9704" + random.Next(100000000, 999999999).ToString();

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
        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.Text != txtXacnhanmk.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp");
                return;
            }

            string passwordHash = HashPassword(txtMatkhau.Text);

            string connStr = ConfigurationManager
    .ConnectionStrings[".NET BANKING"]
    .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO Users
    (FullName, CCCD, PhoneNumber, PasswordHash)
    OUTPUT INSERTED.Id
    VALUES (@FullName, @CCCD, @Phone, @Password)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@Phone", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Password", passwordHash);

                // LẤY ID VỪA INSERT
                int userID = Convert.ToInt32(cmd.ExecuteScalar());

                // tạo số tài khoản
                string accountNumber = GenerateAccountNumber();

                string sqlAccount = @"INSERT INTO Accounts (UserID, AccountNumber, Balance)
                      VALUES (@UserID, @AccountNumber, 0)";

                SqlCommand cmdAccount = new SqlCommand(sqlAccount, conn);
                cmdAccount.Parameters.AddWithValue("@UserID", userID);
                cmdAccount.Parameters.AddWithValue("@AccountNumber", accountNumber);
                cmdAccount.ExecuteNonQuery();
            }

            MessageBox.Show("Đăng ký thành công! Hãy quay về trang đăng nhập");
        }
    }
}
