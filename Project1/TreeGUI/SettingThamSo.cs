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
    public partial class Setting : Form
    {
        ThamSoBUS TSbus;
        List<ThamSoDTO> ListThamSo;
        int count = 0;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            TSbus = new ThamSoBUS();
            
            Xuly();
        }
        private void Xuly()
        {
            ListThamSo = TSbus.selectThamSo();
            TienTB.ResetText();
            CayTB.ResetText();
            TienTB.AppendText(ListThamSo[0].SoTienToiDaPT.ToString());
            CayTB.AppendText(ListThamSo[0].SoCayToiDaPT.ToString());
        }

        private void Hủy_Click(object sender, EventArgs e)
        {
            TienTB.ResetText();
            CayTB.ResetText();
            TienTB.AppendText(ListThamSo[0].SoTienToiDaPT.ToString());
            CayTB.AppendText(ListThamSo[0].SoCayToiDaPT.ToString());
            this.Hide();
        }

        private void suaDoiBT_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                TienTB.ReadOnly = false;
                CayTB.ReadOnly = false;
                count++;
                MessageBox.Show("Bắt Đầu Chỉnh Sửa");
                return;
            }
            if(count == 1)
            {
                TienTB.ReadOnly = true;
                CayTB.ReadOnly = true;
                count = 0;
                if(TienTB.Text == "" || CayTB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu");
                    return;
                }
                ThamSoDTO Thamso = new ThamSoDTO();
                Thamso.SoTienToiDaPT = int.Parse(TienTB.Text);
                Thamso.SoCayToiDaPT = int.Parse(CayTB.Text);

                //3. Thêm vào DB
                bool kq = TSbus.suaThamSo(Thamso);
                if (kq == false)
                    MessageBox.Show("Sửa thông tin Tham Số thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Cập nhận thông tin Tham Số thành công");
                Xuly();
                count = 0;
            }
        }
    }
}
