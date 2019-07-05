using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChamSoc_Click(object sender, EventArgs e)
        {
            BcChamSoc baocao = new BcChamSoc();
            baocao.ShowDialog();
        }

        private void TTCayCanh_Click(object sender, EventArgs e)
        {
            TTCayCanh bbCayCanh = new TTCayCanh();
            bbCayCanh.ShowDialog();
        }
    }
}
