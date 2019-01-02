using QLKhobai.CONNECT;
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
    public partial class FrmKhachhang : Form
    {
        public bool coThem;
        public FrmKhachhang()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadListKhachHang()
        {
            dgvKhachHang.DataSource = KhachHang.Instance.LoadListKhachHang();
        }
        void LoadForm()
        {
            LoadListKhachHang();
            LockTextBox(true);
        }
        void LockTextBox(bool a)
        {
            txtKhachHang_maKH.ReadOnly = a;
            txtKhachHang_tenKH.ReadOnly = a;
            txtKhachHang_sodt.ReadOnly = a;
            txtKhachHang_cmnd.ReadOnly = a;
            txtKhachHang_congNo.ReadOnly = a;
        }
        private void LabKH_Click(object sender, EventArgs e)
        {

        }

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvKhachHang.SelectedRows.Count > 0)
                {
                    txtKhachHang_maKH.Text = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                    txtKhachHang_tenKH.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
                    txtKhachHang_cmnd.Text = dgvKhachHang.SelectedRows[0].Cells[2].Value.ToString();
                    txtKhachHang_congNo.Text = dgvKhachHang.SelectedRows[0].Cells[3].Value.ToString();
                }
                else if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                    txtKhachHang_maKH.Text = row.Cells[0].Value.ToString();
                    txtKhachHang_tenKH.Text = row.Cells[1].Value.ToString();
                    txtKhachHang_cmnd.Text = row.Cells[2].Value.ToString();
                    txtKhachHang_congNo.Text = row.Cells[3].Value.ToString();
                }
            }
            catch (NullReferenceException) { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                //try
                //{
                    int tenKH = Int32.Parse(txtKhachHang_maKH.Text);
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng [" + txtKhachHang_tenKH.Text + "] không?", "TT",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (KhachHang.Instance.KhachHang_Xoa(tenKH))
                        { 
                        
                            //lbThemTC.Text = "<\\ Xóa khách hàng thành công >";
                            //LoadListKH();
                            //SetLock(false);
                            //SetBtn(true);
                        }
                        else
                        {
                            //lbThemTB.Text = "<\\ Xóa khách hàng thất bại! >";
                        }
                    }
                //}
      
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKH = txtKhachHang_maKH.Text;
            string tenKH = txtKhachHang_tenKH.Text;
            string cmnd = txtKhachHang_cmnd.Text;
            string sodt = txtKhachHang_sodt.Text;
            double congNo = Double.Parse(txtKhachHang_congNo.Text);
            if(coThem == true)
            {
                if (KhachHang.Instance.KhachHang_Them(maKH, tenKH, cmnd, sodt, congNo))
                {
                    MessageBox.Show("Add Done!");
                    LoadListKhachHang();
                }
                else
                {
                    MessageBox.Show("Add ...");
                }
            }
        }
        private void FrmKhachhang_Load(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_add_Click(object sender, EventArgs e)
        {
            coThem = true;
            LockTextBox(false);
        }
    }
}
