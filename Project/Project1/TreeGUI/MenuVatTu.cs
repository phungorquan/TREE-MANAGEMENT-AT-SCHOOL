using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class MenuVatTu : Form
    {
        public MenuVatTu()
        {
            InitializeComponent();
        }

        private void ThemVatTu_Click(object sender, EventArgs e)
        {
            ThemVatTu f = new ThemVatTu();
            f.ShowDialog();
        }

        private void SuaVatTu_Click(object sender, EventArgs e)
        {
            SuaVatTu f = new SuaVatTu();
            f.ShowDialog();
        }

        private void XoaVatTu_Click(object sender, EventArgs e)
        {
            XoaVatTu f = new XoaVatTu();
            f.ShowDialog();
        }

        private void thayDoiThamSo_Click(object sender, EventArgs e)
        {
            Setting f = new Setting();
            f.ShowDialog();
        }

        private void themViTriBT_Click(object sender, EventArgs e)
        {
            ThemViTri f = new ThemViTri();
            f.ShowDialog();
        }

        private void suaViTri_Click(object sender, EventArgs e)
        {
            SuaViTri f = new SuaViTri();
            f.ShowDialog();
        }

        private void xoaViTri_Click(object sender, EventArgs e)
        {
            XoaViTri f = new XoaViTri();
            f.ShowDialog();
        }
    }
}
