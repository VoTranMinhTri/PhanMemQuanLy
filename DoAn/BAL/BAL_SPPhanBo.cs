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
    public class BAL_SPPhanBo
    {
        public DataTable TimKiemSPPB(string masp,int mach)
        {
            try
            {
                DAL_SPPhanBo objdal = new DAL_SPPhanBo();
                return objdal.TimKiemSPPB(masp,mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemSPPBTheoTen(string tensp,int mach)
        {
            try
            {
                DAL_SPPhanBo objdal = new DAL_SPPhanBo();
                return objdal.TimKiemSPPBTheoTen(tensp,mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachSPPhanBo(int mach)
        {
            try
            {
                DAL_SPPhanBo objdal = new DAL_SPPhanBo();
                return objdal.DocSPPhanBo(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaSanPhamPhanBo(int masp, int mamau, int masize, int mach)
        {
            try
            {
                DAL_SPPhanBo objdal = new DAL_SPPhanBo();
                bool kq = objdal.XoaSanPhamPhanBo(masp,mamau,masize,mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemSPPhanBo(SP_PhanBo sppb)
        {
            try
            {
                DAL_SPPhanBo objdal = new DAL_SPPhanBo();
                bool kq = objdal.ThemSPPhanBo(sppb);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaSPPhanBo(SP_PhanBo sppb, int maspcu, int mamaucu, int masizecu,int machcu,int soluongcu)
        {
            try
            {
                DAL_SPPhanBo objdal = new DAL_SPPhanBo();
                bool kq = objdal.SuaSPPhanBo(sppb, maspcu, mamaucu, masizecu, machcu,soluongcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
