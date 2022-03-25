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
    public partial class FormSuaLoaiKhachHang : Form
    {
        private int malkhcu;
        public FormSuaLoaiKhachHang()
        {
            InitializeComponent();
        }
        public FormSuaLoaiKhachHang(int malkh,string tenloai,float hanmuc,int trangthai):this()
        {
            this.malkhcu = malkh;
            txtMaLKH.Text = malkh.ToString();
            txtTenLoai.Text = tenloai;
            txtHanMuc.Text = hanmuc.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_LoaiKhachHang ballkh = new BAL_LoaiKhachHang();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                LoaiKhachHang lkh = new LoaiKhachHang(int.Parse(txtMaLKH.Text), txtTenLoai.Text, float.Parse(txtHanMuc.Text), trangthai);
                bool kq = ballkh.SuaLoaiKhachHang(lkh, this.malkhcu);
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
