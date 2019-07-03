namespace Project1
{
    partial class SuaViTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaViTri));
            this.label2 = new System.Windows.Forms.Label();
            this.HuyBT = new System.Windows.Forms.Button();
            this.ThemBT = new System.Windows.Forms.Button();
            this.tenvitriTB = new System.Windows.Forms.TextBox();
            this.tenVatTuLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maViTriTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sửa Vị Trí";
            // 
            // HuyBT
            // 
            this.HuyBT.Location = new System.Drawing.Point(216, 172);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(107, 29);
            this.HuyBT.TabIndex = 33;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = true;
            this.HuyBT.Click += new System.EventHandler(this.HuyBT_Click);
            // 
            // ThemBT
            // 
            this.ThemBT.Location = new System.Drawing.Point(52, 172);
            this.ThemBT.Name = "ThemBT";
            this.ThemBT.Size = new System.Drawing.Size(107, 29);
            this.ThemBT.TabIndex = 32;
            this.ThemBT.Text = "Sửa";
            this.ThemBT.UseVisualStyleBackColor = true;
            this.ThemBT.Click += new System.EventHandler(this.ThemBT_Click);
            // 
            // tenvitriTB
            // 
            this.tenvitriTB.Location = new System.Drawing.Point(122, 124);
            this.tenvitriTB.Name = "tenvitriTB";
            this.tenvitriTB.Size = new System.Drawing.Size(256, 20);
            this.tenvitriTB.TabIndex = 31;
            // 
            // tenVatTuLB
            // 
            this.tenVatTuLB.AutoSize = true;
            this.tenVatTuLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenVatTuLB.Location = new System.Drawing.Point(22, 90);
            this.tenVatTuLB.Name = "tenVatTuLB";
            this.tenVatTuLB.Size = new System.Drawing.Size(75, 19);
            this.tenVatTuLB.TabIndex = 30;
            this.tenVatTuLB.Text = "Mã Vị Trí :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên Vị Trí :";
            // 
            // maViTriTB
            // 
            this.maViTriTB.Location = new System.Drawing.Point(122, 91);
            this.maViTriTB.Name = "maViTriTB";
            this.maViTriTB.Size = new System.Drawing.Size(256, 20);
            this.maViTriTB.TabIndex = 36;
            // 
            // SuaViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.Add(this.maViTriTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HuyBT);
            this.Controls.Add(this.ThemBT);
            this.Controls.Add(this.tenvitriTB);
            this.Controls.Add(this.tenVatTuLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaViTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Vị Trí";
            this.Load += new System.EventHandler(this.SuaViTri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.Button ThemBT;
        private System.Windows.Forms.TextBox tenvitriTB;
        private System.Windows.Forms.Label tenVatTuLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maViTriTB;
    }
}