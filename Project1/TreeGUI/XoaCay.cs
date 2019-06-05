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
    public partial class XoaCay : Form
    {
        private CayCanhBUS CayBus;
        public XoaCay()
        {
            InitializeComponent();
        }

     

        private void XoaButton_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            CaycanhDTO cay = new CaycanhDTO();
            cay.MaCayCanhPT = MaCayTB.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = CayBus.xoaCay(cay);
            if (kq == false)
                MessageBox.Show("Xóa thông tin cây thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Xóa thông tin cây thành công");
        }
        //------------------------------------------------------------//


        private void Huy_Click(object sender, EventArgs e)
        {

        }

    
        private void XoaCay_Load(object sender, EventArgs e)
        {
            CayBus = new CayCanhBUS();
        }
    }
}
