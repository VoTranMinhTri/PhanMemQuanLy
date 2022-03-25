using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class HoaDonNhap
    {
        private int mahd;
        private DateTime ngaylap;
        private int  mancc;
        private int trangthai;
        public HoaDonNhap()
        {
            this.mahd = 0;
            this.ngaylap = DateTime.Now;
            this.mancc = 0;
            this.trangthai = 0;
        }
        public HoaDonNhap(int mahd, DateTime ngaylap, int mancc, int trangthai)
        {
            this.mahd = mahd;
            this.ngaylap = ngaylap;
            this.mancc = mancc;
            this.trangthai = trangthai;
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public int maHD
        {
            set { this.mahd = value; }
            get { return this.mahd; }
        }
        public DateTime ngayLap
        {
            set { this.ngaylap = value; }
            get { return this.ngaylap; }
        }
        public int maNCC
        {
            set { this.mancc = value; }
            get { return this.mancc; }
        }
    }
}
