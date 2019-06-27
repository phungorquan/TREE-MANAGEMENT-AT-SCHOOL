
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
        public ThemVatTu()
        {
            InitializeComponent();
        }

        private void ThemVatTu_Load(object sender, EventArgs e)
        {
            vattu = new VattuBUS();
            giabus = new GiaVatTuBUS();
        }

        private void ThemBT_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            VattuDTO vt = new VattuDTO();
            GiaVatTuDTO gia = new GiaVatTuDTO();
            vt.MaVatTuPT = int.Parse(maVatTuTB.Text);
            vt.TenVatTuPT = tenVatTuTB.Text;
            vt.DiaChiBanPT = diaChiTB.Text;
            gia.MaGiaVatTuPT = int.Parse(maVatTuTB.Text);
            gia.MaVatTuPTGV = int.Parse(maVatTuTB.Text);
            gia.GiaVatTuPT = int.Parse(giaBT.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = vattu.themvattu(vt);
            bool result1 = giabus.themGia(gia);
            if (result == false || result1 == false)

                MessageBox.Show("Thêm Cây Cảnh thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm Cây Cảnh thành công");
        }
    }
}
