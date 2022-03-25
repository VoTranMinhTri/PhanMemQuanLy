using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CTDonHang
    {
        private int madh;
        private int masp;
        private int mamau;
        private int masize;
        private float gia;
        private int soluong;
        private float thanhtien;
        private int trangthai;
        public CTDonHang()
        {
            this.madh = 0;
            this.masp = 0;
            this.mamau = 0;
            this.masize = 0;
            this.gia = 0;
            this.soluong = 0;
            this.thanhtien = 0;
            this.trangthai = 0;
        }
        public CTDonHang(int madh, int masp, int mamau, int masize, float gia, int soluong, float thanhtien, int trangthai)
        {
            this.madh = madh;
            this.masp = masp;
            this.mamau = mamau;
            this.masize = masize;
            this.gia = gia;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
            this.trangthai = trangthai;
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public float thanhTien
        {
            set { this.thanhtien = value; }
            get { return this.thanhtien; }
        }
        public float Gia
        {
            set { this.gia = value; }
            get { return this.gia; }
        }
        public int maDH
        {
            set { this.madh = value; }
            get { return this.madh; }
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
