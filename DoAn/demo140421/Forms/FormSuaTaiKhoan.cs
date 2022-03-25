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
    public partial class FormSuaTaiKhoan : Form
    {
        int manvdsd;
        public FormSuaTaiKhoan()
        {
            InitializeComponent();
        }
        public FormSuaTaiKhoan(string username,int manv,int trangthai,int manvdsd,int macd,int mach):this()
        {
            this.manvdsd = manvdsd;
            BAL_NhanVien balnv = new BAL_NhanVien();
            txtUsername.Text = username;
            if (macd != 3)
                cboMaNV.DataSource = balnv.LayDanhSachMaNVDanhChoQuanLy(mach);
            else
                cboMaNV.DataSource = balnv.LayDanhSachMaNV();
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.Text = manv.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_TaiKhoan baltk = new BAL_TaiKhoan();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            string username=Encryption.Encrypt(txtUsername.Text);
            string password=baltk.LayPassword(username);
            TaiKhoan tk = new TaiKhoan(username,password,int.Parse(cboMaNV.Text),trangthai);
            if (int.Parse(cboMaNV.Text) != manvdsd)
            {
                bool kq = baltk.SuaTaiKhoan(tk);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa không thành công! Tài khoản hiện đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
