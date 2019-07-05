using System;
using TreeBUS;
using TreeDTO;
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
    public partial class XoaViTri : Form
    {
        private ViTriBUS VTbus;
        public XoaViTri()
        {
            InitializeComponent();
        }

        private void XoaViTri_Load(object sender, EventArgs e)
        {
            VTbus = new ViTriBUS();
        }

        private void XoaBT_Click(object sender, EventArgs e)
        {
            if (maViTriTB.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ trước khi thực hiện");
                return;
            }
            ViTriDTO VT = new ViTriDTO();
            VT.MaViTriPT = int.Parse(maViTriTB.Text);
            VTbus.xoaViTri(VT);
            bool result = VTbus.xoaViTri(VT); ;
            if (result == false)
                MessageBox.Show("Xóa thông tin vị trí thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Xóa thông tin vị trí thành công");
            this.Hide();
        }

        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
