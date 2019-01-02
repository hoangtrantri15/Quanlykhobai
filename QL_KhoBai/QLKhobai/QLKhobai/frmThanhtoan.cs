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
    public partial class frmThanhtoan : Form
    {
        public frmThanhtoan()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadListThanhToan()
        {
            dgvThanhToan.DataSource = ThanhToan.Instance.LoadListThanhToan();
        }
        void LoadForm()
        {
            LoadListThanhToan();
            LockTextBox(true);
        }
        void LockTextBox(bool a)
        {
            txtThanhToan_soPhieu.ReadOnly = a;
            txtThanhToan_ngayLapPhieu.ReadOnly = a;
            txtThanhToan_soTienThu.ReadOnly = a;
            txtThanhToan_sttChiTiet.ReadOnly = a;
        }

        private void frmThanhtoan_Load(object sender, EventArgs e)
        {

        }
    }
}
