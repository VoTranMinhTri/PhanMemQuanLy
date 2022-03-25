using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class DonHang
    {
        private int madh;
        private int manv;
        private int makh;
        private DateTime ngaylap;
        private DateTime ngaynhan;
        private float chietkhau;
        private string ghichu;
        private int trangthai;
        public DonHang()
        {
            this.madh = 0;
            this.manv = 0;
            this.makh = 0;
            this.ngaylap = System.DateTime.Now;
            this.ngaynhan = System.DateTime.Now;
            this.chietkhau = 0;
            this.ghichu = null;
            this.trangthai = 0;
        }
        public DonHang(int madh,int manv, int makh, DateTime ngaylap, DateTime ngaynhan, float chietkhau, string ghichu, int trangthai)
        {
            this.madh = madh;
            this.manv = manv;
            this.makh = makh;
            this.ngaylap = ngaylap;
            this.ngaynhan = ngaynhan;
            this.chietkhau = chietkhau;
            this.ghichu = ghichu;
            this.trangthai = trangthai;
        }
        public int maNV
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public string ghiChu
        {
            set { this.ghichu = value; }
            get { return this.ghichu; }
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
        public DateTime ngayNhan
        {
            set { this.ngaynhan = value; }
            get { return this.ngaynhan; }
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
        public int maDH
        {
            set { this.madh = value; }
            get { return this.madh; }
        }
    }
}
