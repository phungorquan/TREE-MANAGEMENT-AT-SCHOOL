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
    public partial class MenuCay : Form
    {
        public MenuCay()
        {
            InitializeComponent();
        }

        private void XoaCay_Click(object sender, EventArgs e)
        {
            XoaCay f = new XoaCay();
            f.ShowDialog();
                
        }

        private void ThemCay_Click(object sender, EventArgs e)
        {
            ThemCay f = new ThemCay();
            f.ShowDialog();
        }
        private void SuaCay_Click_1(object sender, EventArgs e)
        {
            SuaCay f = new SuaCay();
            f.ShowDialog();
        }

        private void LenLich_Click(object sender, EventArgs e)
        {
            LenLich f = new LenLich();
            f.ShowDialog();
        }
    }
}
