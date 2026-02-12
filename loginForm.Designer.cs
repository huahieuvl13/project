namespace project
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegis = new System.Windows.Forms.Label();
            this.lblForgot = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblRegis);
            this.panel1.Controls.Add(this.lblForgot);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMatkhau);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Location = new System.Drawing.Point(49, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 475);
            this.panel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(214, 344);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(393, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegis
            // 
            this.lblRegis.AutoSize = true;
            this.lblRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegis.ForeColor = System.Drawing.Color.Teal;
            this.lblRegis.Location = new System.Drawing.Point(550, 409);
            this.lblRegis.Name = "lblRegis";
            this.lblRegis.Size = new System.Drawing.Size(56, 16);
            this.lblRegis.TabIndex = 3;
            this.lblRegis.Text = "Đăng ký";
            this.lblRegis.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.Teal;
            this.lblForgot.Location = new System.Drawing.Point(210, 409);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(96, 16);
            this.lblForgot.TabIndex = 3;
            this.lblForgot.Text = "Quên mật khẩu";
            this.lblForgot.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(210, 245);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(207, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng nhập vào tài khoản ngân hàng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(202, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "BANKING";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMatkhau.Location = new System.Drawing.Point(213, 293);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(393, 24);
            this.txtMatkhau.TabIndex = 1;
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.TextChanged += new System.EventHandler(this.txtMatkhau_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.Location = new System.Drawing.Point(213, 192);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(393, 29);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(965, 547);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblRegis;
    }
}

