using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class PhieuMuaVatTuDTO
    {
        private string phieumuavattu;
        private int mavattu;
        private int madonvitinh;
        private string diachimua;
        private int soluong;
        private int sotien;
        private DateTime ngaymua;



        public string PhieuMuaVatTuPT
        {
            get => phieumuavattu;
            set => phieumuavattu = value;
        }
        public int MaVatTuPT
        {
            get => mavattu;
            set => mavattu = value;
        }
        public int MaDonViTinhPT
        {
            get => madonvitinh;
            set => madonvitinh = value;
        }
        public string DiaChiMuaPT
        {
            get => diachimua;
            set => diachimua = value;
        }
        public int SoLuongPT
        {
            get => soluong;
            set => soluong = value;
        }
        public int SoTienPT
        {
            get => sotien;
            set => sotien = value;
        }
        public DateTime NgayMuaPT
        {
            get => ngaymua;
            set => ngaymua = value;
        }

    }
}
