namespace Project1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Shutdown = new System.Windows.Forms.Button();
            this.buttonVatTu = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.buttonCayCanh = new System.Windows.Forms.Button();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userControl11 = new Project1.UserControl1();
            this.vattu1 = new Project1.Vattu();
            this.quanLyCayCanh1 = new Project1.QuanLyCayCanh();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.Shutdown);
            this.panel1.Controls.Add(this.buttonVatTu);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.buttonCayCanh);
            this.panel1.Controls.Add(this.buttonBaoCao);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 499);
            this.panel1.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(64, 3);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(45, 40);
            this.Minimize.TabIndex = 7;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SidePanel.ForeColor = System.Drawing.SystemColors.Menu;
            this.SidePanel.Location = new System.Drawing.Point(3, 222);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 46);
            this.SidePanel.TabIndex = 3;
            // 
            // Shutdown
            // 
            this.Shutdown.FlatAppearance.BorderSize = 0;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown.Image = ((System.Drawing.Image)(resources.GetObject("Shutdown.Image")));
            this.Shutdown.Location = new System.Drawing.Point(6, 3);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(45, 40);
            this.Shutdown.TabIndex = 1;
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVatTu
            // 
            this.buttonVatTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVatTu.FlatAppearance.BorderSize = 0;
            this.buttonVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVatTu.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVatTu.ForeColor = System.Drawing.Color.White;
            this.buttonVatTu.Image = ((System.Drawing.Image)(resources.GetObject("buttonVatTu.Image")));
            this.buttonVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVatTu.Location = new System.Drawing.Point(12, 216);
            this.buttonVatTu.Name = "buttonVatTu";
            this.buttonVatTu.Size = new System.Drawing.Size(163, 46);
            this.buttonVatTu.TabIndex = 6;
            this.buttonVatTu.Text = "Vật Tư";
            this.buttonVatTu.UseVisualStyleBackColor = true;
            this.buttonVatTu.Click += new System.EventHandler(this.buttonVatTu_Click);
            // 
            // setting
            // 
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(122, 3);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(45, 40);
            this.setting.TabIndex = 0;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // buttonCayCanh
            // 
            this.buttonCayCanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCayCanh.FlatAppearance.BorderSize = 0;
            this.buttonCayCanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCayCanh.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCayCanh.ForeColor = System.Drawing.Color.White;
            this.buttonCayCanh.Image = ((System.Drawing.Image)(resources.GetObject("buttonCayCanh.Image")));
            this.buttonCayCanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCayCanh.Location = new System.Drawing.Point(12, 164);
            this.buttonCayCanh.Name = "buttonCayCanh";
            this.buttonCayCanh.Size = new System.Drawing.Size(162, 46);
            this.buttonCayCanh.TabIndex = 5;
            this.buttonCayCanh.Text = "Cây Cảnh";
            this.buttonCayCanh.UseVisualStyleBackColor = true;
            this.buttonCayCanh.Click += new System.EventHandler(this.buttonCayCanh_Click);
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBaoCao.FlatAppearance.BorderSize = 0;
            this.buttonBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBaoCao.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaoCao.ForeColor = System.Drawing.Color.White;
            this.buttonBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("buttonBaoCao.Image")));
            this.buttonBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaoCao.Location = new System.Drawing.Point(12, 263);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Size = new System.Drawing.Size(162, 46);
            this.buttonBaoCao.TabIndex = 4;
            this.buttonBaoCao.Text = "Lập Báo Cáo";
            this.buttonBaoCao.UseVisualStyleBackColor = true;
            this.buttonBaoCao.Click += new System.EventHandler(this.buttonBaoCao_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 175);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.userControl11);
            this.panel4.Controls.Add(this.vattu1);
            this.panel4.Controls.Add(this.quanLyCayCanh1);
            this.panel4.Location = new System.Drawing.Point(175, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 499);
            this.panel4.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(814, 499);
            this.userControl11.TabIndex = 2;
            // 
            // vattu1
            // 
            this.vattu1.Location = new System.Drawing.Point(0, 0);
            this.vattu1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vattu1.Name = "vattu1";
            this.vattu1.Size = new System.Drawing.Size(814, 500);
            this.vattu1.TabIndex = 1;
            // 
            // quanLyCayCanh1
            // 
            this.quanLyCayCanh1.Location = new System.Drawing.Point(-2, 0);
            this.quanLyCayCanh1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quanLyCayCanh1.Name = "quanLyCayCanh1";
            this.quanLyCayCanh1.Size = new System.Drawing.Size(814, 500);
            this.quanLyCayCanh1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 499);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonVatTu;
        private System.Windows.Forms.Button buttonCayCanh;
        private System.Windows.Forms.Button buttonBaoCao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel panel4;
        private QuanLyCayCanh quanLyCayCanh1;
        private Vattu vattu1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button Minimize;
    }
}

