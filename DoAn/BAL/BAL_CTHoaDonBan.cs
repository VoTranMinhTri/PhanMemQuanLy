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
    public class BAL_CTHoaDonBan
    {
        public DataTable LayDanhSachCTHDB(int mahdb)
        {
            try
            {
                DAL_CTHoaDonBan objdal = new DAL_CTHoaDonBan();
                return objdal.DocCTHoaDonBan(mahdb);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemCTHoaDonBan(CTHoaDonBan hdb)
        {
            try
            {
                DAL_CTHoaDonBan objdal = new DAL_CTHoaDonBan();
                bool kq = objdal.ThemCTHoaDonBan(hdb);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaCTHoaDonBan(int macthdb, int mactsp, int mactmau, int mactsize)
        {
            try
            {
                DAL_CTHoaDonBan objdal = new DAL_CTHoaDonBan();
                bool kq = objdal.XoaCTHoaDonBan(macthdb, mactsp, mactmau, mactsize);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaCTHoaDonBan(CTHoaDonBan hdb, int macthdbcu, int mactspcu, int mactmaucu, int mactsizecu)
        {
            try
            {
                DAL_CTHoaDonBan objdal = new DAL_CTHoaDonBan();
                bool kq = objdal.SuaCTHoaDonBan(hdb, macthdbcu, mactspcu, mactmaucu, mactsizecu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimCTHoaDonBan(int mahdb)
        {
            try
            {
                DAL_CTHoaDonBan objdal = new DAL_CTHoaDonBan();
                return objdal.TimKiemCTHoaDonBan(mahdb);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
