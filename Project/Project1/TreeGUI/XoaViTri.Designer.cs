namespace Project1
{
    partial class XoaViTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaViTri));
            this.maViTriTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HuyBT = new System.Windows.Forms.Button();
            this.XoaBT = new System.Windows.Forms.Button();
            this.tenVatTuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maViTriTB
            // 
            this.maViTriTB.Location = new System.Drawing.Point(109, 80);
            this.maViTriTB.Name = "maViTriTB";
            this.maViTriTB.Size = new System.Drawing.Size(232, 20);
            this.maViTriTB.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "Xóa Vị Trí";
            // 
            // HuyBT
            // 
            this.HuyBT.Location = new System.Drawing.Point(211, 131);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(107, 29);
            this.HuyBT.TabIndex = 40;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = true;
            this.HuyBT.Click += new System.EventHandler(this.HuyBT_Click);
            // 
            // XoaBT
            // 
            this.XoaBT.Location = new System.Drawing.Point(50, 131);
            this.XoaBT.Name = "XoaBT";
            this.XoaBT.Size = new System.Drawing.Size(107, 29);
            this.XoaBT.TabIndex = 39;
            this.XoaBT.Text = "Xóa";
            this.XoaBT.UseVisualStyleBackColor = true;
            this.XoaBT.Click += new System.EventHandler(this.XoaBT_Click);
            // 
            // tenVatTuLB
            // 
            this.tenVatTuLB.AutoSize = true;
            this.tenVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenVatTuLB.Location = new System.Drawing.Point(9, 79);
            this.tenVatTuLB.Name = "tenVatTuLB";
            this.tenVatTuLB.Size = new System.Drawing.Size(75, 19);
            this.tenVatTuLB.TabIndex = 37;
            this.tenVatTuLB.Text = "Mã Vị Trí :";
            // 
            // XoaViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 193);
            this.Controls.Add(this.maViTriTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HuyBT);
            this.Controls.Add(this.XoaBT);
            this.Controls.Add(this.tenVatTuLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XoaViTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Vị Trí";
            this.Load += new System.EventHandler(this.XoaViTri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maViTriTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.Button XoaBT;
        private System.Windows.Forms.Label tenVatTuLB;
    }
}