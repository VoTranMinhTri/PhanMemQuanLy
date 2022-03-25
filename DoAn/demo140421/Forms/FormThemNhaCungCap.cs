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
    public partial class FormThemNhaCungCap : Form
    {
        public FormThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_NhaCungCap balncc = new BAL_NhaCungCap();
            NhaCungCap ncc = new NhaCungCap(int.Parse(txtMaNCC.Text),txtTen.Text,txtDiaChi.Text,txtEmail.Text,txtSDT.Text,1);
            try
            {
                bool kq = balncc.ThemNhaCungCap(ncc);
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
