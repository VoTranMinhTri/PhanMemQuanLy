using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LoaiSanPham
    {
        private int maloai;
        private string tenloai;
        private int trangthai;
        public LoaiSanPham()
        {
            this.maloai = 0;
            this.tenloai = null;
            this.trangthai = 0;
        }
        public LoaiSanPham(int maloai,string tenloai,int trangthai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.trangthai = trangthai;
        }
        public int maLoai
        {
            set { this.maloai = value; }
            get { return this.maloai; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public string tenLoai
        {
            set { this.tenloai = value; }
            get { return this.tenloai; }
        }
    }
}
