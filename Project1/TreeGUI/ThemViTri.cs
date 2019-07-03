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
    public partial class ThemViTri : Form
    {
        private ViTriBUS vtBus;
        private int macuoi;
        private List<ViTriDTO> listVT;
        public ThemViTri()
        {
            InitializeComponent();
        }

        private void ThemBT_Click(object sender, EventArgs e)
        {
            if (tenvitriTB.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ trước khi thực hiện");
                return;
            }
            ViTriDTO vt = new ViTriDTO();
            vt.MaViTriPT = macuoi + 1;
            vt.TenViTriPT = tenvitriTB.Text;
            vt.SoLuongPT = 0;
            bool result = vtBus.themViTri(vt);
            if (result == false )

                MessageBox.Show("Thêm Vị Trí thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm Vị Trí thành công");
            this.Hide();
        }

        private void ThemViTri_Load(object sender, EventArgs e)
        {
            vtBus = new ViTriBUS();
            listVT = vtBus.selectVT();
            macuoi = listVT[listVT.Count() - 1].MaViTriPT;
        }

        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
