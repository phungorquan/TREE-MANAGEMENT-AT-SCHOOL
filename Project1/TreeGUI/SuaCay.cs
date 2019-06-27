using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeDTO;
using TreeBUS;

namespace Project1
{
    public partial class SuaCay : Form
    {
        //-------------------------------------------------------------------//
        private CayCanhBUS cayBus;
        private LoaiCayBUS LoaiCayBus;
        private ViTriBUS ViTriBus;
        private TinhTrangBUS TinhTrangBus;
        //------------------------------------------------------------------//
        public SuaCay()
        {
            InitializeComponent();
        }
        private void SuaCay_Load(object sender, EventArgs e)
        {

            cayBus = new CayCanhBUS();
            ViTriBus = new ViTriBUS();
            LoaiCayBus = new LoaiCayBUS();
            TinhTrangBus = new TinhTrangBUS();
            loadViTriVao_Combobox();
            loadLoaiCayVao_Combobox();
            loadTinhTrangVao_Combobox();
        }
        private void SuaButton_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            CaycanhDTO cayDTO = new CaycanhDTO();
            cayDTO.TenCayPT = TenCaytb.Text;
            cayDTO.NgayTrongPT = DateTime.Parse(dateTimeNgayTrong.Value.ToString());
            cayDTO.MaViTriPT = int.Parse(comboBoxVitri.SelectedValue.ToString());
            cayDTO.MaLoaiCayCanhPT = int.Parse(comboBoxLoaiCay.SelectedValue.ToString());

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = cayBus.suaCay(cayDTO);
            if (kq == false)
                MessageBox.Show("Sửa thông tin cây thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Cập nhận thông tin cây thành công");
        }

        private void Huy_Click(object sender, EventArgs e)
        {

        }
        private void loadViTriVao_Combobox()
        {
            List<ViTriDTO> listViTri = ViTriBus.selectVT();

            if (listViTri == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            comboBoxVitri.DataSource = new BindingSource(listViTri, String.Empty);
            comboBoxVitri.DisplayMember = "TenViTriPT";
            comboBoxVitri.ValueMember = "MaViTriPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBoxVitri.DataSource];
            myCurrencyManager.Refresh();

            if (comboBoxVitri.Items.Count > 0)
            {
                comboBoxVitri.SelectedIndex = 0;
            }

        }
        private void loadLoaiCayVao_Combobox()
        {
            List<LoaiCayDTO> listLoaiCay = LoaiCayBus.selectLoaiCay();

            if (listLoaiCay == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            comboBoxLoaiCay.DataSource = new BindingSource(listLoaiCay, String.Empty);
            comboBoxLoaiCay.DisplayMember = "TenLoaiCayPT";
            comboBoxLoaiCay.ValueMember = "MaLoaiCayPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBoxLoaiCay.DataSource];
            myCurrencyManager.Refresh();

            if (comboBoxLoaiCay.Items.Count > 0)
            {
                comboBoxLoaiCay.SelectedIndex = 0;
            }

        }
        private void loadTinhTrangVao_Combobox()
        {
            List<TinhTrangDTO> listTinhTrang = TinhTrangBus.selectTT();

            if (listTinhTrang == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            comboBoxTinhTrang.DataSource = new BindingSource(listTinhTrang, String.Empty);
            comboBoxTinhTrang.DisplayMember = "TenTinhTrangPT";
            comboBoxTinhTrang.ValueMember = "MaTinhTrangPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBoxTinhTrang.DataSource];
            myCurrencyManager.Refresh();

            if (comboBoxTinhTrang.Items.Count > 0)
            {
                comboBoxTinhTrang.SelectedIndex = 0;
            }


        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            string sKeyword = MaCayTB.Text.Trim();
            List<CaycanhDTO> listcayCanh = cayBus.selectByKeyWord(sKeyword);
            CaycanhDTO maCay = listcayCanh[0];

            dateTimeNgayTrong.Value = maCay.NgayTrongPT;

        }


    }

}