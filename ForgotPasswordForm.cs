using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phone = txtSTK.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            // Check rỗng
            if (phone == "" || newPass == "" || confirm == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Check khớp mật khẩu
            if (newPass != confirm)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            // Lấy connection string giống LoginForm
            string connStr = ConfigurationManager
                .ConnectionStrings[".NET BANKING"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Kiểm tra tài khoản tồn tại
                string checkSql = "SELECT COUNT(*) FROM Users WHERE PhoneNumber = @phone";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@phone", phone);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists == 0)
                {
                    MessageBox.Show("Số điện thoại không tồn tại!");
                    return;
                }

                // Update mật khẩu
                string updateSql = "UPDATE Users SET Password = @pass WHERE PhoneNumber = @phone";
                SqlCommand cmd = new SqlCommand(updateSql, conn);
                cmd.Parameters.AddWithValue("@pass", newPass);
                cmd.Parameters.AddWithValue("@phone", phone);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật!");
                }
            }
        }

        private void lblBack_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}