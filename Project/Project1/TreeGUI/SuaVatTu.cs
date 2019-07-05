
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
    public partial class SuaVatTu : Form
    {
        private VattuBUS vattu;
        private GiaVatTuBUS giabus;
        private int macuoi;
        private List<VattuDTO> listvattu;
        public SuaVatTu()
        {
            InitializeComponent();
        }

        private void SuaVatTu_Load(object sender, EventArgs e)
        {
            vattu = new VattuBUS();
            giabus = new GiaVatTuBUS();
            listvattu = vattu.selectvattu();
            macuoi = listvattu[listvattu.Count - 1].MaVatTuPT;
        }

        private void suaBT_Click(object sender, EventArgs e)
        {
            if(maVatTuTB.Text == ""
                || diaChiTB.Text == ""
                || tenVatTuTB.Text == ""
                ||giaBT.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ trước khi thực hiện");
                return;
            }
            //1. Map data from GUI
            VattuDTO vt = new VattuDTO();
            GiaVatTuDTO gia = new GiaVatTuDTO();
            vt.MaVatTuPT = int.Parse(maVatTuTB.Text);
            vt.TenVatTuPT = tenVatTuTB.Text;
            vt.DiaChiBanPT = diaChiTB.Text;
            gia.MaGiaVatTuPT = int.Parse(maVatTuTB.Text);
            gia.MaVatTuPTGV = int.Parse(maVatTuTB.Text);
            gia.GiaVatTuPT  = int.Parse(giaBT.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = vattu.suavattu(vt);
            bool result1 = giabus.suaGia(gia);
            if (result == false || result1 == false)

                MessageBox.Show("Sửa Vật Tư thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Sửa Vật Tư thành công");
        }

        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
