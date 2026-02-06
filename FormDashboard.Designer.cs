namespace project
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnHistory;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoTk = new System.Windows.Forms.Label();
            this.lblTendn = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.btnConfirmTransfer = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            btnHistory = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.BackColor = System.Drawing.Color.Teal;
            btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnHistory.Location = new System.Drawing.Point(2, 224);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new System.Drawing.Size(189, 49);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "Lịch sử giao dịch";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(btnHistory);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnChuyenTien);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.Location = new System.Drawing.Point(2, 279);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(189, 49);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Teal;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(2, 117);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(189, 49);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnAccount);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.BackColor = System.Drawing.Color.Teal;
            this.btnChuyenTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChuyenTien.Location = new System.Drawing.Point(2, 171);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(189, 49);
            this.btnChuyenTien.TabIndex = 2;
            this.btnChuyenTien.Text = "Chuyển tiền";
            this.btnChuyenTien.UseVisualStyleBackColor = false;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.Ảnh_chụp_màn_hình_2026_01_23_150122;
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Controls.Add(this.panelHistory);
            this.panelMain.Controls.Add(this.panelTransfer);
            this.panelMain.Location = new System.Drawing.Point(196, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(751, 437);
            this.panelMain.TabIndex = 10;
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.White;
            this.panelAccount.Controls.Add(this.label5);
            this.panelAccount.Controls.Add(this.label4);
            this.panelAccount.Controls.Add(this.lblSoTk);
            this.panelAccount.Controls.Add(this.lblTendn);
            this.panelAccount.Controls.Add(this.lblBalance);
            this.panelAccount.Controls.Add(this.label3);
            this.panelAccount.Controls.Add(this.label2);
            this.panelAccount.Controls.Add(this.lblWelcome);
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(905, 449);
            this.panelAccount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 50);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số dư khả dụng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // lblSoTk
            // 
            this.lblSoTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTk.Location = new System.Drawing.Point(264, 186);
            this.lblSoTk.Name = "lblSoTk";
            this.lblSoTk.Size = new System.Drawing.Size(131, 50);
            this.lblSoTk.TabIndex = 7;
            this.lblSoTk.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblTendn
            // 
            this.lblTendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendn.Location = new System.Drawing.Point(264, 254);
            this.lblTendn.Name = "lblTendn";
            this.lblTendn.Size = new System.Drawing.Size(131, 50);
            this.lblTendn.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(264, 344);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(131, 50);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "0 VND";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số tài khoản:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông tin tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Gray;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(905, 73);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelHistory
            // 
            this.panelHistory.AutoSize = true;
            this.panelHistory.BackColor = System.Drawing.Color.White;
            this.panelHistory.Controls.Add(this.dgvHistory);
            this.panelHistory.Controls.Add(this.label16);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(751, 437);
            this.panelHistory.TabIndex = 7;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.colType,
            this.colAmount,
            this.colNote});
            this.dgvHistory.Location = new System.Drawing.Point(3, 154);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(747, 173);
            this.dgvHistory.TabIndex = 1;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Thời gian";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Loại giao dịch";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Số tiền";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Nội dung";
            this.colNote.MinimumWidth = 6;
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AllowDrop = true;
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(751, 91);
            this.label16.TabIndex = 0;
            this.label16.Text = "  Lịch sử giao dịch";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransfer.Controls.Add(this.btnConfirmTransfer);
            this.panelTransfer.Controls.Add(this.label15);
            this.panelTransfer.Controls.Add(this.label14);
            this.panelTransfer.Controls.Add(this.txtAmount);
            this.panelTransfer.Controls.Add(this.txtReceiver);
            this.panelTransfer.Controls.Add(this.label13);
            this.panelTransfer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelTransfer.Location = new System.Drawing.Point(0, 0);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(1044, 437);
            this.panelTransfer.TabIndex = 6;
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.BackColor = System.Drawing.Color.Silver;
            this.btnConfirmTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(660, 266);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Padding = new System.Windows.Forms.Padding(1);
            this.btnConfirmTransfer.Size = new System.Drawing.Size(87, 34);
            this.btnConfirmTransfer.TabIndex = 4;
            this.btnConfirmTransfer.Text = "Xác nhận";
            this.btnConfirmTransfer.UseVisualStyleBackColor = false;
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(21, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 32);
            this.label15.TabIndex = 3;
            this.label15.Text = "Số tiền:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(21, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 32);
            this.label14.TabIndex = 3;
            this.label14.Text = "Số tài khoản nhận:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(27, 266);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(630, 34);
            this.txtAmount.TabIndex = 1;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(27, 162);
            this.txtReceiver.Multiline = true;
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(713, 34);
            this.txtReceiver.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(-1, -5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(758, 73);
            this.label13.TabIndex = 0;
            this.label13.Text = "  Chuyển tiền";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMain);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.Form2);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.Button btnConfirmTransfer;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoTk;
        private System.Windows.Forms.Label lblTendn;
        private System.Windows.Forms.Label lblBalance;
    }
}