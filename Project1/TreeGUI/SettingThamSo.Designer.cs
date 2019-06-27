namespace Project1
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.suaDoiBT = new System.Windows.Forms.Button();
            this.STTDLB = new System.Windows.Forms.Label();
            this.SCTDLB = new System.Windows.Forms.Label();
            this.TienTB = new System.Windows.Forms.TextBox();
            this.CayTB = new System.Windows.Forms.TextBox();
            this.Hủy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // suaDoiBT
            // 
            this.suaDoiBT.Location = new System.Drawing.Point(82, 100);
            this.suaDoiBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suaDoiBT.Name = "suaDoiBT";
            this.suaDoiBT.Size = new System.Drawing.Size(76, 25);
            this.suaDoiBT.TabIndex = 0;
            this.suaDoiBT.Text = "Sửa Đổi";
            this.suaDoiBT.UseVisualStyleBackColor = true;
            this.suaDoiBT.Click += new System.EventHandler(this.suaDoiBT_Click);
            // 
            // STTDLB
            // 
            this.STTDLB.AutoSize = true;
            this.STTDLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STTDLB.Location = new System.Drawing.Point(31, 22);
            this.STTDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.STTDLB.Name = "STTDLB";
            this.STTDLB.Size = new System.Drawing.Size(139, 19);
            this.STTDLB.TabIndex = 1;
            this.STTDLB.Text = "Số Tiền Mua Tối Đa:";
            // 
            // SCTDLB
            // 
            this.SCTDLB.AutoSize = true;
            this.SCTDLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCTDLB.Location = new System.Drawing.Point(31, 67);
            this.SCTDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SCTDLB.Name = "SCTDLB";
            this.SCTDLB.Size = new System.Drawing.Size(145, 19);
            this.SCTDLB.TabIndex = 2;
            this.SCTDLB.Text = "Số Lượng Cây Tối Đa:";
            // 
            // TienTB
            // 
            this.TienTB.Location = new System.Drawing.Point(200, 23);
            this.TienTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TienTB.Name = "TienTB";
            this.TienTB.ReadOnly = true;
            this.TienTB.Size = new System.Drawing.Size(176, 20);
            this.TienTB.TabIndex = 3;
            // 
            // CayTB
            // 
            this.CayTB.Location = new System.Drawing.Point(200, 70);
            this.CayTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CayTB.Name = "CayTB";
            this.CayTB.ReadOnly = true;
            this.CayTB.Size = new System.Drawing.Size(176, 20);
            this.CayTB.TabIndex = 4;
            // 
            // Hủy
            // 
            this.Hủy.Location = new System.Drawing.Point(208, 100);
            this.Hủy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hủy.Name = "Hủy";
            this.Hủy.Size = new System.Drawing.Size(76, 25);
            this.Hủy.TabIndex = 5;
            this.Hủy.Text = "Hủy";
            this.Hủy.UseVisualStyleBackColor = true;
            this.Hủy.Click += new System.EventHandler(this.Hủy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hủy);
            this.panel1.Controls.Add(this.CayTB);
            this.panel1.Controls.Add(this.TienTB);
            this.panel1.Controls.Add(this.SCTDLB);
            this.panel1.Controls.Add(this.STTDLB);
            this.panel1.Controls.Add(this.suaDoiBT);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 145);
            this.panel1.TabIndex = 0;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 145);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Tham Số";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button suaDoiBT;
        private System.Windows.Forms.Label STTDLB;
        private System.Windows.Forms.Label SCTDLB;
        private System.Windows.Forms.TextBox TienTB;
        private System.Windows.Forms.TextBox CayTB;
        private System.Windows.Forms.Button Hủy;
        private System.Windows.Forms.Panel panel1;
    }
}