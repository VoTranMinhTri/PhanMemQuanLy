using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ChamCong
    {
        private int macc;
        private DateTime ngaycham;
        private int manv;
        private int manv_cc;
        private int malc;
        private int trangthai;
        public ChamCong()
        {
            this.macc = 0;
            this.ngaycham = System.DateTime.Now;
            this.manv = 0;
            this.manv_cc = 0;
            this.malc = 0;
            this.trangthai = 0;
        }
        public ChamCong(int macc, DateTime ngaycham, int manv, int manv_cc,int malc,int trangthai)
        {
            this.macc = macc;
            this.ngaycham = ngaycham;
            this.manv = manv;
            this.manv_cc = manv_cc;
            this.malc = malc;
            this.trangthai = trangthai;
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public DateTime ngayCham
        {
            set { this.ngaycham = value; }
            get { return this.ngaycham; }
        }
        public int maLC
        {
            set { this.malc = value; }
            get { return this.malc; }
        }
        public int maCC
        {
            set { this.macc = value; }
            get { return this.macc; }
        }
        public int maNV
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public int maNV_CC
        {
            set { this.manv_cc = value; }
            get { return this.manv_cc; }
        }
    }
}
