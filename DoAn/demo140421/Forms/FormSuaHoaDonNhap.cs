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
    public partial class FormSuaHoaDonNhap : Form
    {
        private int mahdncu;
        public FormSuaHoaDonNhap()
        {
            InitializeComponent();
            BAL_NhaCungCap balncc = new BAL_NhaCungCap();
            cbTenNCC.DataSource = balncc.LayDanhSachTenNCC();
            cbTenNCC.ValueMember = "TenNCC";
        }
        public FormSuaHoaDonNhap(int mahd, DateTime ngaylap, string tenncc, float trangthai)
            : this()
        {
            this.mahdncu = mahd;
            txtMaHD.Text = mahd.ToString();
            cbTenNCC.Text = tenncc;
            dtpNgayLap.Value = ngaylap;
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click_1(object sender, EventArgs e)
        {
            BAL_HoaDonNhap balhdn = new BAL_HoaDonNhap();
            BAL_NhaCungCap balncc = new BAL_NhaCungCap();
            int mancc = balncc.LayMaNCC(cbTenNCC.Text);
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                HoaDonNhap kh = new HoaDonNhap(int.Parse(txtMaHD.Text), dtpNgayLap.Value, mancc, trangthai);
                bool kq = balhdn.SuaHoaDonNhap(kh, this.mahdncu);
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
