namespace Project1
{
    partial class LichCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichCS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.dataCaycanh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayLaptb = new System.Windows.Forms.TextBox();
            this.CayCanhtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCaycanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Controls.Add(this.dataCaycanh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NgayLaptb);
            this.panel1.Controls.Add(this.CayCanhtb);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 565);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.Location = new System.Drawing.Point(360, 15);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(237, 45);
            this.labelTieuDe.TabIndex = 5;
            this.labelTieuDe.Text = "Lịch Chăm Sóc";
            // 
            // dataCaycanh
            // 
            this.dataCaycanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCaycanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCaycanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ThoiGian,
            this.Vattu,
            this.DonViTinh,
            this.Soluong,
            this.GhiChu});
            this.dataCaycanh.Location = new System.Drawing.Point(4, 96);
            this.dataCaycanh.Margin = new System.Windows.Forms.Padding(4);
            this.dataCaycanh.Name = "dataCaycanh";
            this.dataCaycanh.Size = new System.Drawing.Size(989, 469);
            this.dataCaycanh.TabIndex = 4;
            this.dataCaycanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCaycanh_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // Vattu
            // 
            this.Vattu.HeaderText = "Vật Tư";
            this.Vattu.Name = "Vattu";
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Lập Lịch:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cây Cảnh:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NgayLaptb
            // 
            this.NgayLaptb.Location = new System.Drawing.Point(641, 66);
            this.NgayLaptb.Margin = new System.Windows.Forms.Padding(4);
            this.NgayLaptb.Name = "NgayLaptb";
            this.NgayLaptb.Size = new System.Drawing.Size(297, 22);
            this.NgayLaptb.TabIndex = 1;
            this.NgayLaptb.TextChanged += new System.EventHandler(this.NgayLaptb_TextChanged);
            // 
            // CayCanhtb
            // 
            this.CayCanhtb.Location = new System.Drawing.Point(164, 64);
            this.CayCanhtb.Margin = new System.Windows.Forms.Padding(4);
            this.CayCanhtb.Name = "CayCanhtb";
            this.CayCanhtb.Size = new System.Drawing.Size(334, 22);
            this.CayCanhtb.TabIndex = 0;
            this.CayCanhtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cây Cảnh:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // LichCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LichCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichCS";
            this.Load += new System.EventHandler(this.LichCS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCaycanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.DataGridView dataCaycanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NgayLaptb;
        private System.Windows.Forms.TextBox CayCanhtb;
        private System.Windows.Forms.Label label4;
    }
}