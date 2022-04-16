
namespace GUI.GUI
{
    partial class DangKyLichRanhGUI
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
            this.dklrDGV = new System.Windows.Forms.DataGridView();
            this.dklrDay = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dklrShift = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dklrBtn = new System.Windows.Forms.Button();
            this.huyDklrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dklrDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dklrDGV
            // 
            this.dklrDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dklrDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dklrDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dklrDay,
            this.dklrShift});
            this.dklrDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dklrDGV.Location = new System.Drawing.Point(12, 12);
            this.dklrDGV.Name = "dklrDGV";
            this.dklrDGV.RowHeadersWidth = 51;
            this.dklrDGV.RowTemplate.Height = 24;
            this.dklrDGV.Size = new System.Drawing.Size(409, 246);
            this.dklrDGV.TabIndex = 0;
            // 
            // dklrDay
            // 
            this.dklrDay.HeaderText = "Ngày";
            this.dklrDay.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy"});
            this.dklrDay.MinimumWidth = 6;
            this.dklrDay.Name = "dklrDay";
            this.dklrDay.Width = 125;
            // 
            // dklrShift
            // 
            this.dklrShift.HeaderText = "Ca";
            this.dklrShift.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.dklrShift.MinimumWidth = 6;
            this.dklrShift.Name = "dklrShift";
            this.dklrShift.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dklrShift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dklrShift.Width = 125;
            // 
            // dklrBtn
            // 
            this.dklrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dklrBtn.Location = new System.Drawing.Point(237, 277);
            this.dklrBtn.Name = "dklrBtn";
            this.dklrBtn.Size = new System.Drawing.Size(94, 34);
            this.dklrBtn.TabIndex = 1;
            this.dklrBtn.Text = "Đăng ký";
            this.dklrBtn.UseVisualStyleBackColor = true;
            this.dklrBtn.Click += new System.EventHandler(this.dklrBtn_Click);
            // 
            // huyDklrBtn
            // 
            this.huyDklrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.huyDklrBtn.Location = new System.Drawing.Point(346, 277);
            this.huyDklrBtn.Name = "huyDklrBtn";
            this.huyDklrBtn.Size = new System.Drawing.Size(75, 34);
            this.huyDklrBtn.TabIndex = 2;
            this.huyDklrBtn.Text = "Hủy";
            this.huyDklrBtn.UseVisualStyleBackColor = true;
            this.huyDklrBtn.Click += new System.EventHandler(this.huyDklrBtn_Click);
            // 
            // DangKyLichRanhGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 323);
            this.Controls.Add(this.huyDklrBtn);
            this.Controls.Add(this.dklrBtn);
            this.Controls.Add(this.dklrDGV);
            this.Name = "DangKyLichRanhGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký lịch rảnh";
            ((System.ComponentModel.ISupportInitialize)(this.dklrDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dklrDGV;
        private System.Windows.Forms.Button dklrBtn;
        private System.Windows.Forms.Button huyDklrBtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dklrDay;
        private System.Windows.Forms.DataGridViewComboBoxColumn dklrShift;
    }
}