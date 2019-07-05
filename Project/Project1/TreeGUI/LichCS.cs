using System;
using System.Collections.Generic;
using TreeBUS;
using TreeDTO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class LichCS : Form
    {
        private VattuBUS vattuBus;
        private LichChamSocBUS lichBus;
        private CayCanhBUS cayBus;
        private DonViTinhBUS DonViTinhBus;
        List<DonViTinhDTO> listDonVi;
        List<VattuDTO> listVatTu;
        
        public LichCS()
        {
            InitializeComponent();
        }

        private void LichCS_Load(object sender, EventArgs e)
        {
            vattuBus = new VattuBUS();
            lichBus = new LichChamSocBUS();
            cayBus = new CayCanhBUS();
            DonViTinhBus = new DonViTinhBUS();
            listDonVi = DonViTinhBus.selectDonVi();
            listVatTu = vattuBus.selectvattu();
        }

        private void timkiemBT_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(maCayCanhtb.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập dữ liệu trước khi thực hiện");
                return;
            }
            string sKeyword = maCayCanhtb.Text.Trim();
            DateTime ngaytrong = dateTimeLaplich.Value;
            List<LichchamsocDTO> listlich = lichBus.selectByKeyWord(sKeyword);
            List<LichchamsocDTO> result = new List<LichchamsocDTO>();
            for(i = 0; i < listlich.Count; i++)
            {
                if (listlich[i].MaCayPT != sKeyword)
                {
                    listlich.RemoveAt(i);
                }
                if (ngaytrong.Date == listlich[i].NgayLapLichPT)
                {
                    listlich[i].TenVatTuPT = listVatTu[listlich[i].MaVatTuPT - 1].TenVatTuPT;
                    listlich[i].DonViTinhPT = listDonVi[listlich[i].MaDonViTinhPT - 1].TenDonViTinhPT;
                    result.Add(listlich[i]);
                }
            }
      

            
            loadData_Vao_GridView(result);


        }

        private void loadData_Vao_GridView(List<LichchamsocDTO> listLich)
        {
            if (listLich == null||listLich.Count == 0)
            {
                MessageBox.Show("Có lỗi khi lấy lịch từ DataBase");
                return;
            }

            dgvLich.Columns.Clear();
            dgvLich.DataSource = null;

            dgvLich.AutoGenerateColumns = false;
            dgvLich.AllowUserToAddRows = false;
            dgvLich.DataSource = listLich;


            DataGridViewTextBoxColumn clThoiGian = new DataGridViewTextBoxColumn();
            clThoiGian.Name = "ThoiGian";
            clThoiGian.HeaderText = "Thời Gian";
            clThoiGian.DataPropertyName = "ThoiGianConvertPT";
            dgvLich.Columns.Add(clThoiGian);

            DataGridViewTextBoxColumn clVatTu = new DataGridViewTextBoxColumn();
            clVatTu.Name = "VatTu";
            clVatTu.HeaderText = "Vật Tư";
            clVatTu.DataPropertyName = "TenVatTuPT";

            dgvLich.Columns.Add(clVatTu);

            DataGridViewTextBoxColumn clDonViTinh = new DataGridViewTextBoxColumn();
            clDonViTinh.Name = "DonViTinh";
            clDonViTinh.HeaderText = "Đơn Vị Tính";
            clDonViTinh.DataPropertyName = "DonViTinhPT";
            dgvLich.Columns.Add(clDonViTinh);

            DataGridViewTextBoxColumn clSoLuong = new DataGridViewTextBoxColumn();
            clSoLuong.Name = "SoLuong";
            clSoLuong.HeaderText = "Số Lượng";
            clSoLuong.DataPropertyName = "SoLuongPT";
            dgvLich.Columns.Add(clSoLuong);

            DataGridViewTextBoxColumn clGhiChu = new DataGridViewTextBoxColumn();
            clGhiChu.Name = "GhiChu";
            clGhiChu.HeaderText = "Ghi Chú";
            clGhiChu.DataPropertyName = "GhiChuPT";
            dgvLich.Columns.Add(clGhiChu);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvLich.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
