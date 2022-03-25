using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_CTDonHang
    {
        public DataTable LayDanhSachCTDH(int ma)
        {
            try
            {
                DAL_CTDonHang objdal = new DAL_CTDonHang();
                return objdal.DocCTDonHang(ma);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemCTDonHang(CTDonHang ctdh)
        {
            try
            {
                DAL_CTDonHang objdal = new DAL_CTDonHang();
                bool kq = objdal.ThemCTDonHang(ctdh);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaCTDonHang(int madh, int mactsp, int mactmau, int mactsize)
        {
            try
            {
                DAL_CTDonHang objdal = new DAL_CTDonHang();
                bool kq = objdal.XoaCTDonHang(madh, mactsp, mactmau, mactsize);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaCTDonHang(CTDonHang dh, int macthdbcu, int mactspcu, int mactmaucu, int mactsizecu)
        {
            try
            {
                DAL_CTDonHang objdal = new DAL_CTDonHang();
                bool kq = objdal.SuaCTDonHang(dh, macthdbcu, mactspcu, mactmaucu, mactsizecu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
