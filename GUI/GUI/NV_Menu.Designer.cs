namespace GUI.GUI
{
    partial class NV_Menu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Hello_Label = new System.Windows.Forms.Label();
            this.XepLich_Button = new System.Windows.Forms.Button();
            this.XuLyPhieuDKTC_Button = new System.Windows.Forms.Button();
            this.DKLichRanh_Button = new System.Windows.Forms.Button();
            this.CaiDat_Button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Hello_Label);
            this.flowLayoutPanel1.Controls.Add(this.XepLich_Button);
            this.flowLayoutPanel1.Controls.Add(this.XuLyPhieuDKTC_Button);
            this.flowLayoutPanel1.Controls.Add(this.DKLichRanh_Button);
            this.flowLayoutPanel1.Controls.Add(this.CaiDat_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 248);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Hello_Label
            // 
            this.Hello_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello_Label.Location = new System.Drawing.Point(13, 10);
            this.Hello_Label.Name = "Hello_Label";
            this.Hello_Label.Size = new System.Drawing.Size(350, 97);
            this.Hello_Label.TabIndex = 0;
            this.Hello_Label.Text = "Xin chào, ";
            this.Hello_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XepLich_Button
            // 
            this.XepLich_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XepLich_Button.Location = new System.Drawing.Point(13, 111);
            this.XepLich_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XepLich_Button.Name = "XepLich_Button";
            this.XepLich_Button.Size = new System.Drawing.Size(173, 58);
            this.XepLich_Button.TabIndex = 3;
            this.XepLich_Button.Text = "Xếp lịch làm việc";
            this.XepLich_Button.UseVisualStyleBackColor = true;
            this.XepLich_Button.Click += new System.EventHandler(this.XepLich_Button_Click);
            // 
            // XuLyPhieuDKTC_Button
            // 
            this.XuLyPhieuDKTC_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuLyPhieuDKTC_Button.Location = new System.Drawing.Point(192, 111);
            this.XuLyPhieuDKTC_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XuLyPhieuDKTC_Button.Name = "XuLyPhieuDKTC_Button";
            this.XuLyPhieuDKTC_Button.Size = new System.Drawing.Size(171, 58);
            this.XuLyPhieuDKTC_Button.TabIndex = 2;
            this.XuLyPhieuDKTC_Button.Text = "Xử lý phiếu đăng ký tiêm chủng";
            this.XuLyPhieuDKTC_Button.UseVisualStyleBackColor = true;
            this.XuLyPhieuDKTC_Button.Click += new System.EventHandler(this.XuLyPhieuDKTC_Button_Click);
            // 
            // DKLichRanh_Button
            // 
            this.DKLichRanh_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DKLichRanh_Button.Location = new System.Drawing.Point(13, 177);
            this.DKLichRanh_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DKLichRanh_Button.Name = "DKLichRanh_Button";
            this.DKLichRanh_Button.Size = new System.Drawing.Size(171, 58);
            this.DKLichRanh_Button.TabIndex = 4;
            this.DKLichRanh_Button.Text = "Đăng ký lịch rảnh";
            this.DKLichRanh_Button.UseVisualStyleBackColor = true;
            this.DKLichRanh_Button.Click += new System.EventHandler(this.DKLichRanh_Button_Click);
            // 
            // CaiDat_Button
            // 
            this.CaiDat_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaiDat_Button.Location = new System.Drawing.Point(190, 177);
            this.CaiDat_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaiDat_Button.Name = "CaiDat_Button";
            this.CaiDat_Button.Size = new System.Drawing.Size(171, 58);
            this.CaiDat_Button.TabIndex = 5;
            this.CaiDat_Button.Text = "Cài đặt";
            this.CaiDat_Button.UseVisualStyleBackColor = true;
            // 
            // NV_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 248);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "NV_Menu";
            this.Text = "Trung tâm tiêm chủng An Bình";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Hello_Label;
        private System.Windows.Forms.Button XuLyPhieuDKTC_Button;
        private System.Windows.Forms.Button XepLich_Button;
        private System.Windows.Forms.Button DKLichRanh_Button;
        private System.Windows.Forms.Button CaiDat_Button;
    }
}