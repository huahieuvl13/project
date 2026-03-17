using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace project  
{
    public partial class FormDashboard : Form
    {
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

                string sql = @"SELECT TransType as 'Loại giao dịch', TransDate as 'Ngày giao dịch', Amount as 'Số tiền',
                        ToAccount as 'Số tài khoản', Note as 'Nội dung' FROM TRANSACTIONS
WHERE UserId = @UserId  ORDER BY TransDate desc";
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
                dgvHistory.EnableHeadersVisualStyles = false;

                // Header
                dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // Row
                dgvHistory.DefaultCellStyle.BackColor = Color.White;
                dgvHistory.DefaultCellStyle.ForeColor = Color.Black;

                // Xen kẽ
                dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                // Khi chọn
                dgvHistory.DefaultCellStyle.SelectionBackColor = Color.Orange;
                dgvHistory.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
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
            StyleCard();
            //panelCard.Paint += (s, e2) =>
            //{
            //    e2.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //    Pen pen = new Pen(Color.LightGray, 1);
            //    e2.Graphics.DrawRectangle(pen, 0, 0, panelCard.Width - 1, panelCard.Height - 1);
            //};

        }

        private void panelAccountInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXacNhanChuyen_Click(object sender, EventArgs e)
        {
            string stkNhan = txtSoTKNhan.Text;
            string noidung = txtNoidung.Text;
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
                    // ✅ check format
                    if (!System.Text.RegularExpressions.Regex.IsMatch(maThe, @"^\d{6}$"))
                    {
                        MessageBox.Show("Mã thẻ phải 6 số");
                        return;
                    }

                    if (!System.Text.RegularExpressions.Regex.IsMatch(serial, @"^\d{11}$"))
                    {
                        MessageBox.Show("Serial phải 11 số");
                        return;
                    }
                    // 🔥 CHẶN TRÙNG NGAY TẠI ĐÂY
                    try
                    {
                        string sqlInsert = @"INSERT INTO UsedCards(CardCode, Serial)
                 VALUES(@Code, @Serial)";

                        SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn, tran);
                        cmdInsert.Parameters.AddWithValue("@Code", maThe);
                        cmdInsert.Parameters.AddWithValue("@Serial", serial);

                        cmdInsert.ExecuteNonQuery(); // ❗ trùng là nổ ở đây
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


                    // 🎯 random tiền
                    int amount = int.Parse(cboMenhGia.SelectedItem.ToString());

                    // 💰 cộng tiền
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



        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Close();
            lg.ShowDialog();
        }

        private void lblHienthiSTK_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BoGocPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void StyleCard()
        {
            // ❌ Tắt viền cũ
            panelCard.BorderStyle = BorderStyle.None;

            // 🎨 Màu + padding
            panelCard.BackColor = Color.White;
            panelCard.Padding = new Padding(25);

            // 🟫 Vẽ viền đẹp
            panelCard.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.FromArgb(229, 231, 235), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, panelCard.Width - 1, panelCard.Height - 1);
            };
             
            // 🔵 Bo góc
            BoGocPanel(panelCard, 20);

            // 🌫️ Shadow (giả)
            Panel shadow = new Panel();
            shadow.BackColor = Color.FromArgb(240, 240, 240);
            shadow.Size = panelCard.Size;
            shadow.Location = new Point(panelCard.Left + 5, panelCard.Top + 5);

            this.Controls.Add(shadow);
            shadow.SendToBack();
            panelCard.BringToFront();
        }
    }
}
