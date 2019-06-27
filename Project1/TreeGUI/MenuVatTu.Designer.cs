namespace Project1
{
    partial class MenuVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVatTu));
            this.ThemVatTu = new System.Windows.Forms.Button();
            this.SuaVatTu = new System.Windows.Forms.Button();
            this.XoaVatTu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThemVatTu
            // 
            this.ThemVatTu.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemVatTu.Location = new System.Drawing.Point(27, 43);
            this.ThemVatTu.Name = "ThemVatTu";
            this.ThemVatTu.Size = new System.Drawing.Size(115, 39);
            this.ThemVatTu.TabIndex = 0;
            this.ThemVatTu.Text = "Thêm Vật Tư";
            this.ThemVatTu.UseVisualStyleBackColor = true;
            this.ThemVatTu.Click += new System.EventHandler(this.ThemVatTu_Click);
            // 
            // SuaVatTu
            // 
            this.SuaVatTu.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaVatTu.Location = new System.Drawing.Point(26, 127);
            this.SuaVatTu.Name = "SuaVatTu";
            this.SuaVatTu.Size = new System.Drawing.Size(115, 39);
            this.SuaVatTu.TabIndex = 1;
            this.SuaVatTu.Text = "Sửa Vật Tư";
            this.SuaVatTu.UseVisualStyleBackColor = true;
            this.SuaVatTu.Click += new System.EventHandler(this.SuaVatTu_Click);
            // 
            // XoaVatTu
            // 
            this.XoaVatTu.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaVatTu.Location = new System.Drawing.Point(27, 209);
            this.XoaVatTu.Name = "XoaVatTu";
            this.XoaVatTu.Size = new System.Drawing.Size(115, 39);
            this.XoaVatTu.TabIndex = 2;
            this.XoaVatTu.Text = "Xóa Vật Tư";
            this.XoaVatTu.UseVisualStyleBackColor = true;
            this.XoaVatTu.Click += new System.EventHandler(this.XoaVatTu_Click);
            // 
            // MenuVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 292);
            this.Controls.Add(this.XoaVatTu);
            this.Controls.Add(this.SuaVatTu);
            this.Controls.Add(this.ThemVatTu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Vật Tư";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThemVatTu;
        private System.Windows.Forms.Button SuaVatTu;
        private System.Windows.Forms.Button XoaVatTu;
    }
}