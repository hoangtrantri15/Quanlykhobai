using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhobai
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

           private void BtnDangnhap_Click(object sender, EventArgs e)
        {
            string userName = txbTendangnhap.Text;
            string passWord = txbMatkhau.Text;

            //if (Login(userName, passWord))
            //{
            //    frmMangHinhChinh f = new frmMangHinhChinh();
            //    Hide();
            //    EnableLogin();
            //    f.ShowDialog();
            //    Show();
            //}
            //else
            //{
            //    lbW.Text = "";
            //    lbCheckLogin.Text = "<\\ Sai tên tài khoản hoặc mật khẩu >";
            //}
        }
    }
}
