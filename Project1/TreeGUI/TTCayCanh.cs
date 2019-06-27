
using System;
using TreeBUS;
using TreeDTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project1
{
    public partial class TTCayCanh : Form
    {
        private CayCanhBUS cayBus;
        private LoaiCayBUS loaiBus;
        private TinhTrangBUS tinhTrangBus;
        private BCTinhTrangBUS TTBus;
        List<TinhTrangDTO> listTinhTrang;
        List<LoaiCayDTO> listloaiCay;
        List<CaycanhDTO> listCay;
        List<BCTinhTrangDTO> Result;
        public TTCayCanh()
        {

            InitializeComponent();
        }

        //Bao cáo tình trạng cây cảnh 


        private void TTCayCanh_Load(object sender, EventArgs e)
        {
            TTBus = new BCTinhTrangBUS();
            cayBus = new CayCanhBUS();
            loaiBus = new LoaiCayBUS();
            tinhTrangBus = new TinhTrangBUS();
            listTinhTrang = tinhTrangBus.selectTT();
            listloaiCay = loaiBus.selectLoaiCay();
            listCay = cayBus.select();
           
        }
        private bool XuLySoLieu()
        {
            
            Result = new List<BCTinhTrangDTO>();
            BCTinhTrangDTO Temp;
            if (yearBT.Text == "" || monthBT.Text == "")
            {
                return false;
            }
            else if (int.Parse(yearBT.Text) < 0)
            {
                return false;
            }
            else if (int.Parse(monthBT.Text) < 0 || int.Parse(monthBT.Text) >= 12)
            {
                return false;
            }

            DateTime ngayTim = new DateTime(int.Parse(yearBT.Text), int.Parse(monthBT.Text), 1);
            int i = 0;
            if (listCay == null || listCay.Count == 0)
            {
                return false;
            }
            for (i = 0; i< listCay.Count(); i++)
            {
                Temp = new BCTinhTrangDTO();
                Temp.MaCTTinhTrangCayPT = yearBT.Text + monthBT.Text + listCay[i].MaCayCanhPT;
                Temp.MaTinhTrangThangPT = yearBT.Text + monthBT.Text + i.ToString();
                Temp.MaCayPT = listCay[i].MaCayCanhPT;
                Temp.MaLoaiCayPT = listCay[i].MaLoaiCayCanhPT;
                Temp.MaTinhTrangPT = listCay[i].TinhTrangPT;
                Temp.TenCayPT = listCay[i].TenCayPT;
                Temp.TenLoaiCayPT = listloaiCay[listCay[i].MaLoaiCayCanhPT - 1].TenLoaiCayPT;
                Temp.TenTinhTrangPT = listTinhTrang[listCay[i].MaLoaiCayCanhPT - 1].TenTinhTrangPT;
                Temp.NgaytrongPT = listCay[i].NgayTrongPT;
                Result.Add(Temp);
            }

            return true;

        }

        private void kiemTraBT_Click(object sender, EventArgs e)
        {
            bool temp = XuLySoLieu();
            int i = 0;
            if(temp == false)
            {
                MessageBox.Show("Có lỗi nhận dự liệu hay khi lấy dữ liệu từ DataBase");
            }
            else
            {
                loadData_Vao_GridView(Result);
            }

        }
        private void loadData_Vao_GridView(List<BCTinhTrangDTO> listCay)
        {
     

            dataCayCanh.Columns.Clear();
            dataCayCanh.DataSource = null;

            dataCayCanh.AutoGenerateColumns = false;
            dataCayCanh.AllowUserToAddRows = false;
            dataCayCanh.DataSource = listCay;


            DataGridViewTextBoxColumn clTenCay = new DataGridViewTextBoxColumn();
            clTenCay.Name = "TenCay";
            clTenCay.HeaderText = "Tên Cây";
            clTenCay.DataPropertyName = "TenCayPT";
            dataCayCanh.Columns.Add(clTenCay);

            DataGridViewTextBoxColumn clLoaiCay = new DataGridViewTextBoxColumn();
            clLoaiCay.Name = "Loại Cây";
            clLoaiCay.HeaderText = "Loại Cây";
            clLoaiCay.DataPropertyName = "TenLoaiCayPT";

            dataCayCanh.Columns.Add(clLoaiCay);

            DataGridViewTextBoxColumn clNgayTrong = new DataGridViewTextBoxColumn();
            clNgayTrong.Name = "NgayTrong";
            clNgayTrong.HeaderText = "Ngày Trồng";
            clNgayTrong.DataPropertyName = "NgaytrongPT";
            dataCayCanh.Columns.Add(clNgayTrong);

            DataGridViewTextBoxColumn clTinhTrang = new DataGridViewTextBoxColumn();
            clTinhTrang.Name = "TinhTrang";
            clTinhTrang.HeaderText = "Tình Trạng";
            clTinhTrang.DataPropertyName = "TenTinhTrangPT";
            dataCayCanh.Columns.Add(clTinhTrang);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataCayCanh.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
