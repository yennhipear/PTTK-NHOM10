
namespace GUI.GUI
{
    partial class XepLichLamViecGUI
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
            this.huyXllvBtn = new System.Windows.Forms.Button();
            this.xllvDoneBtn = new System.Windows.Forms.Button();
            this.xllvDGV = new System.Windows.Forms.DataGridView();
            this.xllvEmp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xllvSche = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xllvDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // huyXllvBtn
            // 
            this.huyXllvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.huyXllvBtn.Location = new System.Drawing.Point(330, 279);
            this.huyXllvBtn.Name = "huyXllvBtn";
            this.huyXllvBtn.Size = new System.Drawing.Size(86, 47);
            this.huyXllvBtn.TabIndex = 5;
            this.huyXllvBtn.Text = "Hủy";
            this.huyXllvBtn.UseVisualStyleBackColor = true;
            // 
            // xllvDoneBtn
            // 
            this.xllvDoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xllvDoneBtn.Location = new System.Drawing.Point(204, 279);
            this.xllvDoneBtn.Name = "xllvDoneBtn";
            this.xllvDoneBtn.Size = new System.Drawing.Size(111, 47);
            this.xllvDoneBtn.TabIndex = 4;
            this.xllvDoneBtn.Text = "Hoàn thành";
            this.xllvDoneBtn.UseVisualStyleBackColor = true;
            // 
            // xllvDGV
            // 
            this.xllvDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xllvDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xllvDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xllvEmp,
            this.xllvSche});
            this.xllvDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.xllvDGV.Location = new System.Drawing.Point(12, 12);
            this.xllvDGV.Name = "xllvDGV";
            this.xllvDGV.RowHeadersWidth = 51;
            this.xllvDGV.RowTemplate.Height = 24;
            this.xllvDGV.Size = new System.Drawing.Size(404, 248);
            this.xllvDGV.TabIndex = 3;
            // 
            // xllvEmp
            // 
            this.xllvEmp.HeaderText = "Nhân viên";
            this.xllvEmp.Items.AddRange(new object[] {
            "Đỗ Văn Anh",
            "Trần Văn Bảo",
            "Nguyễn Thị Chi",
            "Đào Cao Trúc",
            "Lê Tấn Hoàng"});
            this.xllvEmp.MinimumWidth = 6;
            this.xllvEmp.Name = "xllvEmp";
            this.xllvEmp.Width = 125;
            // 
            // xllvSche
            // 
            this.xllvSche.HeaderText = "Lịch";
            this.xllvSche.Items.AddRange(new object[] {
            "Thứ hai - Sáng",
            "Thứ ba - Chiều",
            "Thứ tư - Tối",
            "Thứ năm - Sáng",
            "Thứ sáu - Chiều",
            "Thứ bảy - Tối"});
            this.xllvSche.MinimumWidth = 6;
            this.xllvSche.Name = "xllvSche";
            this.xllvSche.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xllvSche.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xllvSche.Width = 125;
            // 
            // XepLichLamViecGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.huyXllvBtn);
            this.Controls.Add(this.xllvDoneBtn);
            this.Controls.Add(this.xllvDGV);
            this.Name = "XepLichLamViecGUI";
            this.Text = "Xếp lịch làm việc";
            ((System.ComponentModel.ISupportInitialize)(this.xllvDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button huyXllvBtn;
        private System.Windows.Forms.Button xllvDoneBtn;
        private System.Windows.Forms.DataGridView xllvDGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn xllvEmp;
        private System.Windows.Forms.DataGridViewComboBoxColumn xllvSche;
    }
}