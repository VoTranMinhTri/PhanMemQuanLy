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
    public partial class FormThemLoaiKhachHang : Form
    {
        public FormThemLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_LoaiKhachHang ballkh = new BAL_LoaiKhachHang();
            try
            {
                LoaiKhachHang lkh = new LoaiKhachHang(int.Parse(txtMaLKH.Text), txtTenLoai.Text, float.Parse(txtHanMuc.Text), 1);
                bool kq = ballkh.ThemLoaiKhachHang(lkh);
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
