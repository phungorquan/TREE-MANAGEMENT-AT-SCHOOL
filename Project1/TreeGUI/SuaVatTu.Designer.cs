namespace Project1
{
    partial class SuaVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaVatTu));
            this.HuyBT = new System.Windows.Forms.Button();
            this.suaBT = new System.Windows.Forms.Button();
            this.diaChiTB = new System.Windows.Forms.TextBox();
            this.tenVatTuTB = new System.Windows.Forms.TextBox();
            this.diachiLB = new System.Windows.Forms.Label();
            this.tenVatTuLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giaBT = new System.Windows.Forms.TextBox();
            this.maVatTuTB = new System.Windows.Forms.TextBox();
            this.maVatTuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HuyBT
            // 
            this.HuyBT.Location = new System.Drawing.Point(234, 203);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(107, 29);
            this.HuyBT.TabIndex = 15;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = true;
            // 
            // suaBT
            // 
            this.suaBT.Location = new System.Drawing.Point(53, 203);
            this.suaBT.Name = "suaBT";
            this.suaBT.Size = new System.Drawing.Size(107, 29);
            this.suaBT.TabIndex = 14;
            this.suaBT.Text = "Sửa";
            this.suaBT.UseVisualStyleBackColor = true;
            this.suaBT.Click += new System.EventHandler(this.suaBT_Click);
            // 
            // diaChiTB
            // 
            this.diaChiTB.Location = new System.Drawing.Point(119, 118);
            this.diaChiTB.Name = "diaChiTB";
            this.diaChiTB.Size = new System.Drawing.Size(256, 20);
            this.diaChiTB.TabIndex = 13;
            // 
            // tenVatTuTB
            // 
            this.tenVatTuTB.Location = new System.Drawing.Point(119, 79);
            this.tenVatTuTB.Name = "tenVatTuTB";
            this.tenVatTuTB.Size = new System.Drawing.Size(256, 20);
            this.tenVatTuTB.TabIndex = 12;
            // 
            // diachiLB
            // 
            this.diachiLB.AutoSize = true;
            this.diachiLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachiLB.Location = new System.Drawing.Point(19, 119);
            this.diachiLB.Name = "diachiLB";
            this.diachiLB.Size = new System.Drawing.Size(60, 19);
            this.diachiLB.TabIndex = 10;
            this.diachiLB.Text = "Địa Chỉ:";
            // 
            // tenVatTuLB
            // 
            this.tenVatTuLB.AutoSize = true;
            this.tenVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenVatTuLB.Location = new System.Drawing.Point(19, 80);
            this.tenVatTuLB.Name = "tenVatTuLB";
            this.tenVatTuLB.Size = new System.Drawing.Size(82, 19);
            this.tenVatTuLB.TabIndex = 9;
            this.tenVatTuLB.Text = "Tên Vật Tư:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giá:";
            // 
            // giaBT
            // 
            this.giaBT.Location = new System.Drawing.Point(119, 159);
            this.giaBT.Name = "giaBT";
            this.giaBT.Size = new System.Drawing.Size(256, 20);
            this.giaBT.TabIndex = 17;
            // 
            // maVatTuTB
            // 
            this.maVatTuTB.Location = new System.Drawing.Point(119, 41);
            this.maVatTuTB.Name = "maVatTuTB";
            this.maVatTuTB.Size = new System.Drawing.Size(256, 20);
            this.maVatTuTB.TabIndex = 11;
            // 
            // maVatTuLB
            // 
            this.maVatTuLB.AutoSize = true;
            this.maVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maVatTuLB.Location = new System.Drawing.Point(19, 41);
            this.maVatTuLB.Name = "maVatTuLB";
            this.maVatTuLB.Size = new System.Drawing.Size(80, 19);
            this.maVatTuLB.TabIndex = 8;
            this.maVatTuLB.Text = "Mã Vật Tư:";
            // 
            // SuaVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 247);
            this.Controls.Add(this.giaBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HuyBT);
            this.Controls.Add(this.suaBT);
            this.Controls.Add(this.diaChiTB);
            this.Controls.Add(this.tenVatTuTB);
            this.Controls.Add(this.maVatTuTB);
            this.Controls.Add(this.diachiLB);
            this.Controls.Add(this.tenVatTuLB);
            this.Controls.Add(this.maVatTuLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaVatTu";
            this.Load += new System.EventHandler(this.SuaVatTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.Button suaBT;
        private System.Windows.Forms.TextBox diaChiTB;
        private System.Windows.Forms.TextBox tenVatTuTB;
        private System.Windows.Forms.Label diachiLB;
        private System.Windows.Forms.Label tenVatTuLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox giaBT;
        private System.Windows.Forms.TextBox maVatTuTB;
        private System.Windows.Forms.Label maVatTuLB;
    }
}