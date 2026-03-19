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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.panelNaptien = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNap = new System.Windows.Forms.Panel();
            this.btnNap = new System.Windows.Forms.Button();
            this.cboMenhGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNap = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTransferBox = new System.Windows.Forms.Panel();
            this.panelChuyen = new System.Windows.Forms.Panel();
            this.lblSoTKNhan = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.btnXacNhanChuyen = new System.Windows.Forms.Button();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblTransferTitle = new System.Windows.Forms.Label();
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
            this.panelNutTim = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelNaptien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNap.SuspendLayout();
            this.panelTransfer.SuspendLayout();
            this.panelTransferBox.SuspendLayout();
            this.panelChuyen.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelAccountInfo.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelNutTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(180, 598);
            this.panelMenu.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelHistory);
            this.panelMain.Controls.Add(this.panelNaptien);
            this.panelMain.Controls.Add(this.panelTransfer);
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(832, 598);
            this.panelMain.TabIndex = 0;
            // 
            // panelHistory
            // 
            this.panelHistory.Controls.Add(this.tableLayoutPanel1);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(832, 598);
            this.panelHistory.TabIndex = 2;
            this.panelHistory.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelNutTim, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvHistory, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 598);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeight = 29;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvHistory, 5);
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(3, 185);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.Size = new System.Drawing.Size(826, 410);
            this.dgvHistory.TabIndex = 0;
            // 
            // panelNaptien
            // 
            this.panelNaptien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelNap);
            this.panel2.Controls.Add(this.lblNap);
            this.panel2.Location = new System.Drawing.Point(26, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 458);
            this.panel2.TabIndex = 4;
            // 
            // panelNap
            // 
            this.panelNap.Controls.Add(this.btnNap);
            this.panelNap.Controls.Add(this.cboMenhGia);
            this.panelNap.Controls.Add(this.label3);
            this.panelNap.Controls.Add(this.txtMaThe);
            this.panelNap.Controls.Add(this.label1);
            this.panelNap.Controls.Add(this.txtSerial);
            this.panelNap.Controls.Add(this.label4);
            this.panelNap.Location = new System.Drawing.Point(33, 59);
            this.panelNap.Name = "panelNap";
            this.panelNap.Size = new System.Drawing.Size(694, 364);
            this.panelNap.TabIndex = 10;
            // 
            // btnNap
            // 
            this.btnNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNap.Location = new System.Drawing.Point(261, 255);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(189, 34);
            this.btnNap.TabIndex = 3;
            this.btnNap.Text = "Xác nhận nạp";
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.button1_Click);
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
            this.cboMenhGia.Location = new System.Drawing.Point(100, 9);
            this.cboMenhGia.Name = "cboMenhGia";
            this.cboMenhGia.Size = new System.Drawing.Size(566, 24);
            this.cboMenhGia.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bodoni MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seri:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(100, 85);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(566, 22);
            this.txtMaThe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(100, 179);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(566, 22);
            this.txtSerial.TabIndex = 6;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã thẻ:";
            // 
            // lblNap
            // 
            this.lblNap.AutoSize = true;
            this.lblNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNap.Location = new System.Drawing.Point(28, 14);
            this.lblNap.Name = "lblNap";
            this.lblNap.Size = new System.Drawing.Size(92, 25);
            this.lblNap.TabIndex = 4;
            this.lblNap.Text = "Nạp tiền";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 68);
            this.panel3.TabIndex = 6;
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.Color.White;
            this.panelTransfer.Controls.Add(this.panel1);
            this.panelTransfer.Controls.Add(this.panelTransferBox);
            this.panelTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransfer.Location = new System.Drawing.Point(0, 0);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(832, 598);
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
            this.panelTransferBox.Controls.Add(this.panelChuyen);
            this.panelTransferBox.Controls.Add(this.lblTransferTitle);
            this.panelTransferBox.Location = new System.Drawing.Point(42, 107);
            this.panelTransferBox.Name = "panelTransferBox";
            this.panelTransferBox.Size = new System.Drawing.Size(754, 445);
            this.panelTransferBox.TabIndex = 0;
            // 
            // panelChuyen
            // 
            this.panelChuyen.Controls.Add(this.lblSoTKNhan);
            this.panelChuyen.Controls.Add(this.txtNoidung);
            this.panelChuyen.Controls.Add(this.btnXacNhanChuyen);
            this.panelChuyen.Controls.Add(this.txtSoTKNhan);
            this.panelChuyen.Controls.Add(this.label2);
            this.panelChuyen.Controls.Add(this.lblSoTien);
            this.panelChuyen.Controls.Add(this.txtSoTien);
            this.panelChuyen.Location = new System.Drawing.Point(22, 66);
            this.panelChuyen.Name = "panelChuyen";
            this.panelChuyen.Size = new System.Drawing.Size(705, 343);
            this.panelChuyen.TabIndex = 8;
            // 
            // lblSoTKNhan
            // 
            this.lblSoTKNhan.BackColor = System.Drawing.Color.White;
            this.lblSoTKNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTKNhan.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSoTKNhan.Location = new System.Drawing.Point(6, 22);
            this.lblSoTKNhan.Name = "lblSoTKNhan";
            this.lblSoTKNhan.Size = new System.Drawing.Size(177, 32);
            this.lblSoTKNhan.TabIndex = 1;
            this.lblSoTKNhan.Text = "Số tài khoản nhận:";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(17, 212);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(667, 59);
            this.txtNoidung.TabIndex = 7;
            // 
            // btnXacNhanChuyen
            // 
            this.btnXacNhanChuyen.Location = new System.Drawing.Point(271, 277);
            this.btnXacNhanChuyen.Name = "btnXacNhanChuyen";
            this.btnXacNhanChuyen.Size = new System.Drawing.Size(149, 46);
            this.btnXacNhanChuyen.TabIndex = 5;
            this.btnXacNhanChuyen.Text = "XÁC NHẬN CHUYỂN";
            this.btnXacNhanChuyen.Click += new System.EventHandler(this.btnXacNhanChuyen_Click);
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.Location = new System.Drawing.Point(225, 27);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.Size = new System.Drawing.Size(459, 22);
            this.txtSoTKNhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nội dung:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoTien
            // 
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSoTien.Location = new System.Drawing.Point(6, 85);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(102, 30);
            this.lblSoTien.TabIndex = 3;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(225, 101);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(459, 22);
            this.txtSoTien.TabIndex = 4;
            // 
            // lblTransferTitle
            // 
            this.lblTransferTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTransferTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTransferTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTransferTitle.Name = "lblTransferTitle";
            this.lblTransferTitle.Size = new System.Drawing.Size(277, 43);
            this.lblTransferTitle.TabIndex = 0;
            this.lblTransferTitle.Text = "CHUYỂN KHOẢN";
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.White;
            this.panelAccount.Controls.Add(this.panelAccountInfo);
            this.panelAccount.Controls.Add(this.panelHeader);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(832, 598);
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
            this.lblChuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChuTK.Location = new System.Drawing.Point(263, 126);
            this.lblChuTK.Name = "lblChuTK";
            this.lblChuTK.Size = new System.Drawing.Size(216, 25);
            this.lblChuTK.TabIndex = 5;
            // 
            // lblHienthisodu
            // 
            this.lblHienthisodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienthisodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHienthisodu.Location = new System.Drawing.Point(263, 195);
            this.lblHienthisodu.Name = "lblHienthisodu";
            this.lblHienthisodu.Size = new System.Drawing.Size(216, 25);
            this.lblHienthisodu.TabIndex = 6;
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(13, 63);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(191, 23);
            this.lblSoTaiKhoan.TabIndex = 1;
            this.lblSoTaiKhoan.Text = "Số tài khoản:";
            // 
            // lblHienthiSTK
            // 
            this.lblHienthiSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienthiSTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHienthiSTK.Location = new System.Drawing.Point(263, 64);
            this.lblHienthiSTK.Name = "lblHienthiSTK";
            this.lblHienthiSTK.Size = new System.Drawing.Size(216, 25);
            this.lblHienthiSTK.TabIndex = 4;
            this.lblHienthiSTK.Click += new System.EventHandler(this.lblHienthiSTK_Click);
            // 
            // lblTenChuTK
            // 
            this.lblTenChuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuTK.ForeColor = System.Drawing.SystemColors.ActiveBorder;
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
            // panelNutTim
            // 
            this.panelNutTim.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.SetColumnSpan(this.panelNutTim, 2);
            this.panelNutTim.Controls.Add(this.panel4);
            this.panelNutTim.Controls.Add(this.btnReset);
            this.panelNutTim.Controls.Add(this.btnTimkiem);
            this.panelNutTim.Controls.Add(this.label7);
            this.panelNutTim.Controls.Add(this.label6);
            this.panelNutTim.Controls.Add(this.label5);
            this.panelNutTim.Controls.Add(this.dateTimePicker2);
            this.panelNutTim.Controls.Add(this.dateTimePicker1);
            this.panelNutTim.Controls.Add(this.txtTimKiem);
            this.panelNutTim.Location = new System.Drawing.Point(3, 3);
            this.panelNutTim.Name = "panelNutTim";
            this.panelNutTim.Size = new System.Drawing.Size(826, 176);
            this.panelNutTim.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 127);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(143, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(406, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Từ ngày:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đến ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tìm nội dung:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Image = global::project.Properties.Resources.icons8_reset_30;
            this.btnReset.Location = new System.Drawing.Point(712, 92);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 62);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTimkiem.Image = global::project.Properties.Resources.icons8_filter_24__1_;
            this.btnTimkiem.Location = new System.Drawing.Point(612, 93);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(93, 62);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = "Lọc";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.button1_Click_1);
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
            this.btnDangXuat.Image = global::project.Properties.Resources.log_out;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 548);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(180, 50);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTien.Image = global::project.Properties.Resources.save_money;
            this.btnChuyenTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenTien.Location = new System.Drawing.Point(0, 309);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(180, 69);
            this.btnChuyenTien.TabIndex = 1;
            this.btnChuyenTien.Text = "Chuyển tiền";
            this.btnChuyenTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.Image = global::project.Properties.Resources.transaction_history;
            this.btnLichSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSu.Location = new System.Drawing.Point(0, 384);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(180, 69);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.AutoSize = true;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = global::project.Properties.Resources.passbook1;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 160);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(180, 70);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNapTien
            // 
            this.btnNapTien.BackColor = System.Drawing.Color.Teal;
            this.btnNapTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapTien.Image = global::project.Properties.Resources.mobile_banking;
            this.btnNapTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNapTien.Location = new System.Drawing.Point(3, 235);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(177, 69);
            this.btnNapTien.TabIndex = 4;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNapTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNapTien.UseVisualStyleBackColor = false;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(822, 76);
            this.panel4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 44);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giao dịch gần đây";
            // 
            // FormDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1012, 598);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelNaptien.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelNap.ResumeLayout(false);
            this.panelNap.PerformLayout();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransferBox.ResumeLayout(false);
            this.panelChuyen.ResumeLayout(false);
            this.panelChuyen.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccountInfo.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelNutTim.ResumeLayout(false);
            this.panelNutTim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelNap;
        private System.Windows.Forms.Panel panelChuyen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelNutTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
    }
}
