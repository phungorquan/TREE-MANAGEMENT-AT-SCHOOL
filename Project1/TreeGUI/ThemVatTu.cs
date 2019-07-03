
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
    public partial class ThemVatTu : Form
    {
        private VattuBUS vattu;
        private GiaVatTuBUS giabus;
        private int macuoi;
        private List<VattuDTO> listvattu;
        public ThemVatTu()
        {
            InitializeComponent();
        }

        private void ThemVatTu_Load(object sender, EventArgs e)
        {
            vattu = new VattuBUS();
            giabus = new GiaVatTuBUS();
            listvattu = vattu.selectvattu();
            macuoi = listvattu[listvattu.Count - 1].MaVatTuPT;
        }

        private void ThemBT_Click(object sender, EventArgs e)
        {
            if ( diaChiTB.Text == ""
              || tenVatTuTB.Text == ""
              || giaBT.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ trước khi thực hiện");
                return;
            }
            //1. Map data from GUI
            VattuDTO vt = new VattuDTO();
            GiaVatTuDTO gia = new GiaVatTuDTO();
            vt.MaVatTuPT = macuoi + 1;
            vt.TenVatTuPT = tenVatTuTB.Text;
            vt.DiaChiBanPT = diaChiTB.Text;
            gia.MaGiaVatTuPT = macuoi + 1;
            gia.MaVatTuPTGV = macuoi + 1;
            gia.GiaVatTuPT = int.Parse(giaBT.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = vattu.themvattu(vt);
            bool result1 = giabus.themGia(gia);
            if (result == false || result1 == false)

                MessageBox.Show("Thêm Vật Tư thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm Vật Tư thành công");
            this.Hide();
        }

        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
