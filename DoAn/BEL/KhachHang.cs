using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class KhachHang
    {
        private int makh;
        private string tenkh;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private int maloai;
        private float doanhso;
        private DateTime ngaysinh;
        private int trangthai;
        public KhachHang()
        {
            this.makh = 0;
            this.tenkh = null;
            this.sdt = null;
            this.gioitinh = null;
            this.diachi = null;
            this.maloai = 0;
            this.ngaysinh = DateTime.Now;
            this.trangthai = 0;
            this.doanhso = 0;
        }
        public KhachHang(int makh, string tenkh, string gioitinh,DateTime ngaysinh, string sdt, string diachi,float doanhso, int maloai,int trangthai)
        {
            this.ngaysinh = ngaysinh;
            this.makh = makh;
            this.tenkh = tenkh;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.maloai = maloai;
            this.trangthai = trangthai;
            this.doanhso = doanhso;
        }
        public float doanhSo
        {
            set { this.doanhso = value; }
            get { return this.doanhso; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public DateTime ngaySinh
        {
            set { this.ngaysinh = value; }
            get { return this.ngaysinh; }
        }
        public int maKH
        {
            set { this.makh = value; }
            get { return this.makh; }
        }
        public int maLoai
        {
            set { this.maloai = value; }
            get { return this.maloai; }
        }
        public string tenKH
        {
            set { this.tenkh = value; }
            get { return this.tenkh; }
        }
        public string SDT
        {
            set { this.sdt = value; }
            get { return this.sdt; }
        }
        public string diaChi
        {
            set { this.diachi = value; }
            get { return this.diachi; }
        }
        public string gioiTinh
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }
    }
}
