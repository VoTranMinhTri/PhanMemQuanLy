using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;
namespace BAL
{
    public class BAL_ThongKe
    {
        public DataTable LayDoanhThuTungThang()
        {
            try
            {
                DAL_ThongKe objdal = new DAL_ThongKe();
                DataTable kq = objdal.LayDoanhThuTungThang();
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayTop3KhachHangCoDoanhSoCaoNhat()
        {
            try
            {
                DAL_ThongKe objdal = new DAL_ThongKe();
                DataTable kq = objdal.LayTop3KhachHangCoDoanhSoCaoNhat();
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayTop5SanPhamCoSoLuongBanCaoNhat()
        {
            try
            {
                DAL_ThongKe objdal = new DAL_ThongKe();
                DataTable kq = objdal.LayTop5SanPhamCoSoLuongBanCaoNhat();
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
