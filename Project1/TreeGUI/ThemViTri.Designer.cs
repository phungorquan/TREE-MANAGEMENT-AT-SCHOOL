namespace Project1
{
    partial class ThemViTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemViTri));
            this.label2 = new System.Windows.Forms.Label();
            this.HuyBT = new System.Windows.Forms.Button();
            this.ThemBT = new System.Windows.Forms.Button();
            this.tenvitriTB = new System.Windows.Forms.TextBox();
            this.tenVatTuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thêm Vị Trí";
            // 
            // HuyBT
            // 
            this.HuyBT.Location = new System.Drawing.Point(232, 137);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(107, 29);
            this.HuyBT.TabIndex = 26;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = true;
            this.HuyBT.Click += new System.EventHandler(this.HuyBT_Click);
            // 
            // ThemBT
            // 
            this.ThemBT.Location = new System.Drawing.Point(65, 137);
            this.ThemBT.Name = "ThemBT";
            this.ThemBT.Size = new System.Drawing.Size(107, 29);
            this.ThemBT.TabIndex = 25;
            this.ThemBT.Text = "Thêm ";
            this.ThemBT.UseVisualStyleBackColor = true;
            this.ThemBT.Click += new System.EventHandler(this.ThemBT_Click);
            // 
            // tenvitriTB
            // 
            this.tenvitriTB.Location = new System.Drawing.Point(131, 79);
            this.tenvitriTB.Name = "tenvitriTB";
            this.tenvitriTB.Size = new System.Drawing.Size(256, 20);
            this.tenvitriTB.TabIndex = 23;
            // 
            // tenVatTuLB
            // 
            this.tenVatTuLB.AutoSize = true;
            this.tenVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenVatTuLB.Location = new System.Drawing.Point(31, 80);
            this.tenVatTuLB.Name = "tenVatTuLB";
            this.tenVatTuLB.Size = new System.Drawing.Size(69, 19);
            this.tenVatTuLB.TabIndex = 21;
            this.tenVatTuLB.Text = "Tên Vị Trí";
            // 
            // ThemViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HuyBT);
            this.Controls.Add(this.ThemBT);
            this.Controls.Add(this.tenvitriTB);
            this.Controls.Add(this.tenVatTuLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemViTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Vị Trí";
            this.Load += new System.EventHandler(this.ThemViTri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.Button ThemBT;
        private System.Windows.Forms.TextBox tenvitriTB;
        private System.Windows.Forms.Label tenVatTuLB;
    }
}