
namespace GUI.GUI
{
    partial class DatMuaVacxinGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DSVacXinHT_DataGridView = new System.Windows.Forms.DataGridView();
            this.DSVacxinDaChon_DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoTa_ND_Label = new System.Windows.Forms.Label();
            this.HangSX_ND_Label = new System.Windows.Forms.Label();
            this.MoTa_Label = new System.Windows.Forms.Label();
            this.HangSX_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MAVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUABENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSoLuong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GiamSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngua_Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaVacXin = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacXinHT_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinDaChon_DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(148, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VẮC XIN HỆ THỐNG";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH VẮC XIN ĐÃ CHỌN";
            // 
            // DSVacXinHT_DataGridView
            // 
            this.DSVacXinHT_DataGridView.AllowUserToAddRows = false;
            this.DSVacXinHT_DataGridView.AllowUserToDeleteRows = false;
            this.DSVacXinHT_DataGridView.AllowUserToOrderColumns = true;
            this.DSVacXinHT_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DSVacXinHT_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DSVacXinHT_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacXinHT_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVACXIN,
            this.TENVACXIN,
            this.NGUABENH,
            this.GIABAN,
            this.btnSoLuong,
            this.GiamSL});
            this.DSVacXinHT_DataGridView.Location = new System.Drawing.Point(21, 55);
            this.DSVacXinHT_DataGridView.Name = "DSVacXinHT_DataGridView";
            this.DSVacXinHT_DataGridView.ReadOnly = true;
            this.DSVacXinHT_DataGridView.RowHeadersWidth = 62;
            this.DSVacXinHT_DataGridView.RowTemplate.Height = 28;
            this.DSVacXinHT_DataGridView.Size = new System.Drawing.Size(682, 203);
            this.DSVacXinHT_DataGridView.TabIndex = 2;
            // 
            // DSVacxinDaChon_DataGridView
            // 
            this.DSVacxinDaChon_DataGridView.AllowUserToAddRows = false;
            this.DSVacxinDaChon_DataGridView.AllowUserToDeleteRows = false;
            this.DSVacxinDaChon_DataGridView.AllowUserToOrderColumns = true;
            this.DSVacxinDaChon_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DSVacxinDaChon_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DSVacxinDaChon_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinDaChon_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVX,
            this.TenVX,
            this.Ngua_Benh,
            this.Gia,
            this.soluong,
            this.XoaVacXin});
            this.DSVacxinDaChon_DataGridView.Location = new System.Drawing.Point(21, 332);
            this.DSVacxinDaChon_DataGridView.Name = "DSVacxinDaChon_DataGridView";
            this.DSVacxinDaChon_DataGridView.RowHeadersWidth = 62;
            this.DSVacxinDaChon_DataGridView.RowTemplate.Height = 28;
            this.DSVacxinDaChon_DataGridView.Size = new System.Drawing.Size(682, 210);
            this.DSVacxinDaChon_DataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MoTa_ND_Label);
            this.panel1.Controls.Add(this.HangSX_ND_Label);
            this.panel1.Controls.Add(this.MoTa_Label);
            this.panel1.Controls.Add(this.HangSX_Label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(739, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 441);
            this.panel1.TabIndex = 4;
            // 
            // MoTa_ND_Label
            // 
            this.MoTa_ND_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa_ND_Label.Location = new System.Drawing.Point(79, 161);
            this.MoTa_ND_Label.Name = "MoTa_ND_Label";
            this.MoTa_ND_Label.Size = new System.Drawing.Size(263, 255);
            this.MoTa_ND_Label.TabIndex = 5;
            this.MoTa_ND_Label.Text = "label8";
            // 
            // HangSX_ND_Label
            // 
            this.HangSX_ND_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangSX_ND_Label.Location = new System.Drawing.Point(99, 66);
            this.HangSX_ND_Label.Name = "HangSX_ND_Label";
            this.HangSX_ND_Label.Size = new System.Drawing.Size(233, 84);
            this.HangSX_ND_Label.TabIndex = 4;
            this.HangSX_ND_Label.Text = "label7";
            // 
            // MoTa_Label
            // 
            this.MoTa_Label.AutoSize = true;
            this.MoTa_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa_Label.Location = new System.Drawing.Point(4, 148);
            this.MoTa_Label.Name = "MoTa_Label";
            this.MoTa_Label.Size = new System.Drawing.Size(79, 28);
            this.MoTa_Label.TabIndex = 3;
            this.MoTa_Label.Text = "Mô tả: ";
            // 
            // HangSX_Label
            // 
            this.HangSX_Label.AutoSize = true;
            this.HangSX_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangSX_Label.Location = new System.Drawing.Point(4, 55);
            this.HangSX_Label.Name = "HangSX_Label";
            this.HangSX_Label.Size = new System.Drawing.Size(97, 28);
            this.HangSX_Label.TabIndex = 2;
            this.HangSX_Label.Text = "Hãng SX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin chi tiết Vắc xin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DSVacxinDaChon_DataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DSVacXinHT_DataGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 545);
            this.panel2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(743, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "THÀNH TIỀN :";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đặt vắc xin khác";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(922, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Đặt mua";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(895, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 53);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MAVACXIN
            // 
            this.MAVACXIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAVACXIN.DataPropertyName = "MAVACXIN";
            this.MAVACXIN.HeaderText = "Mã vắc xin";
            this.MAVACXIN.MinimumWidth = 8;
            this.MAVACXIN.Name = "MAVACXIN";
            this.MAVACXIN.ReadOnly = true;
            this.MAVACXIN.Visible = false;
            // 
            // TENVACXIN
            // 
            this.TENVACXIN.DataPropertyName = "TENVACXIN";
            this.TENVACXIN.HeaderText = "Tên vắc xin";
            this.TENVACXIN.MinimumWidth = 8;
            this.TENVACXIN.Name = "TENVACXIN";
            this.TENVACXIN.ReadOnly = true;
            // 
            // NGUABENH
            // 
            this.NGUABENH.DataPropertyName = "NGUABENH";
            this.NGUABENH.HeaderText = "Ngừa bệnh";
            this.NGUABENH.MinimumWidth = 8;
            this.NGUABENH.Name = "NGUABENH";
            this.NGUABENH.ReadOnly = true;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.MinimumWidth = 8;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // btnSoLuong
            // 
            this.btnSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnSoLuong.FillWeight = 50F;
            this.btnSoLuong.HeaderText = "+";
            this.btnSoLuong.MinimumWidth = 8;
            this.btnSoLuong.Name = "btnSoLuong";
            this.btnSoLuong.ReadOnly = true;
            this.btnSoLuong.Text = "+";
            this.btnSoLuong.UseColumnTextForButtonValue = true;
            // 
            // GiamSL
            // 
            this.GiamSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiamSL.FillWeight = 50F;
            this.GiamSL.HeaderText = "-";
            this.GiamSL.MinimumWidth = 8;
            this.GiamSL.Name = "GiamSL";
            this.GiamSL.ReadOnly = true;
            this.GiamSL.Text = "-";
            this.GiamSL.UseColumnTextForButtonValue = true;
            // 
            // MaVX
            // 
            this.MaVX.DataPropertyName = "MAVACXIN";
            this.MaVX.HeaderText = "Mã vắc xin";
            this.MaVX.MinimumWidth = 8;
            this.MaVX.Name = "MaVX";
            this.MaVX.Visible = false;
            // 
            // TenVX
            // 
            this.TenVX.DataPropertyName = "TENVACXIN";
            this.TenVX.HeaderText = "Tên vắc xin";
            this.TenVX.MinimumWidth = 8;
            this.TenVX.Name = "TenVX";
            this.TenVX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ngua_Benh
            // 
            this.Ngua_Benh.DataPropertyName = "NGUABENH";
            this.Ngua_Benh.HeaderText = "Ngừa bệnh";
            this.Ngua_Benh.MinimumWidth = 8;
            this.Ngua_Benh.Name = "Ngua_Benh";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GIABAN";
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            // 
            // XoaVacXin
            // 
            this.XoaVacXin.FillWeight = 50F;
            this.XoaVacXin.HeaderText = "Xóa";
            this.XoaVacXin.MinimumWidth = 8;
            this.XoaVacXin.Name = "XoaVacXin";
            this.XoaVacXin.Text = "X";
            this.XoaVacXin.UseColumnTextForButtonValue = true;
            // 
            // DatMuaVacxinGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 574);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DatMuaVacxinGUI";
            this.Text = "DatMuaVacxin";
            ((System.ComponentModel.ISupportInitialize)(this.DSVacXinHT_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinDaChon_DataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView DSVacXinHT_DataGridView;
        private System.Windows.Forms.DataGridView DSVacxinDaChon_DataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HangSX_ND_Label;
        private System.Windows.Forms.Label MoTa_Label;
        private System.Windows.Forms.Label HangSX_Label;
        private System.Windows.Forms.Label MoTa_ND_Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVACXIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVACXIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUABENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewButtonColumn btnSoLuong;
        private System.Windows.Forms.DataGridViewButtonColumn GiamSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngua_Benh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewButtonColumn XoaVacXin;
    }
}