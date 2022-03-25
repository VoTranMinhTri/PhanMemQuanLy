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
using BEL;
namespace demo140421.Forms
{
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_KhachHang balnv = new BAL_KhachHang();
            string gioitinh = null;
            if (radNam.Checked == true)
                gioitinh = "NAM";
            else
                gioitinh = "NU";
            try
            {
                KhachHang nv = new KhachHang(int.Parse(txtMaKH.Text), txtHoTen.Text, gioitinh, dtpNgaySinh.Value, txtSDT.Text, txtDiaChi.Text, 0, int.Parse(txtMaLoai.Text), 1);
                bool kq = balnv.ThemKhachHang(nv);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
