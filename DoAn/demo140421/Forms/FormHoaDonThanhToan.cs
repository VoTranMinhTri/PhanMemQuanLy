using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo140421.Forms
{
    public partial class FormHoaDonThanhToan : Form
    {
        int mahd;
        public FormHoaDonThanhToan()
        {
            InitializeComponent();
        }
        public FormHoaDonThanhToan(int mahd):this()
        {
            this.mahd = mahd;
        }
        private void FormHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHoaDonThanhToan.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetHoaDonThanhToan.DataTable1,mahd);

            this.reportViewer1.RefreshReport();
        }
    }
}
