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
    public partial class FormThongKe1 : Form
    {
        public FormThongKe1()
        {
            InitializeComponent();
            fillchart();
        }
        private void fillchart()
        {
            BAL_ThongKe baltk=new BAL_ThongKe();
            DataTable dt = new DataTable();
            dt = baltk.LayDoanhThuTungThang();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["THANG"], dt.Rows[i]["DOANHTHU"]);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY(""+dt.Rows[i]["THANG"], dt.Rows[i]["DOANHTHU"]);   
            }
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu" ;
            chart3.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart3.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["THANG"], dt.Rows[i]["DOANHTHU"]);
            }
        }
    }
}
