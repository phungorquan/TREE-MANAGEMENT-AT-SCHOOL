using System;
using TreeDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class LichchamsocDTO
    {
        private string machamsoc;
        private long thoigian;
        private TimeSpan thoigianconvert;
        private string tenvattu;
        private string donvitinh;
        private int mavattu;
        private int madonvitinh;
        private int soluong;
        private string ghichu;
        private string macay;
        private DateTime ngaylaplich;


        public string MaChamSocPT
        {
            get => machamsoc;
            set => machamsoc = value;
        }
        public long ThoiGianPT
        {
            get => thoigian;
            set => thoigian = value;
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
        public int SoLuongPT
        {
            get => soluong;
            set => soluong = value;
        }
        public string GhiChuPT
        {
            get => ghichu;
            set => ghichu = value;
        }

        public string MaCayPT
        {
            get => macay;
            set => macay = value;
        }
        public DateTime NgayLapLichPT
        {
            get => ngaylaplich;
            set => ngaylaplich = value;
        }
        public TimeSpan ThoiGianConvertPT
        {
            get => TimeSpan.FromTicks(thoigian);
            set => thoigianconvert =TimeSpan.FromTicks(thoigian);
        }
        public string TenVatTuPT
        {
            get => tenvattu;
            set => tenvattu = value;
        }
        public string DonViTinhPT
        {
            get => donvitinh;
            set => donvitinh = value;
        }
    }
}
