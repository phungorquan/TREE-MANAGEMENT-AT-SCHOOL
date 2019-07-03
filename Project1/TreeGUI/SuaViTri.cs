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
    public partial class SuaViTri : Form
    {
        private ViTriBUS VTbus;
        private int macuoi;
        private bool giatri;
        private List<ViTriDTO> listVT;
        public SuaViTri()
        {
            InitializeComponent();
        }

        private void ThemBT_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (maViTriTB.Text == ""
               || tenvitriTB.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ trước khi thực hiện");
                return;
            }
            //1. Map data from GUI
            ViTriDTO vt = new ViTriDTO();

            for (i = 0; i < listVT.Count(); i++)
            {
                if (listVT[i].MaViTriPT == int.Parse(maViTriTB.Text))
                {
                    giatri = true;
                    break;
                }
                else
                {
                    giatri = false;
                }
            }
            if(giatri == false)
            {
                MessageBox.Show("Sửa Vị Trí thất bại. Vui lòng kiểm tra lại dữ liệu");
                return;
            }

            vt.MaViTriPT = int.Parse(maViTriTB.Text);
            vt.TenViTriPT = tenvitriTB.Text;
            vt.SoLuongPT = listVT[i].SoLuongPT;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = VTbus.suaViTri(vt);
            if (result == false )
                MessageBox.Show("Sửa Vị Trí thất bại. Vui lòng kiểm tra lại dữ liệu");

            else
                MessageBox.Show("Sửa Vị Trí  thành công");
            this.Hide();
        }

        private void SuaViTri_Load(object sender, EventArgs e)
        {
            VTbus = new ViTriBUS();
            listVT = VTbus.selectVT();
            macuoi = listVT[listVT.Count() - 1].MaViTriPT;
        }

        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
