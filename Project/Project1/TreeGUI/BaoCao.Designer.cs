namespace Project1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TTCayCanh = new System.Windows.Forms.Button();
            this.ChamSoc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TTCayCanh);
            this.panel1.Controls.Add(this.ChamSoc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 614);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TTCayCanh
            // 
            this.TTCayCanh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTCayCanh.Location = new System.Drawing.Point(581, 258);
            this.TTCayCanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TTCayCanh.Name = "TTCayCanh";
            this.TTCayCanh.Size = new System.Drawing.Size(312, 62);
            this.TTCayCanh.TabIndex = 1;
            this.TTCayCanh.Text = "Báo Cáo Trình Trạng Cây Cảnh";
            this.TTCayCanh.UseVisualStyleBackColor = true;
            this.TTCayCanh.Click += new System.EventHandler(this.TTCayCanh_Click);
            // 
            // ChamSoc
            // 
            this.ChamSoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChamSoc.Location = new System.Drawing.Point(193, 258);
            this.ChamSoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChamSoc.Name = "ChamSoc";
            this.ChamSoc.Size = new System.Drawing.Size(312, 62);
            this.ChamSoc.TabIndex = 0;
            this.ChamSoc.Text = "Báo Cáo Chi Phí Chăm Sóc";
            this.ChamSoc.UseVisualStyleBackColor = true;
            this.ChamSoc.Click += new System.EventHandler(this.ChamSoc_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1085, 614);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TTCayCanh;
        private System.Windows.Forms.Button ChamSoc;
    }
}
