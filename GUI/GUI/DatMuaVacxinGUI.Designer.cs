
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DSVacXinHT_DataGridView = new System.Windows.Forms.DataGridView();
            this.MAVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUABENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSoLuong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GiamSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DSVacxinDaChon_DataGridView = new System.Windows.Forms.DataGridView();
            this.MaVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngua_Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaVacXin = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoTa_ND_Label = new System.Windows.Forms.Label();
            this.HangSX_ND_Label = new System.Windows.Forms.Label();
            this.MoTa_Label = new System.Windows.Forms.Label();
            this.HangSX_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoiVacxinHT_Datagridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goi_SLTiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ThanhTien_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacXinHT_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinDaChon_DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoiVacxinHT_Datagridview)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH GÓI VẮC XIN HỆ THỐNG";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN CHI TIẾT GÓI VẮC XIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DSVacXinHT_DataGridView
            // 
            this.DSVacXinHT_DataGridView.AllowUserToAddRows = false;
            this.DSVacXinHT_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DSVacXinHT_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DSVacXinHT_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DSVacXinHT_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacXinHT_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVACXIN,
            this.TENVACXIN,
            this.NGUABENH,
            this.GIABAN,
            this.btnSoLuong,
            this.GiamSL});
            this.DSVacXinHT_DataGridView.Location = new System.Drawing.Point(1, 391);
            this.DSVacXinHT_DataGridView.Name = "DSVacXinHT_DataGridView";
            this.DSVacXinHT_DataGridView.RowHeadersVisible = false;
            this.DSVacXinHT_DataGridView.RowHeadersWidth = 62;
            this.DSVacXinHT_DataGridView.RowTemplate.Height = 28;
            this.DSVacXinHT_DataGridView.Size = new System.Drawing.Size(553, 251);
            this.DSVacXinHT_DataGridView.TabIndex = 5;
            // 
            // MAVACXIN
            // 
            this.MAVACXIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAVACXIN.DataPropertyName = "MAVACXIN";
            this.MAVACXIN.HeaderText = "Mã vắc xin";
            this.MAVACXIN.MinimumWidth = 8;
            this.MAVACXIN.Name = "MAVACXIN";
            this.MAVACXIN.Visible = false;
            // 
            // TENVACXIN
            // 
            this.TENVACXIN.DataPropertyName = "TENVACXIN";
            this.TENVACXIN.HeaderText = "Tên vắc xin";
            this.TENVACXIN.MinimumWidth = 8;
            this.TENVACXIN.Name = "TENVACXIN";
            // 
            // NGUABENH
            // 
            this.NGUABENH.DataPropertyName = "NGUABENH";
            this.NGUABENH.HeaderText = "Ngừa bệnh";
            this.NGUABENH.MinimumWidth = 8;
            this.NGUABENH.Name = "NGUABENH";
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.MinimumWidth = 8;
            this.GIABAN.Name = "GIABAN";
            // 
            // btnSoLuong
            // 
            this.btnSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnSoLuong.FillWeight = 50F;
            this.btnSoLuong.HeaderText = "+";
            this.btnSoLuong.MinimumWidth = 8;
            this.btnSoLuong.Name = "btnSoLuong";
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
            this.GiamSL.Text = "-";
            this.GiamSL.UseColumnTextForButtonValue = true;
            // 
            // DSVacxinDaChon_DataGridView
            // 
            this.DSVacxinDaChon_DataGridView.AllowUserToAddRows = false;
            this.DSVacxinDaChon_DataGridView.AllowUserToDeleteRows = false;
            this.DSVacxinDaChon_DataGridView.AllowUserToOrderColumns = true;
            this.DSVacxinDaChon_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DSVacxinDaChon_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DSVacxinDaChon_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSVacxinDaChon_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVX,
            this.TenVX,
            this.Ngua_Benh,
            this.Gia,
            this.soluong,
            this.XoaVacXin});
            this.DSVacxinDaChon_DataGridView.Location = new System.Drawing.Point(9, 76);
            this.DSVacxinDaChon_DataGridView.Name = "DSVacxinDaChon_DataGridView";
            this.DSVacxinDaChon_DataGridView.RowHeadersVisible = false;
            this.DSVacxinDaChon_DataGridView.RowHeadersWidth = 62;
            this.DSVacxinDaChon_DataGridView.RowTemplate.Height = 28;
            this.DSVacxinDaChon_DataGridView.Size = new System.Drawing.Size(545, 251);
            this.DSVacxinDaChon_DataGridView.TabIndex = 3;
            this.DSVacxinDaChon_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSVacxinDaChon_DataGridView_CellContentClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.MoTa_ND_Label);
            this.panel1.Controls.Add(this.HangSX_ND_Label);
            this.panel1.Controls.Add(this.MoTa_Label);
            this.panel1.Controls.Add(this.HangSX_Label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 302);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MoTa_ND_Label
            // 
            this.MoTa_ND_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa_ND_Label.Location = new System.Drawing.Point(89, 152);
            this.MoTa_ND_Label.Name = "MoTa_ND_Label";
            this.MoTa_ND_Label.Size = new System.Drawing.Size(460, 133);
            this.MoTa_ND_Label.TabIndex = 5;
            this.MoTa_ND_Label.Text = "label8";
            this.MoTa_ND_Label.Visible = false;
            // 
            // HangSX_ND_Label
            // 
            this.HangSX_ND_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangSX_ND_Label.Location = new System.Drawing.Point(111, 55);
            this.HangSX_ND_Label.Name = "HangSX_ND_Label";
            this.HangSX_ND_Label.Size = new System.Drawing.Size(438, 84);
            this.HangSX_ND_Label.TabIndex = 4;
            this.HangSX_ND_Label.Text = "label7";
            this.HangSX_ND_Label.Visible = false;
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
            this.MoTa_Label.Visible = false;
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
            this.HangSX_Label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin chi tiết Vắc xin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.panel2.Controls.Add(this.GoiVacxinHT_Datagridview);
            this.panel2.Controls.Add(this.DSVacXinHT_DataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 642);
            this.panel2.TabIndex = 5;
            // 
            // GoiVacxinHT_Datagridview
            // 
            this.GoiVacxinHT_Datagridview.AllowUserToAddRows = false;
            this.GoiVacxinHT_Datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoiVacxinHT_Datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.GoiVacxinHT_Datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GoiVacxinHT_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GoiVacxinHT_Datagridview.ColumnHeadersHeight = 27;
            this.GoiVacxinHT_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GoiVacxinHT_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Goi_SLTiem});
            this.GoiVacxinHT_Datagridview.Location = new System.Drawing.Point(1, 76);
            this.GoiVacxinHT_Datagridview.MinimumSize = new System.Drawing.Size(0, 100);
            this.GoiVacxinHT_Datagridview.Name = "GoiVacxinHT_Datagridview";
            this.GoiVacxinHT_Datagridview.RowHeadersVisible = false;
            this.GoiVacxinHT_Datagridview.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoiVacxinHT_Datagridview.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GoiVacxinHT_Datagridview.Size = new System.Drawing.Size(550, 251);
            this.GoiVacxinHT_Datagridview.TabIndex = 2;
            this.GoiVacxinHT_Datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoiVacxinHT_Datagridview_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAGOIVACXIN";
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã gói vắc xin";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENGOIVACXIN";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên gói vắc xin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GIABAN";
            this.dataGridViewTextBoxColumn6.FillWeight = 80F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Goi_SLTiem
            // 
            this.Goi_SLTiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Goi_SLTiem.DataPropertyName = "SLTiem";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goi_SLTiem.DefaultCellStyle = dataGridViewCellStyle9;
            this.Goi_SLTiem.FillWeight = 63.9758F;
            this.Goi_SLTiem.HeaderText = "Số lần tiêm";
            this.Goi_SLTiem.MinimumWidth = 8;
            this.Goi_SLTiem.Name = "Goi_SLTiem";
            this.Goi_SLTiem.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(5, 676);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "THÀNH TIỀN :";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(714, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 57);
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
            this.button2.Location = new System.Drawing.Point(930, 654);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Đặt mua";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThanhTien_Label
            // 
            this.ThanhTien_Label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien_Label.ForeColor = System.Drawing.Color.Red;
            this.ThanhTien_Label.Location = new System.Drawing.Point(157, 657);
            this.ThanhTien_Label.Name = "ThanhTien_Label";
            this.ThanhTien_Label.Size = new System.Drawing.Size(188, 53);
            this.ThanhTien_Label.TabIndex = 9;
            this.ThanhTien_Label.Text = "label10";
            this.ThanhTien_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.DSVacxinDaChon_DataGridView);
            this.panel3.Location = new System.Drawing.Point(572, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 636);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "DANH SÁCH VẮC XIN ĐÃ CHỌN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DatMuaVacxinGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 722);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ThanhTien_Label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Name = "DatMuaVacxinGUI";
            this.Text = "DatMuaVacxin";
            this.Load += new System.EventHandler(this.DatMuaVacxinGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSVacXinHT_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSVacxinDaChon_DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoiVacxinHT_Datagridview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DSVacXinHT_DataGridView;
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
        private System.Windows.Forms.Label ThanhTien_Label;
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
        private System.Windows.Forms.DataGridView GoiVacxinHT_Datagridview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goi_SLTiem;
        public System.Windows.Forms.DataGridView DSVacxinDaChon_DataGridView;
    }
}