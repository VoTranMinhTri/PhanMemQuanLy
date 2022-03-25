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
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        public FormThemNhanVien(int macdht,int machht):this()
        {
            BAL_ChucDanh balcd = new BAL_ChucDanh();
            BAL_CuaHang balch = new BAL_CuaHang();
            if (macdht == 3)
            {
                cboTenCD.DataSource = balcd.LayDanhSachTenCD();
                cboTenCH.DataSource = balch.LayDanhSachTenCuaHang();
                cboTenCD.ValueMember = "TenCD";
                cboTenCH.ValueMember = "TenCH";
            }
            else
            {
                cboTenCD.DataSource = balcd.LayDanhSachTenCDDanhChoQuanLy();
                cboTenCH.Text = balch.LayTenTuMaCH(machht);
                cboTenCD.ValueMember = "TenCD";
            }
     
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_NhanVien balnv = new BAL_NhanVien();
            BAL_CuaHang balch = new BAL_CuaHang();
              BAL_ChucDanh balcd = new BAL_ChucDanh();
            try
            {
                int mach = balch.LayMaCHTuTenCH(cboTenCH.Text);
                int macd = balcd.LayMaCD(cboTenCD.Text);
                string gioitinh = null;
                if (radNam.Checked == true)
                    gioitinh = "NAM";
                else
                    gioitinh = "NU";
                DateTime ngayKetThuc;
                if (dtpNgayKetThuc.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                    ngayKetThuc = new DateTime(2100, 1, 1);
                else
                {
                    ngayKetThuc = dtpNgayKetThuc.Value;
                }
                NhanVien nv = new NhanVien(int.Parse(txtMaNV.Text), txtHo.Text, txtTenLot.Text, txtTen.Text, dtpNgaySinh.Value, gioitinh, txtCCCD.Text, txtSDT.Text, txtDiaChi.Text, dtpNgayVaoLam.Value, ngayKetThuc, macd, mach, int.Parse(txtMaNVQL.Text), 1);
                bool kq = balnv.ThemNhanVien(nv);
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
