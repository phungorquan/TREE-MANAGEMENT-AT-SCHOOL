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
            this.MaCayTB = new System.Windows.Forms.TextBox();
            this.TenCay = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.Huy = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaCayTB
            // 
            this.MaCayTB.Location = new System.Drawing.Point(156, 119);
            this.MaCayTB.Margin = new System.Windows.Forms.Padding(4);
            this.MaCayTB.Name = "MaCayTB";
            this.MaCayTB.Size = new System.Drawing.Size(332, 22);
            this.MaCayTB.TabIndex = 13;
          
            // 
            // TenCay
            // 
            this.TenCay.AutoSize = true;
            this.TenCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCay.Location = new System.Drawing.Point(40, 119);
            this.TenCay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenCay.Name = "TenCay";
            this.TenCay.Size = new System.Drawing.Size(77, 24);
            this.TenCay.TabIndex = 19;
            this.TenCay.Text = "Mã Cây:";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTieuDe.Location = new System.Drawing.Point(128, 43);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(271, 41);
            this.labelTieuDe.TabIndex = 25;
            this.labelTieuDe.Text = "Xóa Thông Tin Cây";
   
            // 
            // Huy
            // 
            this.Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Huy.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huy.Location = new System.Drawing.Point(303, 195);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(160, 32);
            this.Huy.TabIndex = 27;
            this.Huy.Text = "Hủy";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            this.Huy.Leave += new System.EventHandler(this.Huy_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(65, 195);
            this.XoaButton.Margin = new System.Windows.Forms.Padding(4);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(160, 32);
            this.XoaButton.TabIndex = 27;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.XoaButton);
            this.panel1.Controls.Add(this.Huy);
            this.panel1.Controls.Add(this.labelTieuDe);
            this.panel1.Controls.Add(this.TenCay);
            this.panel1.Controls.Add(this.MaCayTB);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 271);
            this.panel1.TabIndex = 2;
            // 
            // XoaCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 289);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XoaCay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa Cây";
            this.Load += new System.EventHandler(this.XoaCay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MaCayTB;
        private System.Windows.Forms.Label TenCay;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Panel panel1;
    }
}