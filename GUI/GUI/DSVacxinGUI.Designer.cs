﻿namespace GUI.GUI
{
    partial class DSVacxinGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DSVacxinHT_Datagridview = new System.Windows.Forms.DataGridView();
            this.MaVacxin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVacxin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DSVacxinChon_Datagridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon_SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MoTa_ND_Label = new System.Windows.Forms.Label();
            this.HangSX_ND_Label = new System.Windows.Forms.Label();
            this.MoTa_Label = new System.Windows.Forms.Label();
            this.HangSX_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ThanhTien_Label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinHT_Datagridview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinChon_Datagridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSVacxinHT_Datagridview
            // 
            this.DSVacxinHT_Datagridview.AllowUserToAddRows = false;
            this.DSVacxinHT_Datagridview.AllowUserToDeleteRows = false;
            this.DSVacxinHT_Datagridview.AllowUserToOrderColumns = true;
            this.DSVacxinHT_Datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSVacxinHT_Datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DSVacxinHT_Datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DSVacxinHT_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinHT_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVacxin,
            this.TenVacxin,
            this.NguaBenh,
            this.GiaBan,
            this.ThemBtnCol});
            this.DSVacxinHT_Datagridview.Location = new System.Drawing.Point(0, 40);
            this.DSVacxinHT_Datagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DSVacxinHT_Datagridview.MinimumSize = new System.Drawing.Size(0, 100);
            this.DSVacxinHT_Datagridview.Name = "DSVacxinHT_Datagridview";
            this.DSVacxinHT_Datagridview.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSVacxinHT_Datagridview.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DSVacxinHT_Datagridview.Size = new System.Drawing.Size(444, 247);
            this.DSVacxinHT_Datagridview.TabIndex = 0;
            this.DSVacxinHT_Datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSVacxinHT_Datagridview_CellContentClick);
            // 
            // MaVacxin
            // 
            this.MaVacxin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVacxin.DataPropertyName = "MAVACXIN";
            this.MaVacxin.FillWeight = 80F;
            this.MaVacxin.HeaderText = "Mã vắc xin";
            this.MaVacxin.MinimumWidth = 8;
            this.MaVacxin.Name = "MaVacxin";
            this.MaVacxin.ReadOnly = true;
            this.MaVacxin.Visible = false;
            // 
            // TenVacxin
            // 
            this.TenVacxin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVacxin.DataPropertyName = "TENVACXIN";
            this.TenVacxin.HeaderText = "Tên vắc xin";
            this.TenVacxin.MinimumWidth = 8;
            this.TenVacxin.Name = "TenVacxin";
            this.TenVacxin.ReadOnly = true;
            // 
            // NguaBenh
            // 
            this.NguaBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NguaBenh.DataPropertyName = "NGUABENH";
            this.NguaBenh.FillWeight = 70F;
            this.NguaBenh.HeaderText = "Ngừa bệnh";
            this.NguaBenh.MinimumWidth = 8;
            this.NguaBenh.Name = "NguaBenh";
            this.NguaBenh.ReadOnly = true;
            this.NguaBenh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NguaBenh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GIABAN";
            this.GiaBan.HeaderText = "Giá";
            this.GiaBan.MinimumWidth = 8;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 150;
            // 
            // ThemBtnCol
            // 
            this.ThemBtnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThemBtnCol.FillWeight = 20F;
            this.ThemBtnCol.HeaderText = "";
            this.ThemBtnCol.MinimumWidth = 8;
            this.ThemBtnCol.Name = "ThemBtnCol";
            this.ThemBtnCol.ReadOnly = true;
            this.ThemBtnCol.Text = "+";
            this.ThemBtnCol.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách vắc xin hệ thống";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DSVacxinChon_Datagridview);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DSVacxinHT_Datagridview);
            this.panel1.Location = new System.Drawing.Point(18, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 582);
            this.panel1.TabIndex = 2;
            // 
            // DSVacxinChon_Datagridview
            // 
            this.DSVacxinChon_Datagridview.AllowUserToAddRows = false;
            this.DSVacxinChon_Datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSVacxinChon_Datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DSVacxinChon_Datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DSVacxinChon_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinChon_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1,
            this.Chon_GiaBan,
            this.Chon_SL});
            this.DSVacxinChon_Datagridview.Location = new System.Drawing.Point(0, 332);
            this.DSVacxinChon_Datagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DSVacxinChon_Datagridview.MinimumSize = new System.Drawing.Size(0, 100);
            this.DSVacxinChon_Datagridview.Name = "DSVacxinChon_Datagridview";
            this.DSVacxinChon_Datagridview.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSVacxinChon_Datagridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DSVacxinChon_Datagridview.Size = new System.Drawing.Size(444, 247);
            this.DSVacxinChon_Datagridview.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAVACXIN";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã vắc xin";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENVACXIN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên vắc xin";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.DataPropertyName = "NGUABENH";
            this.dataGridViewButtonColumn1.FillWeight = 80F;
            this.dataGridViewButtonColumn1.HeaderText = "Ngừa bệnh";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Chon_GiaBan
            // 
            this.Chon_GiaBan.FillWeight = 80F;
            this.Chon_GiaBan.HeaderText = "Giá";
            this.Chon_GiaBan.MinimumWidth = 8;
            this.Chon_GiaBan.Name = "Chon_GiaBan";
            this.Chon_GiaBan.ReadOnly = true;
            this.Chon_GiaBan.Width = 150;
            // 
            // Chon_SL
            // 
            this.Chon_SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.NullValue = "1";
            this.Chon_SL.DefaultCellStyle = dataGridViewCellStyle4;
            this.Chon_SL.FillWeight = 40F;
            this.Chon_SL.HeaderText = "SL";
            this.Chon_SL.MinimumWidth = 8;
            this.Chon_SL.Name = "Chon_SL";
            this.Chon_SL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon_SL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách vắc xin đã chọn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.MoTa_ND_Label);
            this.panel2.Controls.Add(this.HangSX_ND_Label);
            this.panel2.Controls.Add(this.MoTa_Label);
            this.panel2.Controls.Add(this.HangSX_Label);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(470, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 465);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 404);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // MoTa_ND_Label
            // 
            this.MoTa_ND_Label.Location = new System.Drawing.Point(83, 135);
            this.MoTa_ND_Label.Name = "MoTa_ND_Label";
            this.MoTa_ND_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MoTa_ND_Label.Size = new System.Drawing.Size(265, 320);
            this.MoTa_ND_Label.TabIndex = 4;
            this.MoTa_ND_Label.Text = "label6";
            this.MoTa_ND_Label.Visible = false;
            // 
            // HangSX_ND_Label
            // 
            this.HangSX_ND_Label.Location = new System.Drawing.Point(83, 40);
            this.HangSX_ND_Label.Name = "HangSX_ND_Label";
            this.HangSX_ND_Label.Size = new System.Drawing.Size(265, 84);
            this.HangSX_ND_Label.TabIndex = 3;
            this.HangSX_ND_Label.Text = "label6";
            this.HangSX_ND_Label.Visible = false;
            // 
            // MoTa_Label
            // 
            this.MoTa_Label.AutoSize = true;
            this.MoTa_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa_Label.Location = new System.Drawing.Point(6, 135);
            this.MoTa_Label.Name = "MoTa_Label";
            this.MoTa_Label.Size = new System.Drawing.Size(109, 45);
            this.MoTa_Label.TabIndex = 2;
            this.MoTa_Label.Text = "Mô tả";
            this.MoTa_Label.Visible = false;
            // 
            // HangSX_Label
            // 
            this.HangSX_Label.AutoSize = true;
            this.HangSX_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangSX_Label.Location = new System.Drawing.Point(4, 40);
            this.HangSX_Label.Name = "HangSX_Label";
            this.HangSX_Label.Size = new System.Drawing.Size(158, 45);
            this.HangSX_Label.TabIndex = 1;
            this.HangSX_Label.Text = "Hãng SX:";
            this.HangSX_Label.Visible = false;
            this.HangSX_Label.Click += new System.EventHandler(this.HangSX_Label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin chi tiết vắc xin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành tiền:";
            // 
            // ThanhTien_Label
            // 
            this.ThanhTien_Label.AutoSize = true;
            this.ThanhTien_Label.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien_Label.ForeColor = System.Drawing.Color.Maroon;
            this.ThanhTien_Label.Location = new System.Drawing.Point(568, 485);
            this.ThanhTien_Label.Name = "ThanhTien_Label";
            this.ThanhTien_Label.Size = new System.Drawing.Size(239, 93);
            this.ThanhTien_Label.TabIndex = 6;
            this.ThanhTien_Label.Text = "label5";
            this.ThanhTien_Label.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(469, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tôi muốn đặt vắc xin ngoài";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DSVacxinGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ThanhTien_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DSVacxinGUI";
            this.Text = "Đăng ký tiêm chủng";
            this.Load += new System.EventHandler(this.DSVacxinGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinHT_Datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinChon_Datagridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DSVacxinHT_Datagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DSVacxinChon_Datagridview;
        private System.Windows.Forms.Label MoTa_ND_Label;
        private System.Windows.Forms.Label HangSX_ND_Label;
        private System.Windows.Forms.Label MoTa_Label;
        private System.Windows.Forms.Label HangSX_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVacxin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVacxin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewButtonColumn ThemBtnCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ThanhTien_Label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chon_GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chon_SL;
    }
}