using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SP_PhanBo
    {
        private int masp;
        private int mamau;
        private int masize;
        private int mach;
        private int soluong;
        private int trangthai;
        public SP_PhanBo()
        {
            this.masp = 0;
            this.mamau = 0;
            this.masize = 0;
            this.mach = 0;
            this.soluong = 0;
            this.trangthai = 0;
        }
        public SP_PhanBo(int masp, int mamau, int masize, int mach, int soluong,int trangthai)
        {
            this.masp = masp;
            this.mamau = mamau;
            this.masize = masize;
            this.mach = mach;
            this.soluong = soluong;
            this.trangthai = trangthai;
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
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
        public int maSP
        {
            set { this.masp = value; }
            get { return this.masp; }
        }
        public int maCH
        {
            set { this.mach = value; }
            get { return this.mach; }
        }
        public int soLuong
        {
            set { this.soluong = value; }
            get { return this.soluong; }
        }
    }
}
