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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.panelTransferBox = new System.Windows.Forms.Panel();
            this.lblTransferTitle = new System.Windows.Forms.Label();
            this.lblSoTKNhan = new System.Windows.Forms.Label();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnXacNhanChuyen = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.panelAccountInfo = new System.Windows.Forms.Panel();
            this.lblHienthisodu = new System.Windows.Forms.Label();
            this.lblChuTK = new System.Windows.Forms.Label();
            this.lblHienthiSTK = new System.Windows.Forms.Label();
            this.lblTitleAccount = new System.Windows.Forms.Label();
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.lblTenChuTK = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelTransfer.SuspendLayout();
            this.panelTransferBox.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelAccountInfo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnNapTien);
            this.panelMenu.Controls.Add(this.btnChuyenTien);
            this.panelMenu.Controls.Add(this.btnLichSu);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 500);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(180, 50);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // btnNapTien
            // 
            this.btnNapTien.BackColor = System.Drawing.Color.Teal;
            this.btnNapTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNapTien.Location = new System.Drawing.Point(0, 150);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(180, 50);
            this.btnNapTien.TabIndex = 4;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = false;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChuyenTien.Location = new System.Drawing.Point(0, 100);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(180, 50);
            this.btnChuyenTien.TabIndex = 1;
            this.btnChuyenTien.Text = "Chuyển tiền";
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSu.Location = new System.Drawing.Point(0, 50);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(180, 50);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(180, 50);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelHistory);
            this.panelMain.Controls.Add(this.panelTransfer);
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(720, 550);
            this.panelMain.TabIndex = 0;
            // 
            // panelHistory
            // 
            this.panelHistory.Controls.Add(this.dgvHistory);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(720, 550);
            this.panelHistory.TabIndex = 2;
            this.panelHistory.Visible = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeight = 29;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.Size = new System.Drawing.Size(720, 550);
            this.dgvHistory.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại GD";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "STK liên quan";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nội dung";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTransfer.Controls.Add(this.panelTransferBox);
            this.panelTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransfer.Location = new System.Drawing.Point(0, 0);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(720, 550);
            this.panelTransfer.TabIndex = 1;
            this.panelTransfer.Visible = false;
            // 
            // panelTransferBox
            // 
            this.panelTransferBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransferBox.Controls.Add(this.lblTransferTitle);
            this.panelTransferBox.Controls.Add(this.lblSoTKNhan);
            this.panelTransferBox.Controls.Add(this.txtSoTKNhan);
            this.panelTransferBox.Controls.Add(this.lblSoTien);
            this.panelTransferBox.Controls.Add(this.txtSoTien);
            this.panelTransferBox.Controls.Add(this.btnXacNhanChuyen);
            this.panelTransferBox.Location = new System.Drawing.Point(80, 60);
            this.panelTransferBox.Name = "panelTransferBox";
            this.panelTransferBox.Size = new System.Drawing.Size(500, 380);
            this.panelTransferBox.TabIndex = 0;
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
            this.lblSoTKNhan.Location = new System.Drawing.Point(20, 80);
            this.lblSoTKNhan.Name = "lblSoTKNhan";
            this.lblSoTKNhan.Size = new System.Drawing.Size(100, 23);
            this.lblSoTKNhan.TabIndex = 1;
            this.lblSoTKNhan.Text = "Số tài khoản nhận";
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.Location = new System.Drawing.Point(20, 105);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.Size = new System.Drawing.Size(350, 22);
            this.txtSoTKNhan.TabIndex = 2;
            // 
            // lblSoTien
            // 
            this.lblSoTien.Location = new System.Drawing.Point(20, 145);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(100, 23);
            this.lblSoTien.TabIndex = 3;
            this.lblSoTien.Text = "Số tiền";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(20, 170);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(350, 22);
            this.txtSoTien.TabIndex = 4;
            // 
            // btnXacNhanChuyen
            // 
            this.btnXacNhanChuyen.Location = new System.Drawing.Point(20, 220);
            this.btnXacNhanChuyen.Name = "btnXacNhanChuyen";
            this.btnXacNhanChuyen.Size = new System.Drawing.Size(350, 23);
            this.btnXacNhanChuyen.TabIndex = 5;
            this.btnXacNhanChuyen.Text = "XÁC NHẬN CHUYỂN";
            this.btnXacNhanChuyen.Click += new System.EventHandler(this.btnXacNhanChuyen_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.White;
            this.panelAccount.Controls.Add(this.panelAccountInfo);
            this.panelAccount.Controls.Add(this.panelHeader);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(720, 550);
            this.panelAccount.TabIndex = 0;
            // 
            // panelAccountInfo
            // 
            this.panelAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAccountInfo.Controls.Add(this.lblHienthisodu);
            this.panelAccountInfo.Controls.Add(this.lblChuTK);
            this.panelAccountInfo.Controls.Add(this.lblHienthiSTK);
            this.panelAccountInfo.Controls.Add(this.lblTitleAccount);
            this.panelAccountInfo.Controls.Add(this.lblSoTaiKhoan);
            this.panelAccountInfo.Controls.Add(this.lblTenChuTK);
            this.panelAccountInfo.Controls.Add(this.lblSoDu);
            this.panelAccountInfo.Location = new System.Drawing.Point(50, 120);
            this.panelAccountInfo.Name = "panelAccountInfo";
            this.panelAccountInfo.Size = new System.Drawing.Size(600, 300);
            this.panelAccountInfo.TabIndex = 0;
            this.panelAccountInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccountInfo_Paint);
            // 
            // lblHienthisodu
            // 
            this.lblHienthisodu.AutoSize = true;
            this.lblHienthisodu.Location = new System.Drawing.Point(243, 160);
            this.lblHienthisodu.Name = "lblHienthisodu";
            this.lblHienthisodu.Size = new System.Drawing.Size(44, 16);
            this.lblHienthisodu.TabIndex = 6;
            this.lblHienthisodu.Text = "label1";
            // 
            // lblChuTK
            // 
            this.lblChuTK.AutoSize = true;
            this.lblChuTK.Location = new System.Drawing.Point(240, 120);
            this.lblChuTK.Name = "lblChuTK";
            this.lblChuTK.Size = new System.Drawing.Size(40, 16);
            this.lblChuTK.TabIndex = 5;
            this.lblChuTK.Text = "Chutk";
            // 
            // lblHienthiSTK
            // 
            this.lblHienthiSTK.AutoSize = true;
            this.lblHienthiSTK.Location = new System.Drawing.Point(240, 80);
            this.lblHienthiSTK.Name = "lblHienthiSTK";
            this.lblHienthiSTK.Size = new System.Drawing.Size(24, 16);
            this.lblHienthiSTK.TabIndex = 4;
            this.lblHienthiSTK.Text = "stk";
            // 
            // lblTitleAccount
            // 
            this.lblTitleAccount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleAccount.Location = new System.Drawing.Point(20, 20);
            this.lblTitleAccount.Name = "lblTitleAccount";
            this.lblTitleAccount.Size = new System.Drawing.Size(295, 47);
            this.lblTitleAccount.TabIndex = 0;
            this.lblTitleAccount.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(20, 80);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(100, 23);
            this.lblSoTaiKhoan.TabIndex = 1;
            this.lblSoTaiKhoan.Text = "Số tài khoản:";
            // 
            // lblTenChuTK
            // 
            this.lblTenChuTK.Location = new System.Drawing.Point(20, 120);
            this.lblTenChuTK.Name = "lblTenChuTK";
            this.lblTenChuTK.Size = new System.Drawing.Size(100, 23);
            this.lblTenChuTK.TabIndex = 2;
            this.lblTenChuTK.Text = "Chủ tài khoản:";
            // 
            // lblSoDu
            // 
            this.lblSoDu.ForeColor = System.Drawing.Color.Green;
            this.lblSoDu.Location = new System.Drawing.Point(20, 160);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(100, 23);
            this.lblSoDu.TabIndex = 3;
            this.lblSoDu.Text = "Số dư:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.lblXinchao);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(720, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // lblXinchao
            // 
            this.lblXinchao.ForeColor = System.Drawing.Color.White;
            this.lblXinchao.Location = new System.Drawing.Point(20, 25);
            this.lblXinchao.Name = "lblXinchao";
            this.lblXinchao.Size = new System.Drawing.Size(346, 23);
            this.lblXinchao.TabIndex = 0;
            // 
            // FormDashboard
            // 
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransferBox.ResumeLayout(false);
            this.panelTransferBox.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccountInfo.ResumeLayout(false);
            this.panelAccountInfo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblHienthisodu;
        private System.Windows.Forms.Label lblChuTK;
        private System.Windows.Forms.Label lblHienthiSTK;
        private System.Windows.Forms.Button btnNapTien;

    }
}
