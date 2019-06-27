namespace Project1
{
    partial class XoaVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaVatTu));
            this.HuyBT = new System.Windows.Forms.Button();
            this.XoaBT = new System.Windows.Forms.Button();
            this.maVatTuTB = new System.Windows.Forms.TextBox();
            this.maVatTuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HuyBT
            // 
            this.HuyBT.Location = new System.Drawing.Point(205, 87);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(107, 29);
            this.HuyBT.TabIndex = 11;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = true;
            this.HuyBT.Click += new System.EventHandler(this.HuyBT_Click);
            // 
            // XoaBT
            // 
            this.XoaBT.Location = new System.Drawing.Point(39, 87);
            this.XoaBT.Name = "XoaBT";
            this.XoaBT.Size = new System.Drawing.Size(107, 29);
            this.XoaBT.TabIndex = 10;
            this.XoaBT.Text = "Xóa";
            this.XoaBT.UseVisualStyleBackColor = true;
            this.XoaBT.Click += new System.EventHandler(this.XoaBT_Click);
            // 
            // maVatTuTB
            // 
            this.maVatTuTB.Location = new System.Drawing.Point(85, 40);
            this.maVatTuTB.Name = "maVatTuTB";
            this.maVatTuTB.Size = new System.Drawing.Size(244, 20);
            this.maVatTuTB.TabIndex = 9;
            // 
            // maVatTuLB
            // 
            this.maVatTuLB.AutoSize = true;
            this.maVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maVatTuLB.Location = new System.Drawing.Point(-1, 41);
            this.maVatTuLB.Name = "maVatTuLB";
            this.maVatTuLB.Size = new System.Drawing.Size(80, 19);
            this.maVatTuLB.TabIndex = 8;
            this.maVatTuLB.Text = "Mã Vật Tư:";
            // 
            // XoaVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 142);
            this.Controls.Add(this.HuyBT);
            this.Controls.Add(this.XoaBT);
            this.Controls.Add(this.maVatTuTB);
            this.Controls.Add(this.maVatTuLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XoaVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Vật Tư";
            this.Load += new System.EventHandler(this.XoaVatTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.Button XoaBT;
        private System.Windows.Forms.TextBox maVatTuTB;
        private System.Windows.Forms.Label maVatTuLB;
    }
}