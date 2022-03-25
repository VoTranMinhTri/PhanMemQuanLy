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
    public partial class FormThemCuaHang : Form
    {
        public FormThemCuaHang()
        {
            InitializeComponent();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_CuaHang balch = new BAL_CuaHang();
            try
            {
                CuaHang ch = new CuaHang(int.Parse(txtMaCH.Text), txtTenCH.Text, txtDiaChi.Text, 1);
                bool kq = balch.ThemCuaHang(ch);
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
