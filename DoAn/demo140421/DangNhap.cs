using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using BAL;
namespace demo140421
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string us = Encryption.Encrypt(txtTenDN.Text);
            string pw = Encryption.Encrypt(txtMK.Text);
            BAL_TaiKhoan tk = new BAL_TaiKhoan();
            bool kq = tk.KiemTraDangNhap(us,pw);
            if( kq == true)
            {
              this.Hide();
              Form1 frm = new Form1(us);
              frm.ShowDialog();
            }
            else
            {
             lblThongBao.Text="Username hoặc Password không chính xác.\nVui lòng thử lại.";
              txtMK.Clear();
            }
        }


        private void ckMK_CheckedChanged(object sender, EventArgs e)
        {
            if(ckMK.Checked == true)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //icon
        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }    
    }
}
