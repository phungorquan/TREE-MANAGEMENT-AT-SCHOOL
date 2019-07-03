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
        private CayCanhBUS cayBus;
        private ThamSoBUS thamso;
        private List<ThamSoDTO> tsDTO;
        private List<ViTriDTO> listViTri;
        private List<CaycanhDTO> listcayCanh;
        private ViTriBUS ViTriBus;
        public XoaCay()
        {
            InitializeComponent();
        }


        private void XoaCay_Load(object sender, EventArgs e)
        {
            thamso = new ThamSoBUS();
            cayBus = new CayCanhBUS();
            ViTriBus = new ViTriBUS();
            tsDTO = thamso.selectThamSo();
            listViTri = ViTriBus.selectVT();
            listcayCanh = cayBus.select();
        }
        private void XoaButton_Click(object sender, EventArgs e)
        {
            int i = 0, vitri = 0;
            if (MaCayTB.Text == "")
            {
                MessageBox.Show("Vui Lòng nhận dự liệu trước khi xóa");
                return;
            }
            //1. Map data from GUI
            CaycanhDTO cayDTO = new CaycanhDTO();
            cayDTO.MaCayCanhPT = MaCayTB.Text;

            //2. Kiểm tra data hợp lệ or not
            for (i = 0; i < listcayCanh.Count(); i++)
            {
                if (listcayCanh[i].MaCayCanhPT == cayDTO.MaCayCanhPT)
                {
                    vitri = listcayCanh[i].MaViTriPT;
                    break;
                }
            }
            for (i = 0; i < listViTri.Count(); i++)
            {
                if (vitri == listViTri[i].MaViTriPT)
                {
                    ViTriDTO suavt = new ViTriDTO();
                    suavt.MaViTriPT = listViTri[i].MaViTriPT;
                    suavt.TenViTriPT = listViTri[i].TenViTriPT;
                    suavt.SoLuongPT = listViTri[i].SoLuongPT - 1;
                    bool result1 = ViTriBus.suaViTri(suavt);
                    if (result1 == false)
                    {
                        MessageBox.Show("có vấn đề đang xảy ra");
                    }
                    break;
                }
            }


            
            //3. Thêm vào DB
            bool kq = cayBus.xoaCay(cayDTO);
            if (kq == false)
                MessageBox.Show("Xóa thông tin cây thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Xóa thông tin cây thành công");
        }
        //------------------------------------------------------------//


        private void Huy_Click(object sender, EventArgs e)
        {

        }

    
      
    }
}
