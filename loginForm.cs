using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            string pass = txtPass.Text; // don't trim yet so whitespace can be detected

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                txtSDT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtPass.Focus();
                return;
            }

            pass = pass.Trim();
            string connStr = ConfigurationManager
            .ConnectionStrings[".NET BANKING"]
            .ConnectionString;

            string sql = @"SELECT FullName, [Password] FROM USERS WHERE SDT = @sdt";
            string fullName = "";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                cmd.Parameters.AddWithValue("@sdt", sdt);
                conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng");
                            return;
                        }

                        fullName = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                        string storedPassword = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);

                        // Verify provided password against stored hash
                        bool ok = VerifyHashedPassword(storedPassword, pass);
                        if (!ok)
                {
                    MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng");
                    return;
                }

                MessageBox.Show("Đăng nhập thành công");
                FormDashboard dashboard = new FormDashboard(fullName);
                dashboard.Show();
                this.Hide();
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
    }
}
