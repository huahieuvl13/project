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

                // --- SỬA LẠI ĐOẠN NÀY ---
                bs.DataSource = dt;
                dgvHistory.DataSource = bs; // Gán qua bs để lọc được dữ liệu

                dgvHistory.Dock = DockStyle.Fill;
                dgvHistory.SendToBack(); // Đẩy xuống dưới để nhường chỗ cho thanh tìm kiếm
                                         // ------------------------

                // Thiết lập giao diện
                dgvHistory.ColumnHeadersHeight = 45;
                dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvHistory.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                if (dgvHistory.Columns["Số tiền"] != null)
                {
                    dgvHistory.Columns["Số tiền"].DefaultCellStyle.Format = "N0";
                    dgvHistory.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                dgvHistory.EnableHeadersVisualStyles = false;
                dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvHistory.DefaultCellStyle.BackColor = Color.White;
                dgvHistory.DefaultCellStyle.ForeColor = Color.Black;
                dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
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
            StyleCard(panelCard);
            StyleCard(panelChuyen);
            StyleCard(panelNap);

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

            // 🔥 Bo góc thật
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
                    // Shadow
                    using (Brush shadowBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                    {
                        e.Graphics.FillPath(shadowBrush, shadowPath);
                    }

                    // Background
                    using (Brush bgBrush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillPath(bgBrush, path);
                    }

                    // Border
                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }
        private void txtSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem dgvHistory đã có dữ liệu chưa
            if (bs.DataSource == null) return;

            // 2. Lấy giá trị ngày từ DateTimePicker
            // .Date để lấy lúc 00:00:00
            DateTime tuNgay = dateTimePicker1.Value.Date;

            // .AddDays(1).AddSeconds(-1) để lấy đến cuối ngày (23:59:59)
            DateTime denNgay = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            // 3. Tạo câu lệnh lọc (Filter)
            // Lưu ý: Dùng dấu # bao quanh ngày tháng và định dạng MM/dd/yyyy để chuẩn SQL nội bộ
            string filter = string.Format("[Ngày giao dịch] >= #{0}# AND [Ngày giao dịch] <= #{1}#",
                                          tuNgay.ToString("MM/dd/yyyy"),
                                          denNgay.ToString("MM/dd/yyyy"));

            // 4. Kết hợp với ô Tìm kiếm (nếu có nhập chữ trong txtTimKiem)
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
                filter += string.Format(" AND ([Nội dung] LIKE '%{0}%' OR [Loại giao dịch] LIKE '%{0}%')", keyword);
            }

            // 5. Thực thi lọc
            bs.Filter = filter;

            // Thông báo nếu không thấy kết quả
            if (bs.Count == 0)
            {
                MessageBox.Show("Không có giao dịch nào trong khoảng thời gian này.", "Thông báo");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem BindingSource đã có dữ liệu chưa để tránh lỗi
            if (bs.DataSource == null) return;

            // 2. Lấy từ khóa từ chính ô TextBox này
            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(keyword))
            {
                // 3. Nếu xóa hết chữ trong ô tìm kiếm, hiện lại toàn bộ lịch sử
                bs.Filter = "";
            }
            else
            {
                // 4. Thực hiện lọc ngay lập tức
                // Lưu ý: Tên [Loại giao dịch], [Nội dung] phải viết y hệt như trong câu lệnh SQL SELECT ở hàm LoadHistory
                string filter = string.Format("([Loại giao dịch] LIKE '%{0}%') OR ([Nội dung] LIKE '%{0}%') OR ([Số tài khoản] LIKE '%{0}%')", keyword);
                bs.Filter = filter;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
 }
