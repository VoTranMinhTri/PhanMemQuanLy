using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class KhoHang
    {
        private int masp;
        private int mamau;
        private int masize;
        private int soluong;
        public KhoHang()
        {
            this.masp = 0;
            this.mamau = 0;
            this.masize = 0;
            this.soluong = 0;
        }
        public KhoHang(int masp, int mamau, int masize,int soluong)
        {
            this.masp = masp;
            this.mamau = mamau;
            this.masize = masize;
            this.soluong = soluong;
        }
        public int maSP
        {
            set { this.masp = value; }
            get { return this.masp; }
        }
        public int maMau
        {
            set { this.mamau = value; }
            get { return this.mamau; }
        }
        public int maSize
        {
            set { this.masize = value; }
            get { return this.masize; }
        }
        public int soLuong
        {
            set { this.soluong = value; }
            get { return this.soluong; }
        }
    }
}
