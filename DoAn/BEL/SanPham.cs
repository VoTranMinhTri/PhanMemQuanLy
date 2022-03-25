using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SanPham
    {
        private int masp;
        private string tensp;
        private string loai;
        private string mau;
        private string size;
        private float gia;
        private int tinhtrang;
        public SanPham()
        {
            this.masp = 0;
            this.tensp = null;
            this.loai = null;
            this.mau = null;
            this.size = null;
            this.tinhtrang=0;
            this.gia = 0;
        }
        public SanPham(int masp, string tensp, string loai,string mau,string size,float gia,int tinhtrang)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.loai = loai;
            this.mau = mau;
            this.size = size;
            this.gia = gia;
            this.tinhtrang=tinhtrang;
        }
        public float Gia
        {
            set { this.gia = value; }
            get { return this.gia; }
        }
        public int maSP
        {
            set { this.masp = value; }
            get { return this.masp; }
        }
        public string tenSP
        {
            set { this.tensp = value; }
            get { return this.tensp; }
        }
        public string Loai
        {
            set { this.loai = value; }
            get { return this.loai; }
        }
        public string Size
        {
            set { this.size = value; }
            get { return this.size; }
        }
        public string Mau
        {
            set { this.mau = value; }
            get { return this.mau; }
        }
         public int tinhTrang
        {
            set { this.tinhtrang = value; }
            get { return this.tinhtrang; }
        }
    }
}
