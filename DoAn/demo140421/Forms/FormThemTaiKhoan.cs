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
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }
        public FormThemTaiKhoan(int mach,int macd):this()
        {
            BAL_NhanVien balnv = new BAL_NhanVien();
            if(macd !=3)
                cboMaNV.DataSource = balnv.LayDanhSachMaNVDanhChoQuanLy(mach);
            else
                cboMaNV.DataSource = balnv.LayDanhSachMaNV();
            cboMaNV.ValueMember = "MaNV";
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_TaiKhoan baltk = new BAL_TaiKhoan();
            string username = Encryption.Encrypt(txtUsername.Text);
            string password = Encryption.Encrypt(txtPassword.Text);
            if (baltk.KiemTraTenTaiKhoan(username) != true)
            {
                if (txtPassword.Text.Equals(txtXacNhan.Text))
                {
                    TaiKhoan tk = new TaiKhoan(username,password,int.Parse(cboMaNV.Text),1);
                    bool kq = baltk.ThemTaiKhoan(tk);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ckMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMK.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                txtXacNhan.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtXacNhan.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
