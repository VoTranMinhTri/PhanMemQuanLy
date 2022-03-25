using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class HoaDonBan
    {
        private int mahd;
        private int manv;
        private int makh;
        private DateTime ngaylap;
        private float chietkhau;
        private int trangthai;
        public HoaDonBan()
        {
            this.mahd = 0;
            this.manv = 0;
            this.makh = 0;
            this.ngaylap = DateTime.Now;
            this.chietkhau = 0;
            this.trangthai = 0;
        }
        public HoaDonBan(int mahd, int manv, int makh, DateTime ngaylap, float chietkhau, int trangthai)
        {
            this.mahd = mahd;
            this.manv = manv;
            this.makh = makh;
            this.ngaylap = ngaylap;
            this.chietkhau = chietkhau;
            this.trangthai = trangthai;
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public float chietKhau
        {
            set { this.chietkhau = value; }
            get { return this.chietkhau; }
        }
        public DateTime ngayLap
        {
            set { this.ngaylap = value; }
            get { return this.ngaylap; }
        }
        public int maKH
        {
            set { this.makh = value; }
            get { return this.makh; }
        }
        public int maHD
        {
            set { this.mahd = value; }
            get { return this.mahd; }
        }
        public int maNV
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
    }
}
