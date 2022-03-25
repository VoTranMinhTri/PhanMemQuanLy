using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LoaiKhachHang
    {
        private int maloai;
        private string tenloai;
        private float hanmuc;
        private int trangthai;
        public LoaiKhachHang()
        {
            this.maloai = 0;
            this.tenloai = null;
            this.hanmuc = 0;
            this.trangthai=0;
        }
        public LoaiKhachHang(int maloai, string tenloai, float hanmuc, int trangthai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.hanmuc = hanmuc;
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
        public float hanMuc
        {
            set { this.hanmuc = value; }
            get { return this.hanmuc; }
        }
        public string tenLoai
        {
            set { this.tenloai = value; }
            get { return this.tenloai; }
        }
    }
}
