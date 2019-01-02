namespace QLKhobai
{
    partial class frmKhuvuc
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
            this.txtMakhuvuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabKH = new System.Windows.Forms.Label();
            this.txtTenquanhuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenphuongxa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMakhuvuc
            // 
            this.txtMakhuvuc.Location = new System.Drawing.Point(138, 55);
            this.txtMakhuvuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakhuvuc.Name = "txtMakhuvuc";
            this.txtMakhuvuc.ReadOnly = true;
            this.txtMakhuvuc.Size = new System.Drawing.Size(194, 20);
            this.txtMakhuvuc.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã khu vực";
            // 
            // LabKH
            // 
            this.LabKH.AutoSize = true;
            this.LabKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabKH.ForeColor = System.Drawing.Color.Blue;
            this.LabKH.Location = new System.Drawing.Point(96, 9);
            this.LabKH.Name = "LabKH";
            this.LabKH.Size = new System.Drawing.Size(161, 42);
            this.LabKH.TabIndex = 17;
            this.LabKH.Text = "Khu vực";
            // 
            // txtTenquanhuyen
            // 
            this.txtTenquanhuyen.Location = new System.Drawing.Point(138, 83);
            this.txtTenquanhuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenquanhuyen.Name = "txtTenquanhuyen";
            this.txtTenquanhuyen.ReadOnly = true;
            this.txtTenquanhuyen.Size = new System.Drawing.Size(194, 20);
            this.txtTenquanhuyen.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên quận huyện";
            // 
            // txtTenphuongxa
            // 
            this.txtTenphuongxa.Location = new System.Drawing.Point(138, 111);
            this.txtTenphuongxa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenphuongxa.Name = "txtTenphuongxa";
            this.txtTenphuongxa.ReadOnly = true;
            this.txtTenphuongxa.Size = new System.Drawing.Size(194, 20);
            this.txtTenphuongxa.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên phường xã";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 191);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Location = new System.Drawing.Point(31, 20);
            this.dgvThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.Size = new System.Drawing.Size(289, 154);
            this.dgvThanhToan.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(268, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 42);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(238, 153);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 42);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(199, 211);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 42);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(90, 211);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(138, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 42);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(38, 153);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 42);
            this.btnTim.TabIndex = 25;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmKhuvuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 519);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenphuongxa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenquanhuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabKH);
            this.Controls.Add(this.txtMakhuvuc);
            this.Controls.Add(this.label4);
            this.Name = "frmKhuvuc";
            this.Text = "Khu vực";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMakhuvuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabKH;
        private System.Windows.Forms.TextBox txtTenquanhuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenphuongxa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
    }
}