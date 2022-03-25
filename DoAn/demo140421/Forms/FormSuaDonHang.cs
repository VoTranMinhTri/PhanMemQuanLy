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
    public partial class FormSuaDonHang : Form
    {
        private int macu;
        public FormSuaDonHang()
        {
            InitializeComponent();
        }

        public FormSuaDonHang(int madh,int manv, int makh, DateTime ngaylap,DateTime ngaynhan, float chietkhau,string ghichu, float trangthai) : this()
        {
            this.macu = madh;
            txtMaDH.Text = madh.ToString();
            txtMaKH.Text = makh.ToString();
            txtMaNV.Text = manv.ToString();
            dtpNgayLap.Value = ngaylap;
            dtpNgayNhan.Value = ngaynhan;
            rtbGhiChu.Text = ghichu;
            txtChietKhau.Text = chietkhau.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_DonHang baldh = new BAL_DonHang();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                DonHang dh = new DonHang(int.Parse(txtMaDH.Text), int.Parse(txtMaNV.Text), int.Parse(txtMaKH.Text), dtpNgayLap.Value, dtpNgayNhan.Value, float.Parse(txtChietKhau.Text), rtbGhiChu.Text, trangthai);
                bool kq = baldh.SuaDonHang(dh, this.macu);
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
