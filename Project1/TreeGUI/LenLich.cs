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
    public partial class LenLich : Form
    {
        private VattuBUS vattuBus;
        private LichChamSocBUS lichBus;
        private CayCanhBUS cayBus;
        private DonViTinhBUS DonViTinhBus;
        List<DonViTinhDTO> listDonVi;
        List<VattuDTO> listVatTu;
        int selectedLoaiVatTu;
        public LenLich()
        {
            InitializeComponent();
        }
        private void LenLich_Load(object sender, EventArgs e)
        {
            lichBus = new LichChamSocBUS();
            vattuBus = new VattuBUS();

            cayBus = new CayCanhBUS();
            DonViTinhBus = new DonViTinhBUS();
            listDonVi = DonViTinhBus.selectDonVi();
            listVatTu = vattuBus.selectvattu();
            //selectedLoaiVatTu = int.Parse(comboBoxMaVatTu.SelectedValue.ToString());

            maChamSocTB.ReadOnly = true;
            gioTB.ReadOnly = true;
            PhutTB.ReadOnly = true;
            soLuongTB.ReadOnly = true;
            ghiChuTB.ReadOnly = true;
            soLuongTB.ReadOnly = true;

        }
        private void loadMaVatTu_Combobox()
        {
            List<VattuDTO> listViTri = vattuBus.selectvattu();

            if (listViTri == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            comboBoxMaVatTu.DataSource = new BindingSource(listViTri, String.Empty);
            comboBoxMaVatTu.DisplayMember = "TenVatTuPT";
            comboBoxMaVatTu.ValueMember = "MaVatTuPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBoxMaVatTu.DataSource];
            myCurrencyManager.Refresh();

            if (comboBoxMaVatTu.Items.Count > 0)
            {
                comboBoxMaVatTu.ResetText();
            }
        }

        private void Donvi_Combobox()
        {
            List<DonViTinhDTO> listDonVi = DonViTinhBus.selectDonVi();

            if (listDonVi == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            comboBoxDonVi.DataSource = new BindingSource(listDonVi, String.Empty);
            comboBoxDonVi.DisplayMember = "TenDonViTinhPT";
            comboBoxDonVi.ValueMember = "MaDonViTinhPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBoxDonVi.DataSource];
            myCurrencyManager.Refresh();

            if (comboBoxDonVi.Items.Count > 0)
            {
                comboBoxDonVi.ResetText();
            }
        }
        private void comboBoxMaVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLoaiVatTu = int.Parse(comboBoxMaVatTu.SelectedValue.ToString());

        }


        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            int i = 0,finder = 0;
            string sKeyword = maCayTB.Text.Trim();
            List<CaycanhDTO> listcayCanh = cayBus.selectByKeyWord(sKeyword);
          
            for (i = 0 ;i< listcayCanh.Count(); i ++ )
            {
                if (listcayCanh[i].MaCayCanhPT == sKeyword)
                {
                    finder = i;
                    break;
                }
                else
                {
                    finder = -1;
                }
            }
            if (listcayCanh == null)
            {
                finder = -1;
            }
            if (finder != -1)
            {
                MessageBox.Show("Có cây cần tìm trong danh sách");
                maChamSocTB.ReadOnly = false;
                gioTB.ReadOnly = false;
                PhutTB.ReadOnly = false;
                soLuongTB.ReadOnly = false;
                ghiChuTB.ReadOnly = false;
                soLuongTB.ReadOnly = false;
                loadMaVatTu_Combobox();
                Donvi_Combobox();
            }
            else
            {
                MessageBox.Show("Không có cây cần tìm trong danh sách. Vui lòng kiểm tra lại trong danh sách");
                maChamSocTB.ReadOnly = true;
                gioTB.ReadOnly = true;
                PhutTB.ReadOnly = true;

                soLuongTB.ReadOnly = true;
                ghiChuTB.ReadOnly = true;
                soLuongTB.ReadOnly = true;
            }

           

        }
        private void LenLichBT_Click(object sender, EventArgs e)
        {
            if(gioTB.Text == ""
                || PhutTB.Text == ""
                ||maChamSocTB.Text == ""
                ||maCayTB.Text == ""
                ||ghiChuTB.Text == ""
                ||soLuongTB.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đây đủ thông tin trước khi thực hiện");
                return;
            }
            //1. Map data from GUI
            DateTime ngaylap = new DateTime(2019,6,24);
            TimeSpan time = new TimeSpan(int.Parse(gioTB.Text.ToString()), int.Parse(PhutTB.Text.ToString()),0);
            long timeticks = time.Ticks;
            LichchamsocDTO lichDTO = new LichchamsocDTO();
            lichDTO.MaChamSocPT = maChamSocTB.Text;
            lichDTO.MaCayPT = maCayTB.Text;
            lichDTO.GhiChuPT = ghiChuTB.Text;
            lichDTO.MaVatTuPT = int.Parse(comboBoxMaVatTu.SelectedValue.ToString());
            lichDTO.SoLuongPT = int.Parse(soLuongTB.Text.ToString());
            lichDTO.NgayLapLichPT = ngaylap;
            lichDTO.MaDonViTinhPT = listDonVi[selectedLoaiVatTu-1].MaDonViTinhPT;
            lichDTO.ThoiGianPT = timeticks;
            //lichDTO.DonViTinhPT = listDonVi[selectedLoaiVatTu - 1].TenDonViTinhPT;
            //lichDTO.TenVatTuPT = listVatTu[selectedLoaiVatTu - 1].TenVatTuPT; 
            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = lichBus.themlich(lichDTO);
            if (result == false)
                MessageBox.Show("Thêm Lịch thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm Lịch thành công");
        }
    }
}
