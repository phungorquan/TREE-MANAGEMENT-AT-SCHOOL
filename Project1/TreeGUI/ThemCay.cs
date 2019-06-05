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
    public partial class ThemCay : Form
    {
        //----------------------------------------------------------------------------------//
        private CayCanhBUS cayBus;
        private LoaiCayBUS LoaiCayBus;
        private ViTriBUS  ViTriBus;
        private TinhTrangBUS TinhTrangBus;
        //----------------------------------------------------------------------------------//
        public ThemCay()
        {
            InitializeComponent();
        }

        private void ThemCay_Load(object sender, EventArgs e)
        {
            cayBus = new CayCanhBUS();
            ViTriBus = new ViTriBUS();
            LoaiCayBus = new LoaiCayBUS();
            TinhTrangBus = new TinhTrangBUS();
            loadViTriVao_Combobox();
            loadLoaiCayVao_Combobox();
            loadTinhTrangVao_Combobox();
        }
        //----------------------------------------------------------------------------------//
        private void loadViTriVao_Combobox()
        {
            List<ViTriDTO> listViTri= ViTriBus.selectVT();

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
            comboxTinhTrang.DataSource = new BindingSource(listTinhTrang, String.Empty);
            comboxTinhTrang.DisplayMember = "TenTinhTrangPT";
            comboxTinhTrang.ValueMember = "MaTinhTrangPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboxTinhTrang.DataSource];
            myCurrencyManager.Refresh();

            if (comboxTinhTrang.Items.Count > 0)
            {
                comboxTinhTrang.SelectedIndex = 0;
            }

        }

        //----------------------------------------------------------------------------------//       
        private void Huy_Click(object sender, EventArgs e)
        {

        }

        private void Them_Click(object sender, EventArgs e)
        {

            //1. Map data from GUI
            CaycanhDTO cayDTO = new CaycanhDTO();
            cayDTO.MaCayCanhPT = MaCayTB.Text;
            cayDTO.TenCayPT = TenCaytb.Text;   
            cayDTO.NgayTrongPT = dateTimeNgayTrong.Value.ToString();
            cayDTO.MaViTriPT = int.Parse(comboBoxVitri.SelectedValue.ToString());
            cayDTO.MaLoaiCayCanhPT = int.Parse(comboBoxLoaiCay.SelectedValue.ToString());
            cayDTO.TinhTrangPT = int.Parse(comboxTinhTrang.SelectedValue.ToString());

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = cayBus.them(cayDTO);
            if (result == false)
                MessageBox.Show("Thêm Cây Cảnh thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm Cây Cảnh thành công");
        }

        //---------------------------------------------------------------------------------//

    }
}
   


   

