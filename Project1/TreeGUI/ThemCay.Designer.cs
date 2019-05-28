namespace Project1
{
    partial class ThemCay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemCay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaCay = new System.Windows.Forms.Label();
            this.MaCayTB = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiCay = new System.Windows.Forms.ComboBox();
            this.comboBoxVitri = new System.Windows.Forms.ComboBox();
            this.Them = new System.Windows.Forms.Button();
            this.Huy = new System.Windows.Forms.Button();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.LoaiCay = new System.Windows.Forms.Label();
            this.NgayTrong = new System.Windows.Forms.Label();
            this.ViTri = new System.Windows.Forms.Label();
            this.TenCay = new System.Windows.Forms.Label();
            this.NgayTrongTB = new System.Windows.Forms.TextBox();
            this.TenCaytb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaCay);
            this.panel1.Controls.Add(this.MaCayTB);
            this.panel1.Controls.Add(this.comboBoxLoaiCay);
            this.panel1.Controls.Add(this.comboBoxVitri);
            this.panel1.Controls.Add(this.Them);
            this.panel1.Controls.Add(this.Huy);
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Controls.Add(this.LoaiCay);
            this.panel1.Controls.Add(this.NgayTrong);
            this.panel1.Controls.Add(this.ViTri);
            this.panel1.Controls.Add(this.TenCay);
            this.panel1.Controls.Add(this.NgayTrongTB);
            this.panel1.Controls.Add(this.TenCaytb);
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 340);
            this.panel1.TabIndex = 1;
            // 
            // MaCay
            // 
            this.MaCay.AutoSize = true;
            this.MaCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCay.Location = new System.Drawing.Point(57, 79);
            this.MaCay.Name = "MaCay";
            this.MaCay.Size = new System.Drawing.Size(62, 19);
            this.MaCay.TabIndex = 31;
            this.MaCay.Text = "Mã Cây:";
            // 
            // MaCayTB
            // 
            this.MaCayTB.Location = new System.Drawing.Point(188, 80);
            this.MaCayTB.Name = "MaCayTB";
            this.MaCayTB.Size = new System.Drawing.Size(369, 20);
            this.MaCayTB.TabIndex = 30;
            // 
            // comboBoxLoaiCay
            // 
            this.comboBoxLoaiCay.FormattingEnabled = true;
            this.comboBoxLoaiCay.Location = new System.Drawing.Point(188, 163);
            this.comboBoxLoaiCay.Name = "comboBoxLoaiCay";
            this.comboBoxLoaiCay.Size = new System.Drawing.Size(369, 21);
            this.comboBoxLoaiCay.TabIndex = 29;
            // 
            // comboBoxVitri
            // 
            this.comboBoxVitri.FormattingEnabled = true;
            this.comboBoxVitri.Location = new System.Drawing.Point(188, 203);
            this.comboBoxVitri.Name = "comboBoxVitri";
            this.comboBoxVitri.Size = new System.Drawing.Size(369, 21);
            this.comboBoxVitri.TabIndex = 28;
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(130, 284);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(150, 41);
            this.Them.TabIndex = 27;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Huy
            // 
            this.Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Huy.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huy.Location = new System.Drawing.Point(325, 284);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(150, 41);
            this.Huy.TabIndex = 27;
            this.Huy.Text = "Hủy";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTieuDe.Location = new System.Drawing.Point(206, 20);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(201, 39);
            this.labelTieuDe.TabIndex = 25;
            this.labelTieuDe.Text = "Hồ sơ cây mới";
            // 
            // LoaiCay
            // 
            this.LoaiCay.AutoSize = true;
            this.LoaiCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiCay.Location = new System.Drawing.Point(57, 162);
            this.LoaiCay.Name = "LoaiCay";
            this.LoaiCay.Size = new System.Drawing.Size(68, 19);
            this.LoaiCay.TabIndex = 24;
            this.LoaiCay.Text = "Loại Cây:";
            // 
            // NgayTrong
            // 
            this.NgayTrong.AutoSize = true;
            this.NgayTrong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTrong.Location = new System.Drawing.Point(54, 238);
            this.NgayTrong.Name = "NgayTrong";
            this.NgayTrong.Size = new System.Drawing.Size(90, 19);
            this.NgayTrong.TabIndex = 21;
            this.NgayTrong.Text = "Ngày Trồng: ";
            // 
            // ViTri
            // 
            this.ViTri.AutoSize = true;
            this.ViTri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViTri.Location = new System.Drawing.Point(54, 202);
            this.ViTri.Name = "ViTri";
            this.ViTri.Size = new System.Drawing.Size(50, 19);
            this.ViTri.TabIndex = 20;
            this.ViTri.Text = "Vị Trí :";
            // 
            // TenCay
            // 
            this.TenCay.AutoSize = true;
            this.TenCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCay.Location = new System.Drawing.Point(54, 123);
            this.TenCay.Name = "TenCay";
            this.TenCay.Size = new System.Drawing.Size(68, 19);
            this.TenCay.TabIndex = 19;
            this.TenCay.Text = "Tên Cây :";
            // 
            // NgayTrongTB
            // 
            this.NgayTrongTB.Location = new System.Drawing.Point(188, 239);
            this.NgayTrongTB.Name = "NgayTrongTB";
            this.NgayTrongTB.Size = new System.Drawing.Size(369, 20);
            this.NgayTrongTB.TabIndex = 16;
            // 
            // TenCaytb
            // 
            this.TenCaytb.Location = new System.Drawing.Point(188, 122);
            this.TenCaytb.Name = "TenCaytb";
            this.TenCaytb.Size = new System.Drawing.Size(369, 20);
            this.TenCaytb.TabIndex = 13;
            // 
            // ThemCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemCay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Cây";
            this.Load += new System.EventHandler(this.ThemCay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label LoaiCay;
        private System.Windows.Forms.Label NgayTrong;
        private System.Windows.Forms.Label ViTri;
        private System.Windows.Forms.Label TenCay;
        private System.Windows.Forms.TextBox NgayTrongTB;
        private System.Windows.Forms.TextBox TenCaytb;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label MaCay;
        private System.Windows.Forms.TextBox MaCayTB;
        private System.Windows.Forms.ComboBox comboBoxLoaiCay;
        private System.Windows.Forms.ComboBox comboBoxVitri;
    }
}