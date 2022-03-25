using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NhanVien
    {
        private int manv;
        private string ho;
        private string tenlot;
        private string ten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string cccd;
        private string sdt;
        private string diachi;
        private DateTime ngayvaolam;
        private DateTime ngayketthuc;
        private int macd;
        private int mach;
        private int manvql;
        private int trangthai;
        public NhanVien()
        {
            this.manv = 0;
            this.ho = null;
            this.tenlot = null;
            this.ten = null;
            this.ngaysinh = System.DateTime.Now.Date;
            this.gioitinh = null;
            this.cccd = null;
            this.sdt = null;
            this.diachi = null;
            this.ngayvaolam = System.DateTime.Now.Date;
            this.ngayketthuc = System.DateTime.Now.Date;
            this.macd = 0;
            this.mach = 0;
            this.manvql = 0;
            this.trangthai = 0;

        }
        public NhanVien(int manv, string ho, string tenlot, string ten, DateTime ngaysinh, string gioitinh, string cccd, string sdt, string diachi, DateTime ngayvaolam, DateTime ngayketthuc, int macd, int mach,int manvql, int trangthai)
        {
            this.manv = manv;
            this.ho = ho;
            this.tenlot = tenlot;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cccd = cccd;
            this.sdt = sdt;
            this.diachi = diachi;
            this.ngayvaolam = ngayvaolam;
            this.ngayketthuc = ngayketthuc;
            this.macd = macd;
            this.mach = mach;
            this.manvql = manvql;
            this.trangthai = trangthai;
        }
        public int maCD
        {
            set { this.macd = value; }
            get { return this.macd; }
        }
        public int maNVQL
        {
            set { this.manvql = value; }
            get { return this.manvql; }
        }
        public int maNV
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public int maCH
        {
            set { this.mach = value; }
            get { return this.mach; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public string Ho
        {
            set { this.ho = value; }
            get { return this.ho; }
        }
        public string tenLot
        {
            set { this.tenlot = value; }
            get { return this.tenlot; }
        }
        public string Ten
        {
            set { this.ten = value; }
            get { return this.ten; }
        }
        public string gioiTinh
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }
        public DateTime ngaySinh
        {
            set { this.ngaysinh = value; }
            get { return this.ngaysinh; }
        }
        public string CCCD
        {
            set { this.cccd = value; }
            get { return this.cccd; }
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
        public DateTime ngayVaoLam
        {
            set { this.ngayvaolam = value; }
            get { return this.ngayvaolam; }
        }
        public DateTime ngayKetThuc
        {
            set { this.ngayketthuc = value; }
            get { return this.ngayketthuc; }
        }
    }
}
