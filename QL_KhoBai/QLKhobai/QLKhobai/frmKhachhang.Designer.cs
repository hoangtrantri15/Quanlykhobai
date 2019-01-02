namespace QLKhobai
{
    partial class FrmKhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabKH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtKhachHang_tenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhachHang_sodt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang_cmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhachHang_congNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhachHang_maKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhachHang_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // LabKH
            // 
            this.LabKH.AutoSize = true;
            this.LabKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabKH.ForeColor = System.Drawing.Color.Blue;
            this.LabKH.Location = new System.Drawing.Point(250, 9);
            this.LabKH.Name = "LabKH";
            this.LabKH.Size = new System.Drawing.Size(229, 42);
            this.LabKH.TabIndex = 1;
            this.LabKH.Text = "Khách hàng";
            this.LabKH.Click += new System.EventHandler(this.LabKH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(27, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(31, 20);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(708, 253);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellContentClick);
            // 
            // txtKhachHang_tenKH
            // 
            this.txtKhachHang_tenKH.Location = new System.Drawing.Point(143, 57);
            this.txtKhachHang_tenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhachHang_tenKH.Name = "txtKhachHang_tenKH";
            this.txtKhachHang_tenKH.Size = new System.Drawing.Size(194, 20);
            this.txtKhachHang_tenKH.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtKhachHang_sodt
            // 
            this.txtKhachHang_sodt.Location = new System.Drawing.Point(143, 85);
            this.txtKhachHang_sodt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhachHang_sodt.Name = "txtKhachHang_sodt";
            this.txtKhachHang_sodt.Size = new System.Drawing.Size(194, 20);
            this.txtKhachHang_sodt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại";
            // 
            // txtKhachHang_cmnd
            // 
            this.txtKhachHang_cmnd.Location = new System.Drawing.Point(143, 113);
            this.txtKhachHang_cmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhachHang_cmnd.Name = "txtKhachHang_cmnd";
            this.txtKhachHang_cmnd.Size = new System.Drawing.Size(194, 20);
            this.txtKhachHang_cmnd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số CMND";
            // 
            // txtKhachHang_congNo
            // 
            this.txtKhachHang_congNo.Location = new System.Drawing.Point(460, 93);
            this.txtKhachHang_congNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhachHang_congNo.Name = "txtKhachHang_congNo";
            this.txtKhachHang_congNo.Size = new System.Drawing.Size(194, 20);
            this.txtKhachHang_congNo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Công nợ đầu kỳ";
            // 
            // txtKhachHang_maKH
            // 
            this.txtKhachHang_maKH.Location = new System.Drawing.Point(460, 61);
            this.txtKhachHang_maKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhachHang_maKH.Name = "txtKhachHang_maKH";
            this.txtKhachHang_maKH.Size = new System.Drawing.Size(194, 20);
            this.txtKhachHang_maKH.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã khách hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(694, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(694, 74);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 42);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(694, 134);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 42);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(694, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 42);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(143, 140);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 42);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(269, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 42);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang_add
            // 
            this.btnKhachHang_add.Location = new System.Drawing.Point(385, 140);
            this.btnKhachHang_add.Name = "btnKhachHang_add";
            this.btnKhachHang_add.Size = new System.Drawing.Size(94, 42);
            this.btnKhachHang_add.TabIndex = 21;
            this.btnKhachHang_add.Text = "Them";
            this.btnKhachHang_add.UseVisualStyleBackColor = true;
            this.btnKhachHang_add.Click += new System.EventHandler(this.btnKhachHang_add_Click);
            // 
            // FrmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnKhachHang_add);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtKhachHang_maKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKhachHang_congNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKhachHang_cmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhachHang_sodt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKhachHang_tenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabKH);
            this.Name = "FrmKhachhang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FrmKhachhang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang_tenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhachHang_sodt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang_cmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhachHang_congNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhachHang_maKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhachHang_add;
    }
}