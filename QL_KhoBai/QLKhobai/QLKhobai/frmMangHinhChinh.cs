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
    public partial class frmMangHinhChinh : Form
    {
        public frmMangHinhChinh()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachhang f = new FrmKhachhang();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
