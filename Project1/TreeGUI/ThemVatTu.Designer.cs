namespace Project1
{
    partial class ThemVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemVatTu));
            this.tenVatTuLB = new System.Windows.Forms.Label();
            this.diachiLB = new System.Windows.Forms.Label();
            this.tenVatTuTB = new System.Windows.Forms.TextBox();
            this.diaChiTB = new System.Windows.Forms.TextBox();
            this.ThemBT = new System.Windows.Forms.Button();
            this.HuyBT = new System.Windows.Forms.Button();
            this.giaBT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenVatTuLB
            // 
            this.tenVatTuLB.AutoSize = true;
            this.tenVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenVatTuLB.Location = new System.Drawing.Point(35, 79);
            this.tenVatTuLB.Name = "tenVatTuLB";
            this.tenVatTuLB.Size = new System.Drawing.Size(82, 19);
            this.tenVatTuLB.TabIndex = 1;
            this.tenVatTuLB.Text = "Tên Vật Tư:";
            // 
            // diachiLB
            // 
            this.diachiLB.AutoSize = true;
            this.diachiLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachiLB.Location = new System.Drawing.Point(35, 116);
            this.diachiLB.Name = "diachiLB";
            this.diachiLB.Size = new System.Drawing.Size(60, 19);
            this.diachiLB.TabIndex = 2;
            this.diachiLB.Text = "Địa Chỉ:";
            // 
            // tenVatTuTB
            // 
            this.tenVatTuTB.Location = new System.Drawing.Point(135, 78);
            this.tenVatTuTB.Name = "tenVatTuTB";
            this.tenVatTuTB.Size = new System.Drawing.Size(256, 20);
            this.tenVatTuTB.TabIndex = 4;
            // 
            // diaChiTB
            // 
            this.diaChiTB.Location = new System.Drawing.Point(135, 116);
            this.diaChiTB.Name = "diaChiTB";
            this.diaChiTB.Size = new System.Drawing.Size(256, 20);
            this.diaChiTB.TabIndex = 5;
            // 
            // ThemBT
            // 
            this.ThemBT.Location = new System.Drawing.Point(70, 205);
            this.ThemBT.Name = "ThemBT";
            this.ThemBT.Size = new System.Drawing.Size(107, 29);
            this.ThemBT.TabIndex = 6;
            this.ThemBT.Text = "Thêm ";
            this.ThemBT.UseVisualStyleBackColor = true;
            this.ThemBT.Click += new System.EventHandler(this.ThemBT_Click);
            // 
            // HuyBT
            // 
            this.HuyBT.Location = new System.Drawing.Point(237, 205);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(107, 29);
            this.HuyBT.TabIndex = 7;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = true;
            this.HuyBT.Click += new System.EventHandler(this.HuyBT_Click);
            // 
            // giaBT
            // 
            this.giaBT.Location = new System.Drawing.Point(135, 158);
            this.giaBT.Name = "giaBT";
            this.giaBT.Size = new System.Drawing.Size(256, 20);
            this.giaBT.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thêm Vật Tư";
            // 
            // ThemVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giaBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HuyBT);
            this.Controls.Add(this.ThemBT);
            this.Controls.Add(this.diaChiTB);
            this.Controls.Add(this.tenVatTuTB);
            this.Controls.Add(this.diachiLB);
            this.Controls.Add(this.tenVatTuLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Vật Tư";
            this.Load += new System.EventHandler(this.ThemVatTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tenVatTuLB;
        private System.Windows.Forms.Label diachiLB;
        private System.Windows.Forms.TextBox tenVatTuTB;
        private System.Windows.Forms.TextBox diaChiTB;
        private System.Windows.Forms.Button ThemBT;
        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.TextBox giaBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}