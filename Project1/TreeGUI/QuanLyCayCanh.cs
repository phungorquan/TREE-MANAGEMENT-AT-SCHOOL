using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeBUS;
using TreeDTO;
namespace Project1
{
    public partial class QuanLyCayCanh : UserControl
    {
        private ViTriBUS vtBus;
        private LoaiCayBUS loaiBus;
        private CayCanhBUS cayBus;
        private TinhTrangBUS tinhtrangBus;
        private List<LoaiCayDTO> listloai;
        private List<ViTriDTO> listVT;
        private List<TinhTrangDTO> listtinhtrang;
        public QuanLyCayCanh()
        {
            InitializeComponent();
            
        }
        private void QuanLyCayCanh_Load(object sender, EventArgs e)
        {
            vtBus = new ViTriBUS();
            loaiBus = new LoaiCayBUS();
            cayBus = new CayCanhBUS();
            tinhtrangBus = new TinhTrangBUS();
            listtinhtrang = tinhtrangBus.selectTT();
            listloai = loaiBus.selectLoaiCay();
            listVT = vtBus.selectVT();
            loadData_Vao_GridView();

        }
        //--------------------------------------------------------------------------------//
        //2 function callback button ở trên cùng
        private void MenuCay_Click(object sender, EventArgs e)
        {
            MenuCay f = new MenuCay();
            f.ShowDialog();
        }
        //Lap Lich Button



        private void loadData_Vao_GridView()
        {
            List<CaycanhDTO> listCayCanh = cayBus.select();
            int i = 0, j = 0;
           
            if (listCayCanh == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            for(i = 0; i < listCayCanh.Count(); i++)
            {
                listCayCanh[i].TenTinhTrangPT = listtinhtrang[listCayCanh[i].TinhTrangPT - 1].TenTinhTrangPT;
                listCayCanh[i].TenLoaiPT = listloai[listCayCanh[i].MaLoaiCayCanhPT - 1].TenLoaiCayPT;
                for (j = 0; j < listVT.Count(); j++)
                {
                    if(listVT[j].MaViTriPT == listCayCanh[i].MaViTriPT)
                    {
                        listCayCanh[i].TenViTriPT = listVT[j].TenViTriPT;
                        break;
                    }
                }
            
            }
            Dscay.Columns.Clear();
            Dscay.DataSource = null;

            Dscay.AutoGenerateColumns = false;
            Dscay.AllowUserToAddRows = false;
            Dscay.DataSource = listCayCanh;


            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "TenCay";
            clTen.HeaderText = "Tên Cay";
            clTen.DataPropertyName = "TenCayPT";
            Dscay.Columns.Add(clTen);

            DataGridViewTextBoxColumn clloaicay = new DataGridViewTextBoxColumn();
            clloaicay.Name = "LoaiCayCanh";
            clloaicay.HeaderText = "Loại Cây";
            clloaicay.DataPropertyName = "TenLoaiPT";
            Dscay.Columns.Add(clloaicay);


            DataGridViewTextBoxColumn clvitri = new DataGridViewTextBoxColumn();
            clvitri.Name = "ViTri";
            clvitri.HeaderText = "Vị Trí";
            clvitri.DataPropertyName = "TenViTriPT";
            Dscay.Columns.Add(clvitri);

            DataGridViewTextBoxColumn cltinhTrang = new DataGridViewTextBoxColumn();
            cltinhTrang.Name = "tinhTrang";
            cltinhTrang.HeaderText = "Tình Trạng";
            cltinhTrang.DataPropertyName = "TenTinhTrangPT";
            Dscay.Columns.Add(cltinhTrang);

            //tro du lieu va cap nhat len datagrid
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[Dscay.DataSource];
            myCurrencyManager.Refresh();
        }


        private void LapLich_Click_1(object sender, EventArgs e)
        {
            LichCS lich = new LichCS();
            lich.ShowDialog();
        }

        private void load_Click(object sender, EventArgs e)
        {
            loadData_Vao_GridView();
        }
    }
}
