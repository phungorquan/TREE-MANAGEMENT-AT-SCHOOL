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
        private ThamSoBUS thamso;
        private List<ThamSoDTO> tsDTO;
        private List<ViTriDTO> listViTri;
        private int vitricu;
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
            thamso = new ThamSoBUS();
            tsDTO = thamso.selectThamSo();
            TenCaytb.ReadOnly = true;
            
        }
        private void SuaButton_Click(object sender, EventArgs e)
        {
            int i = 0, vitrimoi = 0;
            if (TenCaytb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trước khi sửa");
                return;
            }
            //1. Map data from GUI
            CaycanhDTO cayDTO = new CaycanhDTO();
            cayDTO.MaCayCanhPT = MaCayTB.Text;
            cayDTO.TenCayPT = TenCaytb.Text;
            cayDTO.NgayTrongPT = DateTime.Parse(dateTimeNgayTrong.Value.ToString());
            cayDTO.MaViTriPT = int.Parse(comboBoxVitri.SelectedValue.ToString());
            cayDTO.MaLoaiCayCanhPT = int.Parse(comboBoxLoaiCay.SelectedValue.ToString());
            cayDTO.TinhTrangPT = int.Parse(comboBoxTinhTrang.SelectedValue.ToString());

            //2. Kiểm tra data hợp lệ or not
            for (i = 0; i < listViTri.Count(); i++)
            {
                if (listViTri[i].MaViTriPT == cayDTO.MaViTriPT)
                {
                    vitrimoi = i;
                    break;
                }
            }
            if (tsDTO[0].SoCayToiDaPT < listViTri[vitrimoi].SoLuongPT)
            {
                MessageBox.Show("Số lương Cây cảnh đã vượt quá số lương tối đa của vị trí. Vui lòng chọn vị trí khác");
                return;
            }
            else
            {


                if (vitricu != vitrimoi)
                {
                    ViTriDTO suavt = new ViTriDTO();
                    ViTriDTO suavt1 = new ViTriDTO();
                    suavt.MaViTriPT = listViTri[vitrimoi].MaViTriPT;
                    suavt.TenViTriPT = listViTri[vitrimoi].TenViTriPT;
                    suavt.SoLuongPT = listViTri[vitrimoi].SoLuongPT + 1;
                    suavt1.MaViTriPT = listViTri[vitricu].MaViTriPT;
                    suavt1.TenViTriPT = listViTri[vitricu].TenViTriPT;
                    suavt1.SoLuongPT = listViTri[vitricu].SoLuongPT - 1;
                    bool result1 = ViTriBus.suaViTri(suavt);
                    bool result2 = ViTriBus.suaViTri(suavt1);
                    if (result1 == false || result2 == false)
                    {
                        MessageBox.Show("có vấn đề đang xảy ra");
                    }

                }

            }
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
        private void loadViTriVao_Combobox(int number)
        {
          listViTri = ViTriBus.selectVT();

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
                comboBoxVitri.SelectedIndex = number;
            }

        }
        private void loadLoaiCayVao_Combobox(int number)
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
                comboBoxLoaiCay.SelectedIndex = number;
            }

        }
        private void loadTinhTrangVao_Combobox(int number)
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
                comboBoxTinhTrang.SelectedIndex = number;
            }


        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            string sKeyword = MaCayTB.Text.Trim();
            List<CaycanhDTO> listcayCanh = cayBus.selectByKeyWord(sKeyword);
            if(listcayCanh == null || listcayCanh.Count == 0)
            {
                MessageBox.Show("Không tìm thấy cây cảnh cần cập nhận");
                return;
            }
            if(sKeyword == "")
            {
                MessageBox.Show("Vui lòng nhập mã cây");
                return;
            }
            for(i = 0; i < listcayCanh.Count; i++)
            {
                if(listcayCanh[i].MaCayCanhPT == sKeyword){
                    vitricu = i;
                    TenCaytb.ResetText();
                    loadViTriVao_Combobox(listcayCanh[i].MaViTriPT - 1);
                    loadLoaiCayVao_Combobox(listcayCanh[i].MaLoaiCayCanhPT - 1);
                    loadTinhTrangVao_Combobox(listcayCanh[i].TinhTrangPT - 1);
                    TenCaytb.AppendText(listcayCanh[i].TenCayPT);
                    TenCaytb.ReadOnly = false;
                    MaCayTB.ReadOnly = true;
                    MessageBox.Show("Tìm được cần sửa.Đã sẵn sàng cập nhận");
                    break;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cây cảnh cần cập nhận");
                }
            }


        }


    }

}