namespace Project1
{
    partial class MenuCay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCay));
            this.ThemCay = new System.Windows.Forms.Button();
            this.XoaCay = new System.Windows.Forms.Button();
            this.SuaCay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThemCay
            // 
            this.ThemCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemCay.Location = new System.Drawing.Point(94, 75);
            this.ThemCay.Name = "ThemCay";
            this.ThemCay.Size = new System.Drawing.Size(172, 58);
            this.ThemCay.TabIndex = 0;
            this.ThemCay.Text = "Thêm Cây Mới";
            this.ThemCay.UseVisualStyleBackColor = true;
            this.ThemCay.Click += new System.EventHandler(this.ThemCay_Click);
            // 
            // XoaCay
            // 
            this.XoaCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaCay.Location = new System.Drawing.Point(94, 178);
            this.XoaCay.Name = "XoaCay";
            this.XoaCay.Size = new System.Drawing.Size(172, 58);
            this.XoaCay.TabIndex = 1;
            this.XoaCay.Text = "Xóa Cây";
            this.XoaCay.UseVisualStyleBackColor = true;
            this.XoaCay.Click += new System.EventHandler(this.XoaCay_Click);
            // 
            // SuaCay
            // 
            this.SuaCay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaCay.Location = new System.Drawing.Point(94, 278);
            this.SuaCay.Name = "SuaCay";
            this.SuaCay.Size = new System.Drawing.Size(172, 58);
            this.SuaCay.TabIndex = 2;
            this.SuaCay.Text = "Cập Nhận Thông Tin Cây";
            this.SuaCay.UseVisualStyleBackColor = true;
            this.SuaCay.Click += new System.EventHandler(this.SuaCay_Click_1);
            // 
            // MenuCay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(354, 415);
            this.Controls.Add(this.SuaCay);
            this.Controls.Add(this.XoaCay);
            this.Controls.Add(this.ThemCay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cây Cảnh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThemCay;
        private System.Windows.Forms.Button XoaCay;
        private System.Windows.Forms.Button SuaCay;
    }
}