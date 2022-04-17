
namespace GUI.GUI
{
    partial class DatMuaVacxin
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
            this.DSVacXinHT = new System.Windows.Forms.DataGridView();
            this.DSVacxinDaChon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MAVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUABENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSoLuong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngua_Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacXinHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinDaChon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(129, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VẮC XIN HỆ THỐNG";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH VẮC XIN ĐÃ CHỌN";
            // 
            // DSVacXinHT
            // 
            this.DSVacXinHT.AllowUserToAddRows = false;
            this.DSVacXinHT.AllowUserToDeleteRows = false;
            this.DSVacXinHT.AllowUserToOrderColumns = true;
            this.DSVacXinHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacXinHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVACXIN,
            this.TENVACXIN,
            this.NGUABENH,
            this.GIABAN,
            this.btnSoLuong});
            this.DSVacXinHT.Location = new System.Drawing.Point(21, 55);
            this.DSVacXinHT.Name = "DSVacXinHT";
            this.DSVacXinHT.RowHeadersWidth = 62;
            this.DSVacXinHT.RowTemplate.Height = 28;
            this.DSVacXinHT.Size = new System.Drawing.Size(551, 197);
            this.DSVacXinHT.TabIndex = 2;
            this.DSVacXinHT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DSVacxinDaChon
            // 
            this.DSVacxinDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVX,
            this.TenVX,
            this.Ngua_Benh,
            this.Gia,
            this.soluong});
            this.DSVacxinDaChon.Location = new System.Drawing.Point(21, 307);
            this.DSVacxinDaChon.Name = "DSVacxinDaChon";
            this.DSVacxinDaChon.RowHeadersWidth = 62;
            this.DSVacxinDaChon.RowTemplate.Height = 28;
            this.DSVacxinDaChon.Size = new System.Drawing.Size(551, 213);
            this.DSVacxinDaChon.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(614, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 416);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DSVacxinDaChon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DSVacXinHT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 523);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin chi tiết Vắc xin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hãng SX:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mô tả: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(99, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 84);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(69, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 256);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(614, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "THÀNH TIỀN :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đặt vắc xin khác";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(770, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Đặt mua";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(761, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 53);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MAVACXIN
            // 
            this.MAVACXIN.DataPropertyName = "MAVACXIN";
            this.MAVACXIN.HeaderText = "Mã vắc xin";
            this.MAVACXIN.MinimumWidth = 8;
            this.MAVACXIN.Name = "MAVACXIN";
            this.MAVACXIN.Visible = false;
            this.MAVACXIN.Width = 150;
            // 
            // TENVACXIN
            // 
            this.TENVACXIN.DataPropertyName = "TENVACXIN";
            this.TENVACXIN.HeaderText = "Tên vắc xin";
            this.TENVACXIN.MinimumWidth = 8;
            this.TENVACXIN.Name = "TENVACXIN";
            this.TENVACXIN.Width = 150;
            // 
            // NGUABENH
            // 
            this.NGUABENH.DataPropertyName = "NGUABENH";
            this.NGUABENH.HeaderText = "Ngừa bệnh";
            this.NGUABENH.MinimumWidth = 8;
            this.NGUABENH.Name = "NGUABENH";
            this.NGUABENH.Width = 150;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.MinimumWidth = 8;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 150;
            // 
            // btnSoLuong
            // 
            this.btnSoLuong.HeaderText = "";
            this.btnSoLuong.MinimumWidth = 8;
            this.btnSoLuong.Name = "btnSoLuong";
            this.btnSoLuong.Text = "+";
            this.btnSoLuong.Width = 150;
            // 
            // MaVX
            // 
            this.MaVX.DataPropertyName = "MAVACXIN";
            this.MaVX.HeaderText = "Mã vắc xin";
            this.MaVX.MinimumWidth = 8;
            this.MaVX.Name = "MaVX";
            this.MaVX.Visible = false;
            this.MaVX.Width = 150;
            // 
            // TenVX
            // 
            this.TenVX.DataPropertyName = "TENVACXIN";
            this.TenVX.HeaderText = "Tên vắc xin";
            this.TenVX.MinimumWidth = 8;
            this.TenVX.Name = "TenVX";
            this.TenVX.Width = 150;
            // 
            // Ngua_Benh
            // 
            this.Ngua_Benh.DataPropertyName = "NGUABENH";
            this.Ngua_Benh.HeaderText = "Ngừa bệnh";
            this.Ngua_Benh.MinimumWidth = 8;
            this.Ngua_Benh.Name = "Ngua_Benh";
            this.Ngua_Benh.Width = 150;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GIABAN";
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 150;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            this.soluong.Width = 150;
            // 
            // DatMuaVacxin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 547);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DatMuaVacxin";
            this.Text = "DatMuaVacxin";
            this.Load += new System.EventHandler(this.DatMuaVacxin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSVacXinHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinDaChon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DSVacXinHT;
        private System.Windows.Forms.DataGridView DSVacxinDaChon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVACXIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVACXIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUABENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewButtonColumn btnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngua_Benh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}