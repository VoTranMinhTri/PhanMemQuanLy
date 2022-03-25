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
    public partial class FormThongKe2 : Form
    {
        public FormThongKe2()
        {
            InitializeComponent();
            fillchart();
        }
        private void fillchart()
        {
            BAL_ThongKe baltk = new BAL_ThongKe();
            DataTable dt = new DataTable();
            dt = baltk.LayTop3KhachHangCoDoanhSoCaoNhat();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên KH";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Doanh số"].Points.AddXY(dt.Rows[i]["TENKH"], dt.Rows[i]["DOANHSO"]);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY("" + dt.Rows[i]["TENKH"], dt.Rows[i]["DOANHSO"]);
            }
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Tên KH";
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chart3.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart3.Series["Doanh số"].Points.AddXY(dt.Rows[i]["TENKH"], dt.Rows[i]["DOANHSO"]);
            }
        }
    }
}
