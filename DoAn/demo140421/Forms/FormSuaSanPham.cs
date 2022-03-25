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
    public partial class FormSuaSanPham : Form
    {
        private int maspcu;
        private int mamaucu;
        private int masizecu;
        public FormSuaSanPham()
        {
            InitializeComponent();
        }
        public FormSuaSanPham(int masp, string tensp, string loai, string mau, string size, float gia, int tinhtrang)
            : this()
        {
            BAL_SanPham balsp = new BAL_SanPham();
            this.maspcu = masp;
            this.mamaucu = balsp.LayMaMau(mau);
            this.masizecu = balsp.LayMaSize(size);
            cbLoaiSP.DataSource = balsp.LayDanhSachLoaiSP();
            cbMau.DataSource = balsp.LayDanhSachMau();
            cbSize.DataSource = balsp.LayDanhSachSize();
            cbLoaiSP.ValueMember = "TenLoai";
            cbMau.ValueMember = "TenMau";
            cbSize.ValueMember = "TenSize";
            txtMaSP.Text = masp.ToString();
            txtTenSP.Text = tensp;
            cbLoaiSP.Text = loai;
            txtGia.Text = gia.ToString();
            cbMau.Text = mau;
            cbSize.Text = size;
            if (tinhtrang == 1)
                cbTinhTrang.Checked = true;
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp= new BAL_SanPham();
            int tinhtrang=0;
            if(cbTinhTrang.Checked == true)
                tinhtrang=1;
            SanPham sp = new SanPham(int.Parse(txtMaSP.Text),txtTenSP.Text,cbLoaiSP.Text,cbMau.Text,cbSize.Text,float.Parse(txtGia.Text),tinhtrang);
            if (balsp.KiemTraSPTrongDonHang(int.Parse(txtMaSP.Text),balsp.LayMaMau(cbMau.Text),balsp.LayMaSize(cbSize.Text)) == false)
            {
                bool kq = balsp.SuaSanPham(sp, this.maspcu, this.mamaucu, this.masizecu);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa không thành công! Sản phẩm này đang trong đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
