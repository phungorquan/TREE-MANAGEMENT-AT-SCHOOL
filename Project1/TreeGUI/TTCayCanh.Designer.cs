namespace Project1
{
    partial class TTCayCanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTCayCanh));
            this.label3 = new System.Windows.Forms.Label();
            this.dataCayCanh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CayCanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Thangtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCayCanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Báo Cáo Tình Trạng Cây Cảnh";
            // 
            // dataCayCanh
            // 
            this.dataCayCanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCayCanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCayCanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CayCanh,
            this.LoaiCay,
            this.NgayTrong,
            this.TinhTrang});
            this.dataCayCanh.Location = new System.Drawing.Point(4, 96);
            this.dataCayCanh.Margin = new System.Windows.Forms.Padding(4);
            this.dataCayCanh.Name = "dataCayCanh";
            this.dataCayCanh.Size = new System.Drawing.Size(820, 395);
            this.dataCayCanh.TabIndex = 4;
            this.dataCayCanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // CayCanh
            // 
            this.CayCanh.HeaderText = "CayCanh";
            this.CayCanh.Name = "CayCanh";
            // 
            // LoaiCay
            // 
            this.LoaiCay.HeaderText = "Loại Cây";
            this.LoaiCay.Name = "LoaiCay";
            // 
            // NgayTrong
            // 
            this.NgayTrong.HeaderText = "Ngày Trồng";
            this.NgayTrong.Name = "NgayTrong";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataCayCanh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Thangtextbox);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 491);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng :";
            // 
            // Thangtextbox
            // 
            this.Thangtextbox.Location = new System.Drawing.Point(297, 64);
            this.Thangtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.Thangtextbox.Name = "Thangtextbox";
            this.Thangtextbox.Size = new System.Drawing.Size(388, 22);
            this.Thangtextbox.TabIndex = 1;
            this.Thangtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TTCayCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TTCayCanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tình Trạng Cây Cảnh";
            ((System.ComponentModel.ISupportInitialize)(this.dataCayCanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataCayCanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CayCanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Thangtextbox;
    }
}