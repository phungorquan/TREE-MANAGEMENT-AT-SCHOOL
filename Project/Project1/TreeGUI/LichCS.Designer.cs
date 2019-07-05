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
            this.timkiemBT = new System.Windows.Forms.Button();
            this.dgvLich = new System.Windows.Forms.DataGridView();
            this.dateTimeLaplich = new System.Windows.Forms.DateTimePicker();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maCayCanhtb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timkiemBT);
            this.panel1.Controls.Add(this.dgvLich);
            this.panel1.Controls.Add(this.dateTimeLaplich);
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maCayCanhtb);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 565);
            this.panel1.TabIndex = 4;
            // 
            // timkiemBT
            // 
            this.timkiemBT.Location = new System.Drawing.Point(353, 93);
            this.timkiemBT.Name = "timkiemBT";
            this.timkiemBT.Size = new System.Drawing.Size(244, 30);
            this.timkiemBT.TabIndex = 8;
            this.timkiemBT.Text = "Tìm Kiếm";
            this.timkiemBT.UseVisualStyleBackColor = true;
            this.timkiemBT.Click += new System.EventHandler(this.timkiemBT_Click);
            // 
            // dgvLich
            // 
            this.dgvLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLich.Location = new System.Drawing.Point(3, 129);
            this.dgvLich.Name = "dgvLich";
            this.dgvLich.RowTemplate.Height = 24;
            this.dgvLich.Size = new System.Drawing.Size(987, 436);
            this.dgvLich.TabIndex = 7;
            // 
            // dateTimeLaplich
            // 
            this.dateTimeLaplich.Location = new System.Drawing.Point(619, 65);
            this.dateTimeLaplich.Name = "dateTimeLaplich";
            this.dateTimeLaplich.Size = new System.Drawing.Size(350, 22);
            this.dateTimeLaplich.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Cây Cảnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Lập Lịch:";
            // 
            // maCayCanhtb
            // 
            this.maCayCanhtb.Location = new System.Drawing.Point(126, 65);
            this.maCayCanhtb.Margin = new System.Windows.Forms.Padding(4);
            this.maCayCanhtb.Name = "maCayCanhtb";
            this.maCayCanhtb.Size = new System.Drawing.Size(334, 22);
            this.maCayCanhtb.TabIndex = 0;
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
            this.Text = "Lịch Chăm Sóc";
            this.Load += new System.EventHandler(this.LichCS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maCayCanhtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeLaplich;
        private System.Windows.Forms.Button timkiemBT;
        private System.Windows.Forms.DataGridView dgvLich;
    }
}