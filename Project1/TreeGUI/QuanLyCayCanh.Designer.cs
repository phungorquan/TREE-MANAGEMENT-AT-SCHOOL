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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyCayCanh));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caycanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loại = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.LabelTieude = new System.Windows.Forms.Label();
            this.ToolTipThemCay = new System.Windows.Forms.ToolTip(this.components);
            this.LapLich = new System.Windows.Forms.Button();
            this.MenuCay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Caycanh,
            this.Loại,
            this.Vitri,
            this.TrinhTrang});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 549);
            this.dataGridView1.TabIndex = 0;
            this.ToolTipThemCay.SetToolTip(this.dataGridView1, "Thêm Cây");
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Caycanh
            // 
            this.Caycanh.HeaderText = "Cây Cảnh";
            this.Caycanh.Name = "Caycanh";
            // 
            // Loại
            // 
            this.Loại.HeaderText = "Loại";
            this.Loại.Name = "Loại";
            // 
            // Vitri
            // 
            this.Vitri.HeaderText = "Vị Trí";
            this.Vitri.Name = "Vitri";
            // 
            // TrinhTrang
            // 
            this.TrinhTrang.HeaderText = "Tình Trạng";
            this.TrinhTrang.Name = "TrinhTrang";
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTieuDe.Controls.Add(this.LapLich);
            this.panelTieuDe.Controls.Add(this.MenuCay);
            this.panelTieuDe.Controls.Add(this.LabelTieude);
            this.panelTieuDe.Location = new System.Drawing.Point(3, 2);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1082, 62);
            this.panelTieuDe.TabIndex = 1;
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
            this.ToolTipThemCay.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
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
            this.LapLich.Click += new System.EventHandler(this.LapLich_Click);
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
            // QuanLyCayCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTieuDe);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyCayCanh";
            this.Size = new System.Drawing.Size(1085, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caycanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loại;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhTrang;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Button MenuCay;
        private System.Windows.Forms.Label LabelTieude;
        private System.Windows.Forms.Button LapLich;
        private System.Windows.Forms.ToolTip ToolTipThemCay;
    }
}
