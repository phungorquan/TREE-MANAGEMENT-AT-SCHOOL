namespace Project1
{
    partial class QuanLyCayCanh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyCayCanh));
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.load = new System.Windows.Forms.Button();
            this.LapLich = new System.Windows.Forms.Button();
            this.MenuCay = new System.Windows.Forms.Button();
            this.LabelTieude = new System.Windows.Forms.Label();
            this.ToolTipThemCay = new System.Windows.Forms.ToolTip(this.components);
            this.Dscay = new System.Windows.Forms.DataGridView();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dscay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTieuDe.Controls.Add(this.load);
            this.panelTieuDe.Controls.Add(this.LapLich);
            this.panelTieuDe.Controls.Add(this.MenuCay);
            this.panelTieuDe.Controls.Add(this.LabelTieude);
            this.panelTieuDe.Location = new System.Drawing.Point(3, 2);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1082, 62);
            this.panelTieuDe.TabIndex = 1;
            // 
            // load
            // 
            this.load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load.BackgroundImage")));
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(907, 11);
            this.load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(42, 40);
            this.load.TabIndex = 5;
            this.ToolTipThemCay.SetToolTip(this.load, "Lập Lịch");
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // LapLich
            // 
            this.LapLich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LapLich.BackgroundImage")));
            this.LapLich.FlatAppearance.BorderSize = 0;
            this.LapLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LapLich.Location = new System.Drawing.Point(964, 11);
            this.LapLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LapLich.Name = "LapLich";
            this.LapLich.Size = new System.Drawing.Size(42, 40);
            this.LapLich.TabIndex = 4;
            this.ToolTipThemCay.SetToolTip(this.LapLich, "Lập Lịch");
            this.LapLich.UseVisualStyleBackColor = true;
            this.LapLich.Click += new System.EventHandler(this.LapLich_Click_1);
            // 
            // MenuCay
            // 
            this.MenuCay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuCay.BackgroundImage")));
            this.MenuCay.FlatAppearance.BorderSize = 0;
            this.MenuCay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuCay.Location = new System.Drawing.Point(1025, 11);
            this.MenuCay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuCay.Name = "MenuCay";
            this.MenuCay.Size = new System.Drawing.Size(42, 40);
            this.MenuCay.TabIndex = 3;
            this.ToolTipThemCay.SetToolTip(this.MenuCay, "Menu");
            this.MenuCay.UseVisualStyleBackColor = true;
            this.MenuCay.Click += new System.EventHandler(this.MenuCay_Click);
            // 
            // LabelTieude
            // 
            this.LabelTieude.AutoSize = true;
            this.LabelTieude.Font = new System.Drawing.Font("Calibri", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTieude.Location = new System.Drawing.Point(348, 7);
            this.LabelTieude.Name = "LabelTieude";
            this.LabelTieude.Size = new System.Drawing.Size(343, 46);
            this.LabelTieude.TabIndex = 0;
            this.LabelTieude.Text = "Danh Sách Cây Cảnh";
            // 
            // ToolTipThemCay
            // 
            this.ToolTipThemCay.BackColor = System.Drawing.Color.Ivory;
            this.ToolTipThemCay.ForeColor = System.Drawing.Color.Ivory;
            // 
            // Dscay
            // 
            this.Dscay.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Dscay.Location = new System.Drawing.Point(3, 58);
            this.Dscay.Name = "Dscay";
            this.Dscay.RowTemplate.Height = 24;
            this.Dscay.Size = new System.Drawing.Size(1082, 554);
            this.Dscay.TabIndex = 2;
            // 
            // QuanLyCayCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dscay);
            this.Controls.Add(this.panelTieuDe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyCayCanh";
            this.Size = new System.Drawing.Size(1085, 615);
            this.Load += new System.EventHandler(this.QuanLyCayCanh_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dscay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Button MenuCay;
        private System.Windows.Forms.Label LabelTieude;
        private System.Windows.Forms.Button LapLich;
        private System.Windows.Forms.ToolTip ToolTipThemCay;
        private System.Windows.Forms.DataGridView Dscay;
        private System.Windows.Forms.Button load;
    }
}
