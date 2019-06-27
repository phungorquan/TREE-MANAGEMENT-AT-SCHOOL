using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeBUS;
using TreeDTO;

namespace Project1
{
    public partial class XoaVatTu : Form
    {
        private VattuBUS vattu;
        private GiaVatTuBUS giabus;
        public XoaVatTu()
        {
            InitializeComponent();
        }

        private void XoaVatTu_Load(object sender, EventArgs e)
        {
            vattu = new VattuBUS();
            giabus = new GiaVatTuBUS();
        }

        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void XoaBT_Click(object sender, EventArgs e)
        {
            VattuDTO vt = new VattuDTO();
            GiaVatTuDTO gia = new GiaVatTuDTO();
            vt.MaVatTuPT = int.Parse(maVatTuTB.Text);
            gia.MaVatTuPTGV = int.Parse(maVatTuTB.Text);
            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = vattu.xoavattu(vt);
            bool kq1 = giabus.xoaGia(gia);
            if (kq == false || kq1 == false )
                MessageBox.Show("Xóa thông tin cây thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Xóa thông tin cây thành công");
        }
    }
}
