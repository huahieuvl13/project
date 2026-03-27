namespace project
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.lblSub);
            this.panelMain.Controls.Add(this.lblPhone);
            this.panelMain.Controls.Add(this.txtSTK);
            this.panelMain.Controls.Add(this.lblNewPass);
            this.panelMain.Controls.Add(this.txtNewPass);
            this.panelMain.Controls.Add(this.lblConfirm);
            this.panelMain.Controls.Add(this.txtConfirm);
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.lblBack);
            this.panelMain.Location = new System.Drawing.Point(256, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(480, 455);
            this.panelMain.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Image = global::project.Properties.Resources.icons8_banking_50;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(105, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 48);
            this.label2.TabIndex = 24;
            this.label2.Text = "BANKING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Image = global::project.Properties.Resources.icons8_password_50;
            this.label1.Location = new System.Drawing.Point(54, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 56);
            this.label1.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Image = global::project.Properties.Resources.icons8_password_50;
            this.label11.Location = new System.Drawing.Point(51, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 56);
            this.label11.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Image = global::project.Properties.Resources.icons8_phone_number_50;
            this.label10.Location = new System.Drawing.Point(54, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 47);
            this.label10.TabIndex = 21;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(165, 82);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(174, 16);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Cập nhật mật khẩu tài khoản";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(105, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(108, 157);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(297, 22);
            this.txtSTK.TabIndex = 3;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(105, 203);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(89, 16);
            this.lblNewPass.TabIndex = 4;
            this.lblNewPass.Text = "Mật khẩu mới:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(108, 222);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(297, 22);
            this.txtNewPass.TabIndex = 5;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(105, 268);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(117, 16);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Nhập lại mật khẩu:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(108, 287);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(297, 22);
            this.txtConfirm.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(135, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật mật khẩu";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblBack.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblBack.Location = new System.Drawing.Point(175, 382);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(152, 20);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "Quay lại đăng nhập";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click_1);
            // 
            // ForgotPasswordForm
            // 
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(859, 570);
            this.Controls.Add(this.panelMain);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}