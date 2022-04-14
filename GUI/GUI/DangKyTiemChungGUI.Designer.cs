namespace GUI.GUI
{
    partial class DangKyTiemChungGUI
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
            this.DSVacxinHT_Datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DSVacxinChon_Datagridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChiTiet_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaVacxin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVacxin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.DSVacxinHT_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinHT_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVacxin,
            this.TenVacxin,
            this.NguaBenh,
            this.ThemBtnCol});
            this.DSVacxinHT_Datagridview.Location = new System.Drawing.Point(0, 25);
            this.DSVacxinHT_Datagridview.Name = "DSVacxinHT_Datagridview";
            this.DSVacxinHT_Datagridview.Size = new System.Drawing.Size(415, 170);
            this.DSVacxinHT_Datagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách vắc xin hệ thống";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DSVacxinChon_Datagridview);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DSVacxinHT_Datagridview);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 434);
            this.panel1.TabIndex = 2;
            // 
            // DSVacxinChon_Datagridview
            // 
            this.DSVacxinChon_Datagridview.AllowUserToAddRows = false;
            this.DSVacxinChon_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinChon_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.DSVacxinChon_Datagridview.Location = new System.Drawing.Point(0, 233);
            this.DSVacxinChon_Datagridview.Name = "DSVacxinChon_Datagridview";
            this.DSVacxinChon_Datagridview.Size = new System.Drawing.Size(415, 201);
            this.DSVacxinChon_Datagridview.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách vắc xin đã chọn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ChiTiet_Textbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(434, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 434);
            this.panel2.TabIndex = 3;
            // 
            // ChiTiet_Textbox
            // 
            this.ChiTiet_Textbox.Location = new System.Drawing.Point(0, 25);
            this.ChiTiet_Textbox.Multiline = true;
            this.ChiTiet_Textbox.Name = "ChiTiet_Textbox";
            this.ChiTiet_Textbox.ReadOnly = true;
            this.ChiTiet_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChiTiet_Textbox.Size = new System.Drawing.Size(354, 409);
            this.ChiTiet_Textbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin chi tiết vắc xin";
            // 
            // MaVacxin
            // 
            this.MaVacxin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVacxin.DataPropertyName = "MAVACXIN";
            this.MaVacxin.FillWeight = 80F;
            this.MaVacxin.HeaderText = "Mã vắc xin";
            this.MaVacxin.Name = "MaVacxin";
            this.MaVacxin.ReadOnly = true;
            this.MaVacxin.Visible = false;
            // 
            // TenVacxin
            // 
            this.TenVacxin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVacxin.DataPropertyName = "TENVACXIN";
            this.TenVacxin.HeaderText = "Tên vắc xin";
            this.TenVacxin.Name = "TenVacxin";
            this.TenVacxin.ReadOnly = true;
            // 
            // NguaBenh
            // 
            this.NguaBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NguaBenh.DataPropertyName = "NGUABENH";
            this.NguaBenh.FillWeight = 70F;
            this.NguaBenh.HeaderText = "Ngừa bệnh";
            this.NguaBenh.Name = "NguaBenh";
            this.NguaBenh.ReadOnly = true;
            this.NguaBenh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NguaBenh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThemBtnCol
            // 
            this.ThemBtnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThemBtnCol.FillWeight = 60F;
            this.ThemBtnCol.HeaderText = "Thêm";
            this.ThemBtnCol.Name = "ThemBtnCol";
            this.ThemBtnCol.ReadOnly = true;
            this.ThemBtnCol.Text = "Thêm";
            this.ThemBtnCol.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã vắc xin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên vắc xin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.FillWeight = 80F;
            this.dataGridViewButtonColumn1.HeaderText = "Ngừa bệnh";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Ngừa bệnh";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn2.FillWeight = 60F;
            this.dataGridViewButtonColumn2.HeaderText = "Thêm";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Thêm";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // DangKyTiemChungGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DangKyTiemChungGUI";
            this.Text = "DangKyTiemChungGUI";
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinHT_Datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinChon_Datagridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DSVacxinHT_Datagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ChiTiet_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DSVacxinChon_Datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVacxin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVacxin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguaBenh;
        private System.Windows.Forms.DataGridViewButtonColumn ThemBtnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}