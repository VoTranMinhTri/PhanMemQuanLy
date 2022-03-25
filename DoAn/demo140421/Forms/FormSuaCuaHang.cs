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
    public partial class FormSuaCuaHang : Form
    {
        private int machcu;
        public FormSuaCuaHang()
        {
            InitializeComponent();
        }
        public FormSuaCuaHang(int mach,string tench,string diachi,int trangthai):this()
        {
            this.machcu = mach;
            txtMaCH.Text = mach.ToString();
            txtTenCH.Text = tench;
            txtDiaChi.Text = diachi;
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSuaNCC_Click(object sender, EventArgs e)
        {
            BAL_CuaHang balkh = new BAL_CuaHang();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                CuaHang ch = new CuaHang(int.Parse(txtMaCH.Text), txtTenCH.Text, txtDiaChi.Text, trangthai);
                bool kq = balkh.SuaCuaHang(ch, this.machcu);
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
