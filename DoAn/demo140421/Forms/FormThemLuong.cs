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
    public partial class FormThemLuong : Form
    {
        public FormThemLuong()
        {
            InitializeComponent();
            khoiTaoThang();
            khoiTaoNam();
            cboThang.Text = System.DateTime.Now.Month.ToString();
            cboNam.Text = System.DateTime.Now.Year.ToString();
        }

        private void khoiTaoThang()
        {
            for (int i = 1; i < 13;i++)
                cboThang.Items.Add(i);
        }
        private void khoiTaoNam()
        {
            for (int i = 2000; i <= 2050; i++)
                cboNam.Items.Add(i);
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_Luong balluong = new BAL_Luong();
            BAL_ChucDanh balcd=new BAL_ChucDanh();
            BAL_ChamCong balcc=new BAL_ChamCong();
            try
            {
                float luongtk = balcd.LayLuongCB(int.Parse(txtMaNV.Text)) + balcc.LayTongTienChamCong(int.Parse(txtMaNV.Text), int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                Luong luong = new Luong(int.Parse(txtMaNV.Text), int.Parse(cboThang.Text), int.Parse(cboNam.Text), luongtk, 1);
                bool kq = balluong.ThemLuong(luong);
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
