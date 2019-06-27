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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataCayCanh = new System.Windows.Forms.DataGridView();
            this.namLB = new System.Windows.Forms.Label();
            this.yearBT = new System.Windows.Forms.TextBox();
            this.monthBT = new System.Windows.Forms.TextBox();
            this.kiemTraBT = new System.Windows.Forms.Button();
            this.thangLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCayCanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Báo Cáo Tình Trạng Cây Cảnh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataCayCanh);
            this.panel1.Controls.Add(this.namLB);
            this.panel1.Controls.Add(this.yearBT);
            this.panel1.Controls.Add(this.monthBT);
            this.panel1.Controls.Add(this.kiemTraBT);
            this.panel1.Controls.Add(this.thangLB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 491);
            this.panel1.TabIndex = 5;
            // 
            // dataCayCanh
            // 
            this.dataCayCanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCayCanh.Location = new System.Drawing.Point(0, 87);
            this.dataCayCanh.Name = "dataCayCanh";
            this.dataCayCanh.RowTemplate.Height = 24;
            this.dataCayCanh.Size = new System.Drawing.Size(825, 401);
            this.dataCayCanh.TabIndex = 16;
            // 
            // namLB
            // 
            this.namLB.AutoSize = true;
            this.namLB.Location = new System.Drawing.Point(368, 54);
            this.namLB.Name = "namLB";
            this.namLB.Size = new System.Drawing.Size(41, 17);
            this.namLB.TabIndex = 15;
            this.namLB.Text = "Năm:";
            // 
            // yearBT
            // 
            this.yearBT.Location = new System.Drawing.Point(415, 51);
            this.yearBT.Name = "yearBT";
            this.yearBT.Size = new System.Drawing.Size(95, 22);
            this.yearBT.TabIndex = 14;
            // 
            // monthBT
            // 
            this.monthBT.Location = new System.Drawing.Point(261, 51);
            this.monthBT.Name = "monthBT";
            this.monthBT.Size = new System.Drawing.Size(89, 22);
            this.monthBT.TabIndex = 13;
            // 
            // kiemTraBT
            // 
            this.kiemTraBT.Location = new System.Drawing.Point(530, 48);
            this.kiemTraBT.Name = "kiemTraBT";
            this.kiemTraBT.Size = new System.Drawing.Size(100, 29);
            this.kiemTraBT.TabIndex = 12;
            this.kiemTraBT.Text = "Kiểm Tra";
            this.kiemTraBT.UseVisualStyleBackColor = true;
            this.kiemTraBT.Click += new System.EventHandler(this.kiemTraBT_Click);
            // 
            // thangLB
            // 
            this.thangLB.AutoSize = true;
            this.thangLB.Location = new System.Drawing.Point(201, 54);
            this.thangLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thangLB.Name = "thangLB";
            this.thangLB.Size = new System.Drawing.Size(53, 17);
            this.thangLB.TabIndex = 11;
            this.thangLB.Text = "Tháng:";
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
            this.Load += new System.EventHandler(this.TTCayCanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCayCanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label namLB;
        private System.Windows.Forms.TextBox yearBT;
        private System.Windows.Forms.TextBox monthBT;
        private System.Windows.Forms.Button kiemTraBT;
        private System.Windows.Forms.Label thangLB;
        private System.Windows.Forms.DataGridView dataCayCanh;
    }
}