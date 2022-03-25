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
    public partial class FormSuaNhanVien : Form
    {
        private int manvcu;
        public FormSuaNhanVien()
        {
            InitializeComponent();
        }
        public FormSuaNhanVien(int manv, string ho,string tenlot,string ten,DateTime ngaysinh, string gioitinh, string cccd, string sdt, string diachi, DateTime ngayvaolam, DateTime ngayketthuc, int macd,int mach,int manvql, int trangthai,int macdht,int machht)
            : this()
        {
            BAL_ChucDanh balcd=new BAL_ChucDanh();
            BAL_CuaHang balch=new BAL_CuaHang();

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
            this.manvcu = manv;
            txtMaNV.Text = manv.ToString();
            txtHo.Text = ho;
            txtTenLot.Text = tenlot;
            txtTen.Text = ten;
            if (gioitinh.Equals("NAM"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            dtpNgaySinh.Value = ngaysinh;
            txtCCCD.Text = cccd;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            txtMaNVQL.Text = manvql.ToString();
            dtpNgayVaoLam.Value = ngayvaolam;
            dtpNgayKetThuc.Value = ngayketthuc;
            cboTenCH.Text = balch.LayTenTuMaCH(mach).ToString();
            cboTenCD.Text = balcd.LayTenCDTuMaCD(macd).ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_ChucDanh balcd = new BAL_ChucDanh();
            BAL_CuaHang balch = new BAL_CuaHang();
            BAL_NhanVien balnv = new BAL_NhanVien();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            string gioitinh = null;
            if (radNam.Checked == true)
                gioitinh = "NAM";
            else
                gioitinh = "NU";
            int mach = balch.LayMaCHTuTenCH(cboTenCH.Text);
            int macd = balcd.LayMaCD(cboTenCD.Text);
            NhanVien nv = new NhanVien(int.Parse(txtMaNV.Text), txtHo.Text, txtTenLot.Text, txtTen.Text, dtpNgaySinh.Value, gioitinh, txtCCCD.Text, txtSDT.Text, txtDiaChi.Text, dtpNgayVaoLam.Value, dtpNgayKetThuc.Value, macd, mach, int.Parse(txtMaNVQL.Text), trangthai);
            bool kq = balnv.SuaNhanVien(nv, this.manvcu);
            if (kq == true)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
