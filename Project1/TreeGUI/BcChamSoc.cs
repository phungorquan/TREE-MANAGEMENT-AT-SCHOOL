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
    public partial class BcChamSoc : Form
    {
        private PhieuMuaVatTuBUS phieumuaBUS;
        private VattuBUS vattuBus;
        private DonViTinhBUS DonViTinhBus;
        private GiaVatTuBUS GiaVatTuBus;
        List<BCCSThangDTO> BaoCao;
        List<VattuDTO> listVatTu;
        List<int> sophieu;
        List<long> tongtien;
        List<PhieuMuaVatTuDTO> ListPhieuMua,Result;
      

        public BcChamSoc()
        {
            InitializeComponent();
        }
        private void BcChamSoc_Load(object sender, EventArgs e)
        {
            vattuBus = new VattuBUS();
            listVatTu = vattuBus.selectvattu();
        
            phieumuaBUS = new PhieuMuaVatTuBUS();
            ListPhieuMua = phieumuaBUS.selectPhieu();
            BaoCao = new List<BCCSThangDTO>();
            //XuLySoLieu();
        }


        private void timKiemBT_Click(object sender, EventArgs e)
        {

            bool result = XuLySoLieu();
            if(result == false)
            {
                MessageBox.Show("Vui lòng Kiểm tra dữ liệu");
            }
            else
            {
                loadData_Vao_GridView(BaoCao);
            }
        }
        private bool XuLySoLieu()
        {
            sophieu = new List<int>(listVatTu.Count());
            tongtien = new List<long>(listVatTu.Count());
            BaoCao = new List<BCCSThangDTO>();
            Result = new List<PhieuMuaVatTuDTO>();
            int count = 0, i = 0, number = 0 ;
            if (yearBT.Text == "" || monthBT.Text == "")
            {
                return false;
            }
            else if(int.Parse(yearBT.Text) < 0)
            {
                return false;
            }
            else if (int.Parse(monthBT.Text)<0 || int.Parse(monthBT.Text)>= 12)
            {
                return false;
            }

            DateTime ngayTim = new DateTime(int.Parse(yearBT.Text), int.Parse(monthBT.Text),1);
          
            
            for (i = 0; i< ListPhieuMua.Count(); i++)
            {
                if(ListPhieuMua[i].NgayMuaPT.Month == ngayTim.Month && ListPhieuMua[i].NgayMuaPT.Year == ngayTim.Year)
                {
                    Result.Add(ListPhieuMua[i]);
                }

            }
            if (Result == null || Result.Count == 0  )
            {
                return false;
            }
            for(i = 0; i < listVatTu.Count(); i++)
            {
                sophieu.Add(0);
                tongtien.Add(0);
            }
            count = Result.Count();
            for ( i = 0; i < count; i++)
            {
                sophieu[Result[i].MaVatTuPT - 1]++;
                tongtien[Result[i].MaVatTuPT - 1] = tongtien[Result[i].MaVatTuPT - 1]+ Result[i].SoTienPT;
            }
            if(Result.Count() < listVatTu.Count())
            {
                number = Result.Count();
            }
            else
            {
                number = listVatTu.Count();
            }
            for (i = 0; i < number; i++)
            {
                BCCSThangDTO Temp = new BCCSThangDTO();
                Temp.MaCTChiPhiThangPT = monthBT.Text+yearBT.Text + (Result[i].MaVatTuPT - 1).ToString();
                Temp.MaChiPhiThangPT = monthBT.Text + yearBT.Text + i.ToString();
                Temp.TenVatTuPT = listVatTu[Result[i].MaVatTuPT-1].TenVatTuPT;
                Temp.MaVatTuPT = Result[i].MaVatTuPT;
                Temp.SoPhieuMuaPT = sophieu[Result[i].MaVatTuPT - 1];
                Temp.TongTriGiaPT = tongtien[Result[i].MaVatTuPT - 1];
                Temp.TyLePT = Convert.ToDouble(sophieu[Result[i].MaVatTuPT - 1]) / count;
                BaoCao.Add(Temp);
                Temp = null;
            }
            
            return true;
        }


        private void loadData_Vao_GridView(List<BCCSThangDTO> listBaoCao)
        {
            if (listBaoCao == null || listBaoCao.Count == 0)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }

            dataChamSoc.Columns.Clear();
            dataChamSoc.DataSource = null;

            dataChamSoc.AutoGenerateColumns = false;
            dataChamSoc.AllowUserToAddRows = false;
            dataChamSoc.DataSource = listBaoCao;


            DataGridViewTextBoxColumn clVatTu = new DataGridViewTextBoxColumn();
            clVatTu.Name = "VatTu";
            clVatTu.HeaderText = "Vật Tư";
            clVatTu.DataPropertyName = "TenVatTuPT";
            dataChamSoc.Columns.Add(clVatTu);

            DataGridViewTextBoxColumn clSoPhieu = new DataGridViewTextBoxColumn();
            clSoPhieu.Name = "SoPhieu";
            clSoPhieu.HeaderText = "Số Phiếu Mua";
            clSoPhieu.DataPropertyName = "SoPhieuMuaPT";

            dataChamSoc.Columns.Add(clSoPhieu);

            DataGridViewTextBoxColumn clTongGiaTri = new DataGridViewTextBoxColumn();
            clTongGiaTri.Name = "TongGiaTri";
            clTongGiaTri.HeaderText = "Tổng Giá Trị";
            clTongGiaTri.DataPropertyName = "TongTriGiaPT";
            dataChamSoc.Columns.Add(clTongGiaTri);

            DataGridViewTextBoxColumn clTyLe = new DataGridViewTextBoxColumn();
            clTyLe.Name = "TyLe";
            clTyLe.HeaderText = "Tỷ Lệ";
            clTyLe.DataPropertyName = "TyLePT";
            dataChamSoc.Columns.Add(clTyLe);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataChamSoc.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
