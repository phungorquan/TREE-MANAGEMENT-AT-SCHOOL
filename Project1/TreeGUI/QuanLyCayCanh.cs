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
    public partial class QuanLyCayCanh : UserControl
    {
        public QuanLyCayCanh()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

 //--------------------------------------------------------------------------------//
 //2 function callback button ở trên cùng
        private void MenuCay_Click(object sender, EventArgs e)
        {
            MenuCay f = new MenuCay();
            f.ShowDialog();
        }
        //Lap Lich Button
        private void LapLich_Click(object sender, EventArgs e)
        {
            LichCS lich = new LichCS();
            lich.ShowDialog();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            ThemCay f = new ThemCay();
            f.ShowDialog();
        }
        private void Suabutton_Click(object sender, EventArgs e)
        {
            ThemCay f = new ThemCay();
            f.ShowDialog();
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    
    }
}
