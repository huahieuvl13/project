using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace project
{
    public partial class FormDashboard : System.Windows.Forms.Form

    {
        private string _fullName;
        decimal balance = 1000000;//1trieu vnd
        
        public FormDashboard(string fullName)
        {          
            InitializeComponent();
            _fullName = fullName;
            lblWelcome.Text = "Xin chào, " + _fullName;
        }
        private void LoadHistoryFromDB()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings[".NET BANKING"]
                .ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT TransDate,TransType,Amount,Note from Transactions";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Convert.ToDateTime(reader["TransDate"]).ToString("dd/MM/yyyy HH:mm");
                    reader["TransType"].ToString();
                    Convert.ToDecimal(reader["Amount"]).ToString("N0");
                    reader["Note"].ToString();
                }
            }
        }
        private void InsertTransaction(decimal amount, string note)
        {

            string connStr = ConfigurationManager
    .ConnectionStrings[".NET BANKING"]
    .ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"INSERT INTO Transactions(TransDate,TransType,Amount,
Note) VALUES (@date,@type,@amount,@note)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@type", "Chuyển tiền");
                cmd.Parameters.AddWithValue("@amount", 500000);
                cmd.Parameters.AddWithValue("@note", "Tiền ăn");
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            
        }

        private void Form2(object sender, EventArgs e)
        {
            panelHistory.Visible = true;
            dgvHistory.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                "Chuyển tiền", "500,000", "Test chức năng chuyển");
            UpdateAccountInfo();
            LoadHistoryFromDB();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelHistory.Visible = true;
            panelAccount.Visible = false;
            panelTransfer.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            panelTransfer.Visible = true;
            panelHistory.Visible = false;
            panelAccount.Visible = false;
        }
        private void btnAccount(object sender, EventArgs e)
        {
            panelTransfer.Visible = false;
            panelHistory.Visible = false;
            panelAccount.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadHistory()
        {
            //dgvHistory.Rows.Clear();
            //foreach (Transaction t in transactions)
            //{
            //    dgvHistory.Rows.Add(t.Date.ToString("dd/MM/yyyy HH:mm"),
            //        t.Type,
            //        t.Amount.ToString("N0"),
            //        t.Note);
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReceiver.Text)
                || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản người nhận hoặc số tiền");
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Số tiền không hợp lệ");
                return;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0");
                return;
            }
            if (amount > balance)
            {
                MessageBox.Show("Số dư không đủ");
                return;
            }
            balance -= amount;
            InsertTransaction(amount, "Chuyển đến số tài khoản " + txtReceiver.Text);
            //transactions.Add(new Transaction
            //{
            //    Date = DateTime.Now,
            //    Type = "Chuyển tiền",
            //    Amount = amount,
            //    Note = "Chuyển đến số tài khoản " + txtReceiver.Text
            //});
            UpdateAccountInfo();
            LoadHistory();
            txtAmount.Clear();
            txtReceiver.Clear();
            MessageBox.Show("Đã chuyển thành công");
        }
        private void UpdateAccountInfo()
        {
            lblBalance.Text = balance.ToString("N0") + " VND";
            lblSoTk.Text = "123456789";
            lblTendn.Text = "HuaHieu";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
