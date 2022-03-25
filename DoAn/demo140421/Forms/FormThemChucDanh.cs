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
    public partial class FormThemChucDanh : Form
    {
        public FormThemChucDanh()
        {
            InitializeComponent();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_ChucDanh balcd = new BAL_ChucDanh();
            try
            {
                ChucDanh cd = new ChucDanh(int.Parse(txtMaCD.Text), txtTenCD.Text, float.Parse(txtLuongCB.Text), 1);
                bool kq = balcd.ThemChucDanh(cd);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
