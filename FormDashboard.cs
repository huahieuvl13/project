using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
namespace project  
{
    public partial class FormDashboard : Form
    {
        private int _userId;
        BindingSource bs = new BindingSource();
        public FormDashboard(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Load += FormDashboard_Load;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            panelAccount.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(panelAccount, true, null);
            StyleCard(panelAccountInfo);
            panelNap.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(panelAccount, true, null);
            StyleCard(panelNapBox);
            panelRutBox.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(panelAccount, true, null);
            StyleCard(panelRutBox);
            panelNutTim.GetType()
    .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
    .SetValue(panelNutTim, true, null);

            StyleSearchBar(panelNutTim); 
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            panelAccount.Visible = true;
            LoadAccountInfo();
            StyleCard(panelCard);
            StyleCard(panelChuyen);
            StyleCard(panelNap);
            StyleCard(panel7);
            StyleCard(panelTransferBox);
            StyleCard(panelNapBox);
            StyleCard(panelRutBox);
            StyleCard(panelAccountInfo);
            StyleCard(panelNap);
        }
        private void LoadAccountInfo()
        {
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
                    MessageBox.Show("Không tìm thấy tài khoản cho người dùng này");
                }
            }
        }


        private void btnXacNhanChuyen_Click(object sender, EventArgs e)
        {
            string stkNhan = txtSoTKNhan.Text;
            string noidung = txtNoidung.Text;
            decimal soTien;
            if (!decimal.TryParse(txtSoTien.Text, out soTien))
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
                                        UserId = @UserId";
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
                    if (toUserIdObject == null)
                    {
                        MessageBox.Show("Số tài khoản nhận không tồn tại");
                        tran.Rollback();
                        return;
                    }

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
                        VALUES(@UserId, @ToAccount, N'Chuyển tiền', @Amount, @Note, GETDATE())";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn, tran);
                    cmdInsert.Parameters.AddWithValue("@UserId", _userId);
                    cmdInsert.Parameters.AddWithValue("@ToAccount", stkNhan);
                    cmdInsert.Parameters.AddWithValue("@Amount", soTien);
                    cmdInsert.Parameters.AddWithValue("@Note", txtNoidung.Text);

                    cmdInsert.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Đã chuyển tiền thành công");
                    LoadAccountInfo();
                    LoadAvailableBalance();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Chuyển tiền thất bại" + ex.Message);
                }
            }
        }
        private void LoadHistory()
        {
            string connStr = ConfigurationManager.ConnectionStrings[".NET BANKING"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT TransType as 'Loại giao dịch', TransDate as 'Ngày giao dịch', 
                       Amount as 'Số tiền', ToAccount as 'Số tài khoản', Note as 'Nội dung' 
                       FROM TRANSACTIONS WHERE UserId = @UserId ORDER BY TransDate desc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserId", _userId);

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Da.Fill(dt);

                bs.DataSource = dt;
                dgvHistory.DataSource = bs;

                StyleDataGridView();
            }
        }
        private void btnRut_Click(object sender, EventArgs e)
        {
            decimal soTienRut;
            if (!decimal.TryParse(txtTienrut.Text, out soTienRut) || soTienRut <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền rút hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soTienRut < 50000)
            {
                MessageBox.Show("Số tiền rút tối thiểu là 50,000 VND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings[".NET BANKING"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlCheck = "SELECT Balance FROM Accounts WHERE UserId = @UserId";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, tran);
                    cmdCheck.Parameters.AddWithValue("@UserId", _userId);
                    decimal soDuHienTai = (decimal)cmdCheck.ExecuteScalar();
                    decimal soDuToiThieu = 50000;
                    if (soDuHienTai - soTienRut < soDuToiThieu)
                    {
                        MessageBox.Show("Số dư không đủ để thực hiện giao dịch (cần giữ lại tối thiểu 50k)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tran.Rollback();
                        return;
                    }
                    string sqlUpdate = "UPDATE Accounts SET Balance = Balance - @Amount WHERE UserId = @UserId";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn, tran);
                    cmdUpdate.Parameters.AddWithValue("@Amount", soTienRut);
                    cmdUpdate.Parameters.AddWithValue("@UserId", _userId);
                    cmdUpdate.ExecuteNonQuery();

                    string sqlLog = @"INSERT INTO TRANSACTIONS (UserId, ToAccount, TransType, Amount, Note, TransDate) 
                              VALUES (@UserId, NULL, N'Rút tiền', @Amount, @Note, GETDATE())";
                    SqlCommand cmdLog = new SqlCommand(sqlLog, conn, tran);
                    cmdLog.Parameters.AddWithValue("@UserId", _userId);
                    cmdLog.Parameters.AddWithValue("@Amount", soTienRut);
                    cmdLog.Parameters.Add("@Note", rtb.Text);
                    cmdLog.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show($"Đã rút thành công {soTienRut:N0} VND!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAccountInfo();
                    LoadAvailableBalance();
                    rtb.Clear();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Giao dịch thất bại! Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string serial = txtSerial.Text.Trim();

            if (string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(serial))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã thẻ và serial");
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
                    if (maThe.Length != 6 || !maThe.All(char.IsDigit))
                    {
                        MessageBox.Show("Mã thẻ phải gồm đúng 6 chữ số");
                        tran.Rollback();
                        return;
                    }

                    if (serial.Length != 11 || !serial.All(char.IsDigit))
                    {
                        MessageBox.Show("Serial phải gồm đúng 11 chữ số");
                        tran.Rollback();
                        return;
                    }
                    try
                    {
                        string sqlInsert = @"INSERT INTO UsedCards(CardCode, Serial)
                 VALUES(@Code, @Serial)";

                        SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn, tran);
                        cmdInsert.Parameters.AddWithValue("@Code", maThe);
                        cmdInsert.Parameters.AddWithValue("@Serial", serial);

                        cmdInsert.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Thẻ đã được sử dụng");
                            tran.Rollback();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                            tran.Rollback();
                            return;
                        }
                    }
                    int amount = int.Parse(cboMenhGia.SelectedItem.ToString());

                    string sqlNap = @"UPDATE Accounts 
          SET Balance = Balance + @Amount
          WHERE UserId = @UserId";

                    SqlCommand cmdNap = new SqlCommand(sqlNap, conn, tran);
                    cmdNap.Parameters.AddWithValue("@Amount", amount);
                    cmdNap.Parameters.AddWithValue("@UserId", _userId);
                    cmdNap.ExecuteNonQuery();



                    string sqlTran = @"INSERT INTO TRANSACTIONS(UserId,ToAccount, TransType, Amount, Note, TransDate)
                   VALUES (@UserId, NULL, N'Nạp thẻ', @Amount, @Note, GETDATE())";

                    SqlCommand cmdTran = new SqlCommand(sqlTran, conn, tran);
                    cmdTran.Parameters.AddWithValue("@UserId", _userId);
                    cmdTran.Parameters.AddWithValue("@Amount", amount);
                    cmdTran.Parameters.AddWithValue("@Note", "Nạp thẻ: " + maThe);
                    cmdTran.ExecuteNonQuery();

                    tran.Commit();

                    MessageBox.Show("Nạp thẻ thành công");
                    LoadAccountInfo();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (bs.DataSource == null) return;

            bs.Filter = "";
            txtTimKiem.Clear();

            dtpTungay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenngay.Value = DateTime.Now;
            MessageBox.Show("Đã làm mới");
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất", "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm lg = new LoginForm();
                lg.ShowDialog();
                this.Close();
            }
        }
        private void btnRuttien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelRut.Visible = true;
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bs.DataSource == null) return;

            DateTime tuNgay = dtpTungay.Value.Date;

            DateTime denNgay = dtpDenngay.Value.Date.AddDays(1).AddSeconds(-1);
            string filter = string.Format("[Ngày giao dịch] >= #{0}# AND [Ngày giao dịch] <= #{1}#",
                                          tuNgay.ToString("MM/dd/yyyy"),
                                          denNgay.ToString("MM/dd/yyyy"));

            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
                filter += string.Format(" AND ([Nội dung] LIKE '%{0}%' OR [Loại giao dịch] LIKE '%{0}%')", keyword);
            }

            bs.Filter = filter;
            if (bs.Count == 0)
            {
                MessageBox.Show("Không có giao dịch nào trong khoảng thời gian này.", "Thông báo");
            }
        }
        private void LoadAvailableBalance()
        {
            string connStr = ConfigurationManager.ConnectionStrings[".NET BANKING"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT Balance FROM Accounts WHERE UserId = @UserId";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserId", _userId);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal balance = Convert.ToDecimal(result);
                        lblSoduKhadung.Text = "Số tiền khả dụng: " + balance.ToString("N0") + " VND";
                    }
                    else
                    {
                        lblSoduKhadung.Text = "0 VND";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy số dư: " + ex.Message);
                }
            }
        }

        private void HideAllPanels()
        {
            panelAccount.Visible = false;
            panelTransfer.Visible = false;
            panelHistory.Visible = false;
            panelNaptien.Visible = false;
            panelRut.Visible = false;
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
            LoadAvailableBalance();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelHistory.Visible = true;
            LoadHistory();
        }

        private void btnChuyenTien_Click_1(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTransfer.Visible = true;
        }


        
        private void btnNapTien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelNaptien.Visible = true;
            LoadAvailableBalance();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblHienthiSTK_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void panelAccountInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        
        

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void StyleSearchBar(Panel panel)
        {
            panel.BorderStyle = BorderStyle.None;
            if (panel.Parent != null) panel.BackColor = panel.Parent.BackColor;

            int radius = 15;

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

                using (GraphicsPath path = GetRoundedRect(rect, radius))
                {
                    using (SolidBrush bgBrush = new SolidBrush(Color.Teal))
                    {
                        e.Graphics.FillPath(bgBrush, path);
                    }

                    using (Pen pen = new Pen(Color.FromArgb(200, 225, 225), 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
            panel.Invalidate();
        }
        private void StyleDataGridView()
        {
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.SendToBack();
            dgvHistory.ColumnHeadersHeight = 45;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistory.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvHistory.EnableHeadersVisualStyles = false;

            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.DefaultCellStyle.BackColor = Color.White;
            dgvHistory.DefaultCellStyle.ForeColor = Color.Black;
            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvHistory.DefaultCellStyle.SelectionBackColor = Color.Orange;
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dgvHistory.Columns["Số tiền"] != null)
            {
                dgvHistory.Columns["Số tiền"].DefaultCellStyle.Format = "N0";
                dgvHistory.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
        private void StyleCard(Panel panel)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.White;
            panel.Padding = new Padding(25);

            int radius = 20;

            panel.Resize += (s, e) =>
            {
                using (GraphicsPath path = GetRoundedRect(panel.ClientRectangle, radius))
                {
                    panel.Region = new Region(path);
                }
            };

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                Rectangle shadowRect = new Rectangle(3, 3, panel.Width - 1, panel.Height - 1);

                using (GraphicsPath path = GetRoundedRect(rect, radius))
                using (GraphicsPath shadowPath = GetRoundedRect(shadowRect, radius))
                {

                    using (Brush shadowBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                    {
                        e.Graphics.FillPath(shadowBrush, shadowPath);
                    }

                    using (Brush bgBrush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillPath(bgBrush, path);
                    }


                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
            panel.Resize += (s, e) => panel.Invalidate();
        }

    }
}
    