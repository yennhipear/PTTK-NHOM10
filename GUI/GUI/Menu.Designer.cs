﻿namespace GUI
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDatMuaVacxin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng ký tiêm chủng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đăng ký lịch rảnh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDatMuaVacxin
            // 
            this.btnDatMuaVacxin.Location = new System.Drawing.Point(27, 159);
            this.btnDatMuaVacxin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDatMuaVacxin.Name = "btnDatMuaVacxin";
            this.btnDatMuaVacxin.Size = new System.Drawing.Size(213, 84);
            this.btnDatMuaVacxin.TabIndex = 1;
            this.btnDatMuaVacxin.Text = "Đặt mua vắc-xin";
            this.btnDatMuaVacxin.UseVisualStyleBackColor = true;
            this.btnDatMuaVacxin.Click += new System.EventHandler(this.btnDatMuaVacxin_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 159);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xếp lịch làm việc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 269);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDatMuaVacxin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDatMuaVacxin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

