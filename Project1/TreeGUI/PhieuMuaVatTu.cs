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
        private ThamSoBUS thamso;
        private List<ThamSoDTO> tsDTO;
        private int gtien,gGia;
        private int selectedLoaiVatTu,count;
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
            thamso = new ThamSoBUS();
            tsDTO = thamso.selectThamSo();
            Donvi_Combobox();

        }
        private void loadMaVatTu_Combobox()
        {
            List<VattuDTO> listViTri = vattuBus.selectvattu();

            if (listViTri == null)
            {
                MessageBox.Show("Có lỗi khi lấy Dữ liệu từ DB");
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
                MessageBox.Show("Có lỗi khi lấy Dữ liệu từ DB");
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
            if(maPhieuMuaTB.Text == ""
                || soluongTB.Text == ""
                ||comboBoxMaVatTu.SelectedValue == null
                ||CbDonVi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi thực hiện");
                return;
            }
            //1. Map data from GUI
            PhieuMuaVatTuDTO PhieuDTO = new PhieuMuaVatTuDTO();
            PhieuDTO.PhieuMuaVatTuPT = maPhieuMuaTB.Text;
            PhieuDTO.MaDonViTinhPT = int.Parse(CbDonVi.SelectedValue.ToString());
            PhieuDTO.NgayMuaPT = DateTime.Parse(dateTimeNgayMua.Value.ToString());
            PhieuDTO.SoLuongPT = int.Parse(soluongTB.Text);
            PhieuDTO.SoTienPT = gtien;
            PhieuDTO.MaVatTuPT = int.Parse(comboBoxMaVatTu.SelectedValue.ToString());
            PhieuDTO.DiaChiMuaPT = DiaChiTB.Text;

            //2. Kiểm tra data hợp lệ or not
            if(gtien > tsDTO[0].SoTienToiDaPT)
            {
                MessageBox.Show("Đã vượt quá số tiền quy định");
                return;
            }
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

            int i = 0;
            selectedLoaiVatTu = int.Parse(comboBoxMaVatTu.SelectedValue.ToString());
            VattuTB.ResetText();
            DiaChiTB.ResetText();
            for(i = 0; i< listVatTu.Count; i++)
            {
                if (selectedLoaiVatTu == listVatTu[i].MaVatTuPT)
                {
                    VattuTB.AppendText(listVatTu[i].TenVatTuPT);
                    DiaChiTB.AppendText(listVatTu[i].DiaChiBanPT);
                    gGia = listGiaVatTu[i].GiaVatTuPT;
                    count = i;
                    break;
                }
            }
            //VattuTB.AppendText(listVatTu[selectedLoaiVatTu - 1].TenVatTuPT);
            //DiaChiTB.AppendText(listVatTu[selectedLoaiVatTu - 1].DiaChiBanPT);

        }

        private void refesh_Click(object sender, EventArgs e)
        {
            comboBoxMaVatTu.ResetText();
            maPhieuMuaTB.ResetText();
            VattuTB.ResetText();
            DiaChiTB.ResetText();
            soluongTB.ResetText();
            soTienTB.ResetText();
            dateTimeNgayMua.ResetText();
            listVatTu = vattuBus.selectvattu();
            listGiaVatTu = GiaVatTuBus.selectGiaVat();
            loadMaVatTu_Combobox();
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
                gtien = soluongmua * gGia;
                soTienTB.Text = gtien.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số");
                soluongTB.ResetText();
            }

        }


        //----------------------------------------------------------------------------------//
        //All textbox call Back

    }
}
