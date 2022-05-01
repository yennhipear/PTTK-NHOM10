
namespace GUI.GUI
{
    partial class DatVacXinKhac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenVacxin = new System.Windows.Forms.TextBox();
            this.txtLoaiVacxin = new System.Windows.Forms.TextBox();
            this.txtHangVacxin = new System.Windows.Forms.TextBox();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.TTVacxinKhac_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.TTVacxinKhac_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN VẮC XIN KHÁC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên vắc xin : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại vắc xin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hãng vắc xin : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng :";
            // 
            // txtTenVacxin
            // 
            this.txtTenVacxin.Location = new System.Drawing.Point(162, 81);
            this.txtTenVacxin.Name = "txtTenVacxin";
            this.txtTenVacxin.Size = new System.Drawing.Size(306, 26);
            this.txtTenVacxin.TabIndex = 7;
            // 
            // txtLoaiVacxin
            // 
            this.txtLoaiVacxin.Location = new System.Drawing.Point(162, 126);
            this.txtLoaiVacxin.Name = "txtLoaiVacxin";
            this.txtLoaiVacxin.Size = new System.Drawing.Size(306, 26);
            this.txtLoaiVacxin.TabIndex = 8;
            // 
            // txtHangVacxin
            // 
            this.txtHangVacxin.Location = new System.Drawing.Point(162, 169);
            this.txtHangVacxin.Name = "txtHangVacxin";
            this.txtHangVacxin.Size = new System.Drawing.Size(306, 26);
            this.txtHangVacxin.TabIndex = 9;
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(162, 217);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(306, 26);
            this.numericSoLuong.TabIndex = 12;
            this.numericSoLuong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(135, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(314, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "Thêm vào danh sách đặt mua";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TTVacxinKhac_Panel
            // 
            this.TTVacxinKhac_Panel.Controls.Add(this.label1);
            this.TTVacxinKhac_Panel.Controls.Add(this.label2);
            this.TTVacxinKhac_Panel.Controls.Add(this.label3);
            this.TTVacxinKhac_Panel.Controls.Add(this.numericSoLuong);
            this.TTVacxinKhac_Panel.Controls.Add(this.label4);
            this.TTVacxinKhac_Panel.Controls.Add(this.txtHangVacxin);
            this.TTVacxinKhac_Panel.Controls.Add(this.label7);
            this.TTVacxinKhac_Panel.Controls.Add(this.txtLoaiVacxin);
            this.TTVacxinKhac_Panel.Controls.Add(this.txtTenVacxin);
            this.TTVacxinKhac_Panel.Location = new System.Drawing.Point(36, 12);
            this.TTVacxinKhac_Panel.Name = "TTVacxinKhac_Panel";
            this.TTVacxinKhac_Panel.Size = new System.Drawing.Size(496, 270);
            this.TTVacxinKhac_Panel.TabIndex = 16;
            // 
            // DatVacXinKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 371);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TTVacxinKhac_Panel);
            this.Name = "DatVacXinKhac";
            this.Text = "DatVacXinKhac";
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.TTVacxinKhac_Panel.ResumeLayout(false);
            this.TTVacxinKhac_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenVacxin;
        private System.Windows.Forms.TextBox txtLoaiVacxin;
        private System.Windows.Forms.TextBox txtHangVacxin;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel TTVacxinKhac_Panel;
    }
}