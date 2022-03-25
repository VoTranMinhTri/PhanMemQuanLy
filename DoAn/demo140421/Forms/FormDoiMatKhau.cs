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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void iconButtonDoiMatKhau_Click(object sender, EventArgs e)
        {
            BAL_TaiKhoan baltk = new BAL_TaiKhoan();
            string username = Encryption.Encrypt(txtUsername.Text);
            string password = Encryption.Encrypt(txtPasswordCu.Text);
            if (baltk.KiemTraDangNhap(username,password)== true)
            {
                if (txtPassword.Text.Equals(txtXacNhan.Text))
                {
                    bool kq = baltk.DoiMatKhau(username, Encryption.Encrypt(txtPassword.Text));
                    if (kq == true)
                    {
                        MessageBox.Show("Đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Đổi không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
