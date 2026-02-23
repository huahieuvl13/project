using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace project   // ⚠️ ĐỔI CHO ĐÚNG NAMESPACE CỦA BẠN
{
    public partial class FormDashboard : Form
    {
        private string _tenNguoiDung;
        private int _userId;
        public FormDashboard(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Load += FormDashboard_Load;
        }
        private void LoadHistory()
        {
            string connStr = ConfigurationManager.ConnectionStrings[".NET BANKING"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT TransDate as 'Ngày giao dịch', ToAccount as 'Đến tài khoản',
                                        Amount as 'Số tiền', Note as 'Mô tả' FROM TRANSACTIONS
WHERE UserId = @UserId ORDER BY TransDate desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserId",_userId);

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                dgvHistory.DataSource = dt;
                dgvHistory.ColumnHeadersHeight = 45;
                dgvHistory.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                dgvHistory.ColumnHeadersDefaultCellStyle.WrapMode =
                    DataGridViewTriState.False;
                dgvHistory.Columns["Số tiền"].DefaultCellStyle.Format = "N0";
                dgvHistory.Columns["Số tiền"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }
        private void LoadAccountInfo()
        {
            MessageBox.Show("_userId = " + _userId); // test, xong xoá

            string connStr = ConfigurationManager
                .ConnectionStrings[".NET BANKING"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT u.FullName, a.AccountNumber, a.Balance
                       FROM Users u
                       JOIN Accounts a ON u.Id = a.UserId
                       WHERE a.UserId = @UserId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserId", _userId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader["FullName"].ToString();
                    string accountNumber = reader["AccountNumber"].ToString();
                    decimal balance = (decimal)reader["Balance"];

                    lblXinchao.Text = "Xin chào, " + fullName;
                    lblHienthiSTK.Text = accountNumber;
                    lblChuTK.Text = fullName;
                    lblHienthisodu.Text = balance.ToString("N0") + " VNĐ";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản cho user này");
                }
            }
        }

        private void HideAllPanels()
        {
            panelAccount.Visible = false;
            panelTransfer.Visible = false;
            panelHistory.Visible = false;
            panelNaptien.Visible = false;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelAccount.Visible = true;
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTransfer.Visible = true;
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelHistory.Visible = true; 
            LoadHistory();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyenTien_Click_1(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTransfer.Visible = true;
        }


        private void FormDashboard_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            panelAccount.Visible = true;
            LoadAccountInfo();
        }

        private void panelAccountInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXacNhanChuyen_Click(object sender, EventArgs e)
        {
            string stkNhan = txtSoTKNhan.Text;
            decimal soTien;
            if(!decimal.TryParse(txtSoTien.Text, out soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ");
                return;
            }
            string connStr = ConfigurationManager
                .ConnectionStrings[".NET BANKING"]
                .ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlBalance = @"SELECT BALANCE FROM Accounts WHERE
                                        UserId = @Userid";
                    SqlCommand cmdBalance = new SqlCommand(sqlBalance, conn, tran);
                    cmdBalance.Parameters.AddWithValue("@UserId", _userId);
                    decimal soDuhienTai = (decimal)cmdBalance.ExecuteScalar();
                    if (soDuhienTai < soTien)
                    {
                        MessageBox.Show("Số dư không đủ để thực hiện giao dịch");
                        tran.Rollback();
                        return;

                    }
                    string sqlCheck = @"SELECT UserId from Accounts where
                                        AccountNumber = @STK";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, tran);
                    cmdCheck.Parameters.AddWithValue("@STK", stkNhan);
                    object toUserIdObject = cmdCheck.ExecuteScalar();
                    if(toUserIdObject == null)
                    {
                        MessageBox.Show ("Số tài khoản nhận không tồn tại");
                        tran.Rollback();
                        return;
                    }
                    object toUserId = (int)toUserIdObject;

                    string sqlTru = @"UPDATE ACCOUNTS 
                                        SET BALANCE = BALANCE - @Amount
                                         WHERE UserId = @UserId";
                    SqlCommand cmdTru = new SqlCommand(sqlTru, conn, tran);
                    cmdTru.Parameters.AddWithValue("@Amount", soTien);
                    cmdTru.Parameters.AddWithValue("@UserId", _userId);
                    cmdTru.ExecuteNonQuery();
                    
                    string sqlCong = @"UPDATE ACCOUNTS SET BALANCE = BALANCE + @AMOUNT
                                        WHERE AccountNumber = @STK";
                    SqlCommand cmdCong = new SqlCommand(sqlCong, conn, tran);
                    cmdCong.Parameters.AddWithValue("@Amount", soTien);
                    cmdCong.Parameters.AddWithValue("@STK", stkNhan);
                    cmdCong.ExecuteNonQuery();

                    string sqlInsert = @"INSERT INTO TRANSACTIONS (UserId,ToAccount,TransType,Amount,Note,TransDate)
                        VALUES(@UserId, @ToAccount, N'Chuyển tiền', @Amount, N'Chuyển tiền đến tài khoản ' + @ToAccount,GETDATE())";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn, tran);
                    cmdInsert.Parameters.AddWithValue("@UserId", _userId);
                    cmdInsert.Parameters.AddWithValue("@ToAccount", stkNhan);
                    cmdInsert.Parameters.AddWithValue("@Amount", soTien);

                    cmdInsert.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Đã chuyển tiền thành công cho số tài khoản : " + stkNhan);
                    LoadAccountInfo();
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Chuyển tiền thất bại" + ex.Message);
                }
            }
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelNaptien.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal soTien;
            if(!decimal.TryParse(txtSotiennap.Text, out soTien )|| soTien <= 0) {
                MessageBox.Show("Số tiền nạp không hợp lệ");
                return;
            }
            string connStr = ConfigurationManager
                .ConnectionStrings[".NET BANKING"]
                .ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string sqlNap = @"UPDATE ACCOUNTS SET BALANCE = BALANCE + @Amount
                                    WHERE UserId = @UserId";
                    SqlCommand cmdNap = new SqlCommand(sqlNap, conn, tran);
                    cmdNap.Parameters.AddWithValue("@Amount", soTien);
                    cmdNap.Parameters.AddWithValue("@UserId", _userId);
                    cmdNap.ExecuteNonQuery();

                    string sqlTran = @"INSERT INTO TRANSACTIONS(UserId, ToAccount,TransType,Amount,Note, TransDate)
                     VALUES (@UserId, NULL, N'Nạp tiền', @Amount, N'Nạp tiền vào tài khoản', GETDATE())";

                    SqlCommand cmdTran = new SqlCommand(sqlTran, conn, tran);
                    cmdTran.Parameters.AddWithValue("@UserId", _userId);
                    cmdTran.Parameters.AddWithValue("@Amount", soTien);
                    cmdTran.ExecuteNonQuery();
                    tran.Commit();
                    MessageBox.Show("Nạp tiền thành công");
                    LoadAccountInfo();
                }
                catch{
                    tran.Rollback();
                    MessageBox.Show("Nạp tiền thất bại");
                }
            }
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHienthiSTK_Click(object sender, EventArgs e)
        {

        }
    }
}
