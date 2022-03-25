using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace demo140421.Forms
{
    public partial class FormThongKe3 : Form
    {
        public FormThongKe3()
        {
            InitializeComponent();
            fillchart();
        }
        private void fillchart()
        {
            BAL_ThongKe baltk = new BAL_ThongKe();
            DataTable dt = new DataTable();
            dt = baltk.LayTop5SanPhamCoSoLuongBanCaoNhat();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên SP";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Số lượng"].Points.AddXY(dt.Rows[i]["TENSP"], dt.Rows[i]["SOLUONG"]);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY("" + dt.Rows[i]["TENSP"], dt.Rows[i]["SOLUONG"]);
            }
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Tên KH";
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chart3.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart3.Series["Số lượng"].Points.AddXY(dt.Rows[i]["TENSP"], dt.Rows[i]["SOLUONG"]);
            }
        }
    }
}
