
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
            this.dklrBtn = new System.Windows.Forms.Button();
            this.huyDklrBtn = new System.Windows.Forms.Button();
            this.weekValLbl = new System.Windows.Forms.Label();
            this.weekLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dklrDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dklrDGV
            // 
            this.dklrDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dklrDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dklrDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dklrDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dklrDGV.Location = new System.Drawing.Point(12, 73);
            this.dklrDGV.Name = "dklrDGV";
            this.dklrDGV.RowHeadersWidth = 51;
            this.dklrDGV.RowTemplate.Height = 24;
            this.dklrDGV.Size = new System.Drawing.Size(482, 345);
            this.dklrDGV.TabIndex = 0;
            // 
            // dklrBtn
            // 
            this.dklrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dklrBtn.Location = new System.Drawing.Point(310, 433);
            this.dklrBtn.Name = "dklrBtn";
            this.dklrBtn.Size = new System.Drawing.Size(94, 38);
            this.dklrBtn.TabIndex = 1;
            this.dklrBtn.Text = "Đăng ký";
            this.dklrBtn.UseVisualStyleBackColor = true;
            this.dklrBtn.Click += new System.EventHandler(this.dklrBtn_Click);
            // 
            // huyDklrBtn
            // 
            this.huyDklrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.huyDklrBtn.Location = new System.Drawing.Point(419, 433);
            this.huyDklrBtn.Name = "huyDklrBtn";
            this.huyDklrBtn.Size = new System.Drawing.Size(75, 38);
            this.huyDklrBtn.TabIndex = 2;
            this.huyDklrBtn.Text = "Hủy";
            this.huyDklrBtn.UseVisualStyleBackColor = true;
            this.huyDklrBtn.Click += new System.EventHandler(this.huyDklrBtn_Click);
            // 
            // weekValLbl
            // 
            this.weekValLbl.AutoSize = true;
            this.weekValLbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekValLbl.ForeColor = System.Drawing.Color.Maroon;
            this.weekValLbl.Location = new System.Drawing.Point(82, 5);
            this.weekValLbl.Name = "weekValLbl";
            this.weekValLbl.Size = new System.Drawing.Size(50, 60);
            this.weekValLbl.TabIndex = 15;
            this.weekValLbl.Text = "1";
            // 
            // weekLbl
            // 
            this.weekLbl.AutoSize = true;
            this.weekLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLbl.Location = new System.Drawing.Point(13, 30);
            this.weekLbl.Name = "weekLbl";
            this.weekLbl.Size = new System.Drawing.Size(63, 28);
            this.weekLbl.TabIndex = 14;
            this.weekLbl.Text = "Tuần:";
            // 
            // DangKyLichRanhGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 483);
            this.Controls.Add(this.weekValLbl);
            this.Controls.Add(this.weekLbl);
            this.Controls.Add(this.huyDklrBtn);
            this.Controls.Add(this.dklrBtn);
            this.Controls.Add(this.dklrDGV);
            this.Name = "DangKyLichRanhGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký lịch rảnh";
            ((System.ComponentModel.ISupportInitialize)(this.dklrDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dklrDGV;
        private System.Windows.Forms.Button dklrBtn;
        private System.Windows.Forms.Button huyDklrBtn;
        private System.Windows.Forms.Label weekValLbl;
        private System.Windows.Forms.Label weekLbl;
    }
}