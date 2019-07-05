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
            this.namLB = new System.Windows.Forms.Label();
            this.yearBT = new System.Windows.Forms.TextBox();
            this.monthBT = new System.Windows.Forms.TextBox();
            this.timKiemBT = new System.Windows.Forms.Button();
            this.dataChamSoc = new System.Windows.Forms.DataGridView();
            this.TieuDe = new System.Windows.Forms.Label();
            this.thangLB = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamSoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.namLB);
            this.panelMain.Controls.Add(this.yearBT);
            this.panelMain.Controls.Add(this.monthBT);
            this.panelMain.Controls.Add(this.timKiemBT);
            this.panelMain.Controls.Add(this.dataChamSoc);
            this.panelMain.Controls.Add(this.TieuDe);
            this.panelMain.Controls.Add(this.thangLB);
            this.panelMain.Location = new System.Drawing.Point(0, 16);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 522);
            this.panelMain.TabIndex = 4;
            // 
            // namLB
            // 
            this.namLB.AutoSize = true;
            this.namLB.Location = new System.Drawing.Point(405, 63);
            this.namLB.Name = "namLB";
            this.namLB.Size = new System.Drawing.Size(41, 17);
            this.namLB.TabIndex = 10;
            this.namLB.Text = "Năm:";
            // 
            // yearBT
            // 
            this.yearBT.Location = new System.Drawing.Point(452, 60);
            this.yearBT.Name = "yearBT";
            this.yearBT.Size = new System.Drawing.Size(95, 22);
            this.yearBT.TabIndex = 9;
            // 
            // monthBT
            // 
            this.monthBT.Location = new System.Drawing.Point(298, 60);
            this.monthBT.Name = "monthBT";
            this.monthBT.Size = new System.Drawing.Size(89, 22);
            this.monthBT.TabIndex = 8;
            // 
            // timKiemBT
            // 
            this.timKiemBT.Location = new System.Drawing.Point(567, 57);
            this.timKiemBT.Name = "timKiemBT";
            this.timKiemBT.Size = new System.Drawing.Size(100, 29);
            this.timKiemBT.TabIndex = 7;
            this.timKiemBT.Text = "Tìm Kiếm";
            this.timKiemBT.UseVisualStyleBackColor = true;
            this.timKiemBT.Click += new System.EventHandler(this.timKiemBT_Click);
            // 
            // dataChamSoc
            // 
            this.dataChamSoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChamSoc.Location = new System.Drawing.Point(3, 92);
            this.dataChamSoc.Name = "dataChamSoc";
            this.dataChamSoc.RowTemplate.Height = 24;
            this.dataChamSoc.Size = new System.Drawing.Size(930, 427);
            this.dataChamSoc.TabIndex = 6;
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
            // 
            // thangLB
            // 
            this.thangLB.AutoSize = true;
            this.thangLB.Location = new System.Drawing.Point(238, 63);
            this.thangLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thangLB.Name = "thangLB";
            this.thangLB.Size = new System.Drawing.Size(53, 17);
            this.thangLB.TabIndex = 3;
            this.thangLB.Text = "Tháng:";
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
            this.Load += new System.EventHandler(this.BcChamSoc_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamSoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label TieuDe;
        private System.Windows.Forms.Label thangLB;
        private System.Windows.Forms.DataGridView dataChamSoc;
        private System.Windows.Forms.Label namLB;
        private System.Windows.Forms.TextBox yearBT;
        private System.Windows.Forms.TextBox monthBT;
        private System.Windows.Forms.Button timKiemBT;
    }
}