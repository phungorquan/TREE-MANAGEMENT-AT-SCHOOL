namespace Project1
{
    partial class BcChamSoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BcChamSoc));
            this.panelMain = new System.Windows.Forms.Panel();
            this.TieuDe = new System.Windows.Forms.Label();
            this.dataChamSoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieuMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ThangTextBox = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamSoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.TieuDe);
            this.panelMain.Controls.Add(this.dataChamSoc);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.ThangTextBox);
            this.panelMain.Location = new System.Drawing.Point(0, 16);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 522);
            this.panelMain.TabIndex = 4;
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.Location = new System.Drawing.Point(249, 14);
            this.TieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(418, 45);
            this.TieuDe.TabIndex = 5;
            this.TieuDe.Text = "Báo Cáo Chi Phí Chăm Sóc";
            this.TieuDe.Click += new System.EventHandler(this.TieuDe_Click);
            // 
            // dataChamSoc
            // 
            this.dataChamSoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataChamSoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChamSoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Vattu,
            this.SoPhieuMua,
            this.TongTriGia,
            this.Tyle});
            this.dataChamSoc.Location = new System.Drawing.Point(4, 96);
            this.dataChamSoc.Margin = new System.Windows.Forms.Padding(4);
            this.dataChamSoc.Name = "dataChamSoc";
            this.dataChamSoc.Size = new System.Drawing.Size(926, 422);
            this.dataChamSoc.TabIndex = 4;
            this.dataChamSoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChamSoc_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Vattu
            // 
            this.Vattu.HeaderText = "Vật Tư";
            this.Vattu.Name = "Vattu";
            // 
            // SoPhieuMua
            // 
            this.SoPhieuMua.HeaderText = "Số Phiếu Mua";
            this.SoPhieuMua.Name = "SoPhieuMua";
            // 
            // TongTriGia
            // 
            this.TongTriGia.HeaderText = "Tổng Trị Giá";
            this.TongTriGia.Name = "TongTriGia";
            // 
            // Tyle
            // 
            this.Tyle.HeaderText = "Tỷ Lệ";
            this.Tyle.Name = "Tyle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng";
            // 
            // ThangTextBox
            // 
            this.ThangTextBox.Location = new System.Drawing.Point(365, 63);
            this.ThangTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThangTextBox.Name = "ThangTextBox";
            this.ThangTextBox.Size = new System.Drawing.Size(398, 22);
            this.ThangTextBox.TabIndex = 1;
            this.ThangTextBox.TextChanged += new System.EventHandler(this.ThangTextBox_TextChanged);
            // 
            // BcChamSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BcChamSoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Chi Phí Chăm Sóc";
            this.MinimumSizeChanged += new System.EventHandler(this.BcChamSoc_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.BcChamSoc_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamSoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label TieuDe;
        private System.Windows.Forms.DataGridView dataChamSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ThangTextBox;
    }
}