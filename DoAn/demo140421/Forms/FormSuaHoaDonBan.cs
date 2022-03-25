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
    public partial class FormSuaHoaDonBan : Form
    {
        private int mahdbcu;
        public FormSuaHoaDonBan()
        {
            InitializeComponent();
        }
        public FormSuaHoaDonBan(int mahd, int manv, int makh, DateTime ngaylap, float chietkhau, float trangthai)
            : this()
        {
            this.mahdbcu = mahd;
            txtMaHD.Text = mahd.ToString();
            txtMaKH.Text = makh.ToString();
            txtMaNV.Text = manv.ToString();
            dtpNgayLap.Value = ngaylap;
            txtChietKhau.Text = chietkhau.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_HoaDonBan balhdb = new BAL_HoaDonBan();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                HoaDonBan kh = new HoaDonBan(int.Parse(txtMaHD.Text), int.Parse(txtMaNV.Text), int.Parse(txtMaKH.Text), dtpNgayLap.Value, float.Parse(txtChietKhau.Text), trangthai);
                bool kq = balhdb.SuaHoaDonBan(kh, this.mahdbcu);
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
