namespace Project1
{
    partial class XoaCay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaCay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.XoaButton = new System.Windows.Forms.Button();
            this.Huy = new System.Windows.Forms.Button();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.LoaiCay = new System.Windows.Forms.Label();
            this.NgayTrong = new System.Windows.Forms.Label();
            this.ViTri = new System.Windows.Forms.Label();
            this.TenCay = new System.Windows.Forms.Label();
            this.NgayTrongTB = new System.Windows.Forms.TextBox();
            this.ViTriTB = new System.Windows.Forms.TextBox();
            this.LoaiCaytb = new System.Windows.Forms.TextBox();
            this.TenCaytb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.XoaButton);
            this.panel1.Controls.Add(this.Huy);
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Controls.Add(this.LoaiCay);
            this.panel1.Controls.Add(this.NgayTrong);
            this.panel1.Controls.Add(this.ViTri);
            this.panel1.Controls.Add(this.TenCay);
            this.panel1.Controls.Add(this.NgayTrongTB);
            this.panel1.Controls.Add(this.ViTriTB);
            this.panel1.Controls.Add(this.LoaiCaytb);
            this.panel1.Controls.Add(this.TenCaytb);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 418);
            this.panel1.TabIndex = 2;
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(174, 329);
            this.XoaButton.Margin = new System.Windows.Forms.Padding(4);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(200, 50);
            this.XoaButton.TabIndex = 27;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // Huy
            // 
            this.Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Huy.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huy.Location = new System.Drawing.Point(439, 329);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(200, 50);
            this.Huy.TabIndex = 27;
            this.Huy.Text = "Hủy";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            this.Huy.Leave += new System.EventHandler(this.Huy_Click);
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTieuDe.Location = new System.Drawing.Point(244, 24);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(318, 49);
            this.labelTieuDe.TabIndex = 25;
            this.labelTieuDe.Text = "Xóa Thông Tin Cây";
            this.labelTieuDe.Click += new System.EventHandler(this.labelTieuDe_Click);
            // 
            // LoaiCay
            // 
            this.LoaiCay.AutoSize = true;
            this.LoaiCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiCay.Location = new System.Drawing.Point(72, 166);
            this.LoaiCay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoaiCay.Name = "LoaiCay";
            this.LoaiCay.Size = new System.Drawing.Size(84, 24);
            this.LoaiCay.TabIndex = 24;
            this.LoaiCay.Text = "Loại Cây:";
            // 
            // NgayTrong
            // 
            this.NgayTrong.AutoSize = true;
            this.NgayTrong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTrong.Location = new System.Drawing.Point(72, 278);
            this.NgayTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NgayTrong.Name = "NgayTrong";
            this.NgayTrong.Size = new System.Drawing.Size(113, 24);
            this.NgayTrong.TabIndex = 21;
            this.NgayTrong.Text = "Ngày Trồng: ";
            // 
            // ViTri
            // 
            this.ViTri.AutoSize = true;
            this.ViTri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViTri.Location = new System.Drawing.Point(72, 219);
            this.ViTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViTri.Name = "ViTri";
            this.ViTri.Size = new System.Drawing.Size(62, 24);
            this.ViTri.TabIndex = 20;
            this.ViTri.Text = "Vị Trí :";
            // 
            // TenCay
            // 
            this.TenCay.AutoSize = true;
            this.TenCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCay.Location = new System.Drawing.Point(72, 112);
            this.TenCay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenCay.Name = "TenCay";
            this.TenCay.Size = new System.Drawing.Size(84, 24);
            this.TenCay.TabIndex = 19;
            this.TenCay.Text = "Tên Cây :";
            // 
            // NgayTrongTB
            // 
            this.NgayTrongTB.Location = new System.Drawing.Point(251, 277);
            this.NgayTrongTB.Margin = new System.Windows.Forms.Padding(4);
            this.NgayTrongTB.Name = "NgayTrongTB";
            this.NgayTrongTB.Size = new System.Drawing.Size(491, 22);
            this.NgayTrongTB.TabIndex = 16;
            // 
            // ViTriTB
            // 
            this.ViTriTB.Location = new System.Drawing.Point(251, 218);
            this.ViTriTB.Margin = new System.Windows.Forms.Padding(4);
            this.ViTriTB.Name = "ViTriTB";
            this.ViTriTB.Size = new System.Drawing.Size(491, 22);
            this.ViTriTB.TabIndex = 15;
            // 
            // LoaiCaytb
            // 
            this.LoaiCaytb.Location = new System.Drawing.Point(251, 167);
            this.LoaiCaytb.Margin = new System.Windows.Forms.Padding(4);
            this.LoaiCaytb.Name = "LoaiCaytb";
            this.LoaiCaytb.Size = new System.Drawing.Size(491, 22);
            this.LoaiCaytb.TabIndex = 14;
            // 
            // TenCaytb
            // 
            this.TenCaytb.Location = new System.Drawing.Point(251, 113);
            this.TenCaytb.Margin = new System.Windows.Forms.Padding(4);
            this.TenCaytb.Name = "TenCaytb";
            this.TenCaytb.Size = new System.Drawing.Size(491, 22);
            this.TenCaytb.TabIndex = 13;
            this.TenCaytb.TextChanged += new System.EventHandler(this.TenCaytb_TextChanged);
            // 
            // XoaCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XoaCay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Cây";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label LoaiCay;
        private System.Windows.Forms.Label NgayTrong;
        private System.Windows.Forms.Label ViTri;
        private System.Windows.Forms.Label TenCay;
        private System.Windows.Forms.TextBox NgayTrongTB;
        private System.Windows.Forms.TextBox ViTriTB;
        private System.Windows.Forms.TextBox LoaiCaytb;
        private System.Windows.Forms.TextBox TenCaytb;
    }
}