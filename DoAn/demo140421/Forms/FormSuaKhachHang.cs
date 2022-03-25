using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
namespace demo140421.Forms
{
    public partial class FormSuaKhachHang : Form
    {
        private int makhcu;
        public FormSuaKhachHang()
        {
            InitializeComponent();
        }
        public FormSuaKhachHang(int makh, string tenkh, string gioitinh,DateTime ngaysinh, string sdt, string diachi,float doanhso, int maloai,int trangthai):this()
        {
            this.makhcu = makh;
            txtHoTen.Text = tenkh;
            txtMaKH.Text = makh.ToString();
            txtMaLoai.Text = maloai.ToString();
            if (gioitinh.Equals("NAM"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            dtpNgaySinh.Value = ngaysinh;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            txtDoanhSo.Text = doanhso.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_KhachHang balkh = new BAL_KhachHang();
            string gioitinh = null;
            if (radNam.Checked == true)
                gioitinh = "NAM";
            else
                gioitinh = "NU";
            int trangthai=0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                KhachHang kh = new KhachHang(int.Parse(txtMaKH.Text), txtHoTen.Text, gioitinh, dtpNgaySinh.Value, txtSDT.Text, txtDiaChi.Text, float.Parse(txtDoanhSo.Text), int.Parse(txtMaLoai.Text), trangthai);
                bool kq = balkh.SuaKhachHang(kh, this.makhcu);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           catch(Exception err)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
