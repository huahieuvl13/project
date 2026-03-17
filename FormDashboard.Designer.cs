namespace project
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelNaptien = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboMenhGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.lblNap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.panelAccountInfo = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblChuTK = new System.Windows.Forms.Label();
            this.lblHienthisodu = new System.Windows.Forms.Label();
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.lblHienthiSTK = new System.Windows.Forms.Label();
            this.lblTenChuTK = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.lblTitleAccount = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTransferBox = new System.Windows.Forms.Panel();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransferTitle = new System.Windows.Forms.Label();
            this.lblSoTKNhan = new System.Windows.Forms.Label();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnXacNhanChuyen = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelNaptien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelAccountInfo.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelTransfer.SuspendLayout();
            this.panelTransferBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnChuyenTien);
            this.panelMenu.Controls.Add(this.btnLichSu);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnNapTien);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 572);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.bank__1_;
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::project.Properties.Resources._17507002;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 522);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(180, 50);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTien.Image = global::project.Properties.Resources.transference;
            this.btnChuyenTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenTien.Location = new System.Drawing.Point(3, 310);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(180, 69);
            this.btnChuyenTien.TabIndex = 1;
            this.btnChuyenTien.Text = "Chuyển tiền";
            this.btnChuyenTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.Image = global::project.Properties.Resources.file__1_;
            this.btnLichSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSu.Location = new System.Drawing.Point(0, 384);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(180, 69);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.AutoSize = true;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = global::project.Properties.Resources.passbook1;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 160);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(182, 70);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNapTien
            // 
            this.btnNapTien.BackColor = System.Drawing.Color.Teal;
            this.btnNapTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapTien.Image = global::project.Properties.Resources.money;
            this.btnNapTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNapTien.Location = new System.Drawing.Point(3, 235);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(177, 69);
            this.btnNapTien.TabIndex = 4;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNapTien.UseVisualStyleBackColor = false;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Controls.Add(this.panelNaptien);
            this.panelMain.Controls.Add(this.panelHistory);
            this.panelMain.Controls.Add(this.panelTransfer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(832, 572);
            this.panelMain.TabIndex = 0;
            // 
            // panelNaptien
            // 
            this.panelNaptien.Controls.Add(this.panel2);
            this.panelNaptien.Controls.Add(this.panel3);
            this.panelNaptien.Location = new System.Drawing.Point(0, 0);
            this.panelNaptien.Name = "panelNaptien";
            this.panelNaptien.Size = new System.Drawing.Size(829, 572);
            this.panelNaptien.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.cboMenhGia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSerial);
            this.panel2.Controls.Add(this.txtMaThe);
            this.panel2.Controls.Add(this.lblNap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnNap);
            this.panel2.Location = new System.Drawing.Point(22, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 396);
            this.panel2.TabIndex = 4;
            // 
            // cboMenhGia
            // 
            this.cboMenhGia.FormattingEnabled = true;
            this.cboMenhGia.Items.AddRange(new object[] {
            "10000",
            "20000",
            "50000",
            "100000",
            "200000",
            "500000"});
            this.cboMenhGia.Location = new System.Drawing.Point(113, 87);
            this.cboMenhGia.Name = "cboMenhGia";
            this.cboMenhGia.Size = new System.Drawing.Size(121, 24);
            this.cboMenhGia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã thẻ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seri:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(113, 205);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(366, 22);
            this.txtSerial.TabIndex = 6;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(103, 297);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(366, 22);
            this.txtMaThe.TabIndex = 5;
            // 
            // lblNap
            // 
            this.lblNap.AutoSize = true;
            this.lblNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNap.Location = new System.Drawing.Point(28, 31);
            this.lblNap.Name = "lblNap";
            this.lblNap.Size = new System.Drawing.Size(92, 25);
            this.lblNap.TabIndex = 4;
            this.lblNap.Text = "Nạp tiền";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền";
            // 
            // btnNap
            // 
            this.btnNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNap.Location = new System.Drawing.Point(531, 207);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(117, 39);
            this.btnNap.TabIndex = 3;
            this.btnNap.Text = "Xác nhận nạp";
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 68);
            this.panel3.TabIndex = 6;
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.White;
            this.panelAccount.Controls.Add(this.panelAccountInfo);
            this.panelAccount.Controls.Add(this.panelHeader);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(832, 572);
            this.panelAccount.TabIndex = 0;
            // 
            // panelAccountInfo
            // 
            this.panelAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAccountInfo.Controls.Add(this.panelCard);
            this.panelAccountInfo.Controls.Add(this.lblTitleAccount);
            this.panelAccountInfo.Location = new System.Drawing.Point(42, 86);
            this.panelAccountInfo.Name = "panelAccountInfo";
            this.panelAccountInfo.Size = new System.Drawing.Size(728, 431);
            this.panelAccountInfo.TabIndex = 0;
            this.panelAccountInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccountInfo_Paint);
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.Teal;
            this.panelCard.Controls.Add(this.lblChuTK);
            this.panelCard.Controls.Add(this.lblHienthisodu);
            this.panelCard.Controls.Add(this.lblSoTaiKhoan);
            this.panelCard.Controls.Add(this.lblHienthiSTK);
            this.panelCard.Controls.Add(this.lblTenChuTK);
            this.panelCard.Controls.Add(this.lblSoDu);
            this.panelCard.Location = new System.Drawing.Point(15, 62);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(694, 337);
            this.panelCard.TabIndex = 7;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblChuTK
            // 
            this.lblChuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuTK.Location = new System.Drawing.Point(263, 126);
            this.lblChuTK.Name = "lblChuTK";
            this.lblChuTK.Size = new System.Drawing.Size(216, 25);
            this.lblChuTK.TabIndex = 5;
            // 
            // lblHienthisodu
            // 
            this.lblHienthisodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienthisodu.Location = new System.Drawing.Point(273, 195);
            this.lblHienthisodu.Name = "lblHienthisodu";
            this.lblHienthisodu.Size = new System.Drawing.Size(129, 25);
            this.lblHienthisodu.TabIndex = 6;
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(13, 63);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(191, 23);
            this.lblSoTaiKhoan.TabIndex = 1;
            this.lblSoTaiKhoan.Text = "Số tài khoản:";
            // 
            // lblHienthiSTK
            // 
            this.lblHienthiSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienthiSTK.Location = new System.Drawing.Point(263, 64);
            this.lblHienthiSTK.Name = "lblHienthiSTK";
            this.lblHienthiSTK.Size = new System.Drawing.Size(281, 25);
            this.lblHienthiSTK.TabIndex = 4;
            this.lblHienthiSTK.Click += new System.EventHandler(this.lblHienthiSTK_Click);
            // 
            // lblTenChuTK
            // 
            this.lblTenChuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuTK.Location = new System.Drawing.Point(13, 128);
            this.lblTenChuTK.Name = "lblTenChuTK";
            this.lblTenChuTK.Size = new System.Drawing.Size(145, 23);
            this.lblTenChuTK.TabIndex = 2;
            this.lblTenChuTK.Text = "Chủ tài khoản:";
            // 
            // lblSoDu
            // 
            this.lblSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDu.ForeColor = System.Drawing.Color.Green;
            this.lblSoDu.Location = new System.Drawing.Point(13, 197);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(145, 23);
            this.lblSoDu.TabIndex = 3;
            this.lblSoDu.Text = "Số dư:";
            // 
            // lblTitleAccount
            // 
            this.lblTitleAccount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleAccount.Location = new System.Drawing.Point(20, 12);
            this.lblTitleAccount.Name = "lblTitleAccount";
            this.lblTitleAccount.Size = new System.Drawing.Size(295, 47);
            this.lblTitleAccount.TabIndex = 0;
            this.lblTitleAccount.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.lblXinchao);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(832, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // lblXinchao
            // 
            this.lblXinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinchao.ForeColor = System.Drawing.Color.White;
            this.lblXinchao.Location = new System.Drawing.Point(20, 9);
            this.lblXinchao.Name = "lblXinchao";
            this.lblXinchao.Size = new System.Drawing.Size(389, 46);
            this.lblXinchao.TabIndex = 0;
            // 
            // panelHistory
            // 
            this.panelHistory.Controls.Add(this.dgvHistory);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(832, 572);
            this.panelHistory.TabIndex = 2;
            this.panelHistory.Visible = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeight = 29;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.Size = new System.Drawing.Size(832, 572);
            this.dgvHistory.TabIndex = 0;
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTransfer.Controls.Add(this.panel1);
            this.panelTransfer.Controls.Add(this.panelTransferBox);
            this.panelTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransfer.Location = new System.Drawing.Point(0, 0);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(832, 572);
            this.panelTransfer.TabIndex = 1;
            this.panelTransfer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 70);
            this.panel1.TabIndex = 2;
            // 
            // panelTransferBox
            // 
            this.panelTransferBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransferBox.Controls.Add(this.txtNoidung);
            this.panelTransferBox.Controls.Add(this.label2);
            this.panelTransferBox.Controls.Add(this.lblTransferTitle);
            this.panelTransferBox.Controls.Add(this.lblSoTKNhan);
            this.panelTransferBox.Controls.Add(this.txtSoTKNhan);
            this.panelTransferBox.Controls.Add(this.lblSoTien);
            this.panelTransferBox.Controls.Add(this.txtSoTien);
            this.panelTransferBox.Controls.Add(this.btnXacNhanChuyen);
            this.panelTransferBox.Location = new System.Drawing.Point(42, 107);
            this.panelTransferBox.Name = "panelTransferBox";
            this.panelTransferBox.Size = new System.Drawing.Size(754, 445);
            this.panelTransferBox.TabIndex = 0;
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(28, 314);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(646, 22);
            this.txtNoidung.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nội dung:";
            // 
            // lblTransferTitle
            // 
            this.lblTransferTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTransferTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTransferTitle.Name = "lblTransferTitle";
            this.lblTransferTitle.Size = new System.Drawing.Size(277, 43);
            this.lblTransferTitle.TabIndex = 0;
            this.lblTransferTitle.Text = "CHUYỂN KHOẢN";
            // 
            // lblSoTKNhan
            // 
            this.lblSoTKNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSoTKNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTKNhan.Location = new System.Drawing.Point(21, 99);
            this.lblSoTKNhan.Name = "lblSoTKNhan";
            this.lblSoTKNhan.Size = new System.Drawing.Size(259, 36);
            this.lblSoTKNhan.TabIndex = 1;
            this.lblSoTKNhan.Text = "Số tài khoản nhận:";
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.Location = new System.Drawing.Point(26, 142);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.Size = new System.Drawing.Size(646, 22);
            this.txtSoTKNhan.TabIndex = 2;
            // 
            // lblSoTien
            // 
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSoTien.Location = new System.Drawing.Point(21, 183);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(122, 23);
            this.lblSoTien.TabIndex = 3;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(23, 223);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(646, 22);
            this.txtSoTien.TabIndex = 4;
            // 
            // btnXacNhanChuyen
            // 
            this.btnXacNhanChuyen.Location = new System.Drawing.Point(283, 363);
            this.btnXacNhanChuyen.Name = "btnXacNhanChuyen";
            this.btnXacNhanChuyen.Size = new System.Drawing.Size(149, 46);
            this.btnXacNhanChuyen.TabIndex = 5;
            this.btnXacNhanChuyen.Text = "XÁC NHẬN CHUYỂN";
            this.btnXacNhanChuyen.Click += new System.EventHandler(this.btnXacNhanChuyen_Click);
            // 
            // FormDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1012, 572);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelNaptien.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccountInfo.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransferBox.ResumeLayout(false);
            this.panelTransferBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Button btnDangXuat;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.Panel panelHistory;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblXinchao;

        private System.Windows.Forms.Panel panelAccountInfo;
        private System.Windows.Forms.Label lblTitleAccount;
        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.Label lblTenChuTK;
        private System.Windows.Forms.Label lblSoDu;

        private System.Windows.Forms.Panel panelTransferBox;
        private System.Windows.Forms.Label lblTransferTitle;
        private System.Windows.Forms.Label lblSoTKNhan;
        private System.Windows.Forms.TextBox txtSoTKNhan;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnXacNhanChuyen;

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHienthisodu;
        private System.Windows.Forms.Label lblChuTK;
        private System.Windows.Forms.Label lblHienthiSTK;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNaptien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.ComboBox cboMenhGia;
    }
}
