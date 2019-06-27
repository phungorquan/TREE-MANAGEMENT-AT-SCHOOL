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
    public partial class Vattu : UserControl
    {
        private PhieuMuaVatTuBUS phieumuaBUS;
        private VattuBUS vattuBus;
        private DonViTinhBUS DonViTinhBus;
        private GiaVatTuBUS GiaVatTuBus;
        List<VattuDTO> listVatTu;
        List<DonViTinhDTO> listDonVi;
        List<GiaVatTuDTO> listGiaVatTu;
        private int gtien;
        int selectedLoaiVatTu;
        public Vattu()
        {
            InitializeComponent();
        }
        private void Vattu_Load(object sender, EventArgs e)
        {
            vattuBus = new VattuBUS();
            DonViTinhBus = new DonViTinhBUS();
            GiaVatTuBus = new GiaVatTuBUS();
            phieumuaBUS = new PhieuMuaVatTuBUS();
            loadMaVatTu_Combobox();
            listVatTu = vattuBus.selectvattu();
            listDonVi = DonViTinhBus.selectDonVi();
            listGiaVatTu = GiaVatTuBus.selectGiaVat();
            Donvi_Combobox();

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
            comboBoxMaVatTu.DisplayMember = "MaVatTuPT";
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
            CbDonVi.DataSource = new BindingSource(listDonVi, String.Empty);
            CbDonVi.DisplayMember = "TenDonViTinhPT";
            CbDonVi.ValueMember = "MaDonViTinhPT";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[CbDonVi.DataSource];
            myCurrencyManager.Refresh();

            if (CbDonVi.Items.Count > 0)
            {
                CbDonVi.ResetText();
            }
        }
        //-----------------------------------------------------------------------------------------//
        //Button calback
        private void button1_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuMuaVatTuDTO PhieuDTO = new PhieuMuaVatTuDTO();
            PhieuDTO.PhieuMuaVatTuPT = maPhieuMuaTB.Text;
            PhieuDTO.MaDonViTinhPT = listDonVi[selectedLoaiVatTu-1].MaDonViTinhPT;
            PhieuDTO.NgayMuaPT = DateTime.Parse(dateTimeNgayMua.Value.ToString());
            PhieuDTO.SoLuongPT = int.Parse(soluongTB.Text);
            PhieuDTO.SoTienPT = gtien;
            PhieuDTO.MaVatTuPT = listVatTu[selectedLoaiVatTu - 1].MaVatTuPT;
            PhieuDTO.DiaChiMuaPT = listVatTu[selectedLoaiVatTu - 1].DiaChiBanPT;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool result = phieumuaBUS.themPhieu(PhieuDTO);
            if (result == false)
                MessageBox.Show("Thêm Phiếu mua thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm Phiếu thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxMaVatTu.ResetText();
            maPhieuMuaTB.ResetText();
            VattuTB.ResetText();
            DiaChiTB.ResetText();
            soluongTB.ResetText();
            soTienTB.ResetText();
            dateTimeNgayMua.ResetText();

            MessageBox.Show("Đã hủy");

          
        }

        private void comboBoxMaVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {


            selectedLoaiVatTu = int.Parse(comboBoxMaVatTu.SelectedValue.ToString());
            VattuTB.ResetText();
            DiaChiTB.ResetText();
            VattuTB.AppendText(listVatTu[selectedLoaiVatTu - 1].TenVatTuPT);
            DiaChiTB.AppendText(listVatTu[selectedLoaiVatTu - 1].DiaChiBanPT);

        }
        private void soluongTB_TextChanged(object sender, EventArgs e)
        {

            if(soluongTB.Text == "")
            {
                soTienTB.ResetText();
            }
            else if (soluongTB.Text.All(char.IsDigit))
            {
                int soluongmua = int.Parse(soluongTB.Text);
                gtien = soluongmua * listGiaVatTu[selectedLoaiVatTu - 1].GiaVatTuPT;
                soTienTB.Text = gtien.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số");
                soluongTB.ResetText();
            }

        }

        private void settingBT_Click(object sender, EventArgs e)
        {
            MenuVatTu f = new MenuVatTu();
            f.ShowDialog();
            listVatTu = vattuBus.selectvattu();
            listGiaVatTu = GiaVatTuBus.selectGiaVat();
        }
        //----------------------------------------------------------------------------------//
        //All textbox call Back

    }
}
