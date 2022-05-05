namespace GUI
{
    partial class DangKyTaiKhoanGUI
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_confirmpass = new System.Windows.Forms.TextBox();
            this.comfirmpassLabel = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.tb_usename = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bithday = new System.Windows.Forms.DateTimePicker();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signUpBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F);
            this.signUpBtn.Location = new System.Drawing.Point(722, 32);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(6);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(274, 70);
            this.signUpBtn.TabIndex = 1;
            this.signUpBtn.Text = "Đăng Ký";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.signUpBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanel.Location = new System.Drawing.Point(10, 627);
            this.btnPanel.Margin = new System.Windows.Forms.Padding(6);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(1730, 134);
            this.btnPanel.TabIndex = 4;
            this.btnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPanel_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_confirmpass);
            this.panel5.Controls.Add(this.comfirmpassLabel);
            this.panel5.Controls.Add(this.tb_pass);
            this.panel5.Controls.Add(this.passwordLabel);
            this.panel5.Controls.Add(this.tb_usename);
            this.panel5.Controls.Add(this.usernameLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(10, 144);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 483);
            this.panel5.TabIndex = 13;
            // 
            // tb_confirmpass
            // 
            this.tb_confirmpass.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_confirmpass.Location = new System.Drawing.Point(286, 364);
            this.tb_confirmpass.Margin = new System.Windows.Forms.Padding(6);
            this.tb_confirmpass.Name = "tb_confirmpass";
            this.tb_confirmpass.Size = new System.Drawing.Size(280, 46);
            this.tb_confirmpass.TabIndex = 44;
            // 
            // comfirmpassLabel
            // 
            this.comfirmpassLabel.AutoSize = true;
            this.comfirmpassLabel.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.comfirmpassLabel.Location = new System.Drawing.Point(17, 367);
            this.comfirmpassLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.comfirmpassLabel.Name = "comfirmpassLabel";
            this.comfirmpassLabel.Size = new System.Drawing.Size(251, 40);
            this.comfirmpassLabel.TabIndex = 43;
            this.comfirmpassLabel.Text = "Nhập lại mật khẩu";
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_pass.Location = new System.Drawing.Point(286, 214);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(6);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(280, 46);
            this.tb_pass.TabIndex = 42;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.passwordLabel.Location = new System.Drawing.Point(17, 222);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(137, 40);
            this.passwordLabel.TabIndex = 41;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // tb_usename
            // 
            this.tb_usename.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_usename.Location = new System.Drawing.Point(286, 72);
            this.tb_usename.Margin = new System.Windows.Forms.Padding(6);
            this.tb_usename.Name = "tb_usename";
            this.tb_usename.Size = new System.Drawing.Size(280, 46);
            this.tb_usename.TabIndex = 40;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.usernameLabel.Location = new System.Drawing.Point(17, 75);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(205, 40);
            this.usernameLabel.TabIndex = 39;
            this.usernameLabel.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(547, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1730, 134);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bithday);
            this.panel2.Controls.Add(this.tb_name);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1730, 483);
            this.panel2.TabIndex = 7;
            // 
            // bithday
            // 
            this.bithday.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bithday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bithday.Location = new System.Drawing.Point(843, 217);
            this.bithday.MaxDate = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            this.bithday.Name = "bithday";
            this.bithday.Size = new System.Drawing.Size(280, 46);
            this.bithday.TabIndex = 68;
            this.bithday.Value = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_name.Location = new System.Drawing.Point(843, 75);
            this.tb_name.Margin = new System.Windows.Forms.Padding(6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(280, 46);
            this.tb_name.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label12.Location = new System.Drawing.Point(628, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 40);
            this.label12.TabIndex = 69;
            this.label12.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label3.Location = new System.Drawing.Point(628, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 40);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày sinh";
            // 
            // tb_gender
            // 
            this.tb_gender.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_gender.Location = new System.Drawing.Point(843, 361);
            this.tb_gender.Margin = new System.Windows.Forms.Padding(6);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(280, 46);
            this.tb_gender.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label4.Location = new System.Drawing.Point(628, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 40);
            this.label4.TabIndex = 65;
            this.label4.Text = "Giới tính";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_sdt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tb_cmnd);
            this.panel3.Controls.Add(this.tb_diachi);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1147, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 483);
            this.panel3.TabIndex = 64;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_email.Location = new System.Drawing.Point(261, 273);
            this.tb_email.Margin = new System.Windows.Forms.Padding(6);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(280, 46);
            this.tb_email.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label5.Location = new System.Drawing.Point(34, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 40);
            this.label5.TabIndex = 77;
            this.label5.Text = "Email";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_sdt.Location = new System.Drawing.Point(261, 164);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(6);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(280, 46);
            this.tb_sdt.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label11.Location = new System.Drawing.Point(34, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 40);
            this.label11.TabIndex = 73;
            this.label11.Text = "Số Điện Thoại";
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_cmnd.Location = new System.Drawing.Point(261, 55);
            this.tb_cmnd.Margin = new System.Windows.Forms.Padding(6);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(280, 46);
            this.tb_cmnd.TabIndex = 72;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.tb_diachi.Location = new System.Drawing.Point(261, 382);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(6);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(280, 46);
            this.tb_diachi.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label10.Location = new System.Drawing.Point(34, 386);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 40);
            this.label10.TabIndex = 75;
            this.label10.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 40);
            this.label2.TabIndex = 71;
            this.label2.Text = "CMND/CCCD";
            // 
            // DangKyTaiKhoanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 771);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1776, 842);
            this.MinimumSize = new System.Drawing.Size(1776, 842);
            this.Name = "DangKyTaiKhoanGUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DangKyTaiKhoanGUI_Load);
            this.btnPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_confirmpass;
        private System.Windows.Forms.Label comfirmpassLabel;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox tb_usename;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bithday;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_gender;
        private System.Windows.Forms.Label label4;
    }
}