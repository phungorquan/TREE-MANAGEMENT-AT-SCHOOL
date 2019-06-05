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
        private CayCanhBUS cayBus;
        public QuanLyCayCanh()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
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

            if (listCayCanh == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }

            Dscay.Columns.Clear();
            Dscay.DataSource = null;

            Dscay.AutoGenerateColumns = false;
            Dscay.AllowUserToAddRows = false;
            Dscay.DataSource = listCayCanh;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "MaCay";
            clMa.HeaderText = "Mã Cây Cảnh";
            clMa.DataPropertyName = "MaCayCanhPT";
            Dscay.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "TenCay";
            clTen.HeaderText = "Tên Cay";
            clTen.DataPropertyName = "TenCayPT";
            Dscay.Columns.Add(clTen);

            DataGridViewTextBoxColumn clloaicay = new DataGridViewTextBoxColumn();
            clloaicay.Name = "MaLoaiCay";
            clloaicay.HeaderText = "Mã Loại Cây";
            clloaicay.DataPropertyName = "MaLoaiCayCanhPT";
            Dscay.Columns.Add(clloaicay);

            DataGridViewTextBoxColumn clngayTrong = new DataGridViewTextBoxColumn();
            clngayTrong.Name = "ngayTrong";
            clngayTrong.HeaderText = "Ngày Trồng";
            clngayTrong.DataPropertyName = "NgayTrongPT";
            Dscay.Columns.Add(clngayTrong);

            DataGridViewTextBoxColumn clvitri = new DataGridViewTextBoxColumn();
            clvitri.Name = "MaViTri";
            clvitri.HeaderText = "Mã Vị Trí";
            clvitri.DataPropertyName = "MaViTriPT";
            Dscay.Columns.Add(clvitri);

            DataGridViewTextBoxColumn cltinhTrang = new DataGridViewTextBoxColumn();
            cltinhTrang.Name = "tinhTrang";
            cltinhTrang.HeaderText = "Tình Trạng";
            cltinhTrang.DataPropertyName = "TinhTrangPT";
            Dscay.Columns.Add(cltinhTrang);

            //tro du lieu va cap nhat len datagrid
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[Dscay.DataSource];
            myCurrencyManager.Refresh();
        }
        private void QuanLyCayCanh_Load(object sender, EventArgs e)
        {
            cayBus = new CayCanhBUS();
            loadData_Vao_GridView();

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
