namespace QLKhobai
{
    partial class frmChititethopdong
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
            this.LabChitiethopdong = new System.Windows.Forms.Label();
            this.txtSohopdong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotTTchitiet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // LabChitiethopdong
            // 
            this.LabChitiethopdong.AutoSize = true;
            this.LabChitiethopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabChitiethopdong.ForeColor = System.Drawing.Color.Blue;
            this.LabChitiethopdong.Location = new System.Drawing.Point(76, 25);
            this.LabChitiethopdong.Name = "LabChitiethopdong";
            this.LabChitiethopdong.Size = new System.Drawing.Size(317, 42);
            this.LabChitiethopdong.TabIndex = 2;
            this.LabChitiethopdong.Text = "Chi tiết hợp đồng";
            this.LabChitiethopdong.Click += new System.EventHandler(this.LabChitiethopdong_Click);
            // 
            // txtSohopdong
            // 
            this.txtSohopdong.Location = new System.Drawing.Point(169, 107);
            this.txtSohopdong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSohopdong.Name = "txtSohopdong";
            this.txtSohopdong.ReadOnly = true;
            this.txtSohopdong.Size = new System.Drawing.Size(188, 20);
            this.txtSohopdong.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số hợp đồng";
            // 
            // txtMakho
            // 
            this.txtMakho.Location = new System.Drawing.Point(169, 135);
            this.txtMakho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.ReadOnly = true;
            this.txtMakho.Size = new System.Drawing.Size(188, 20);
            this.txtMakho.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã kho";
            // 
            // dtpNgayketthuc
            // 
            this.dtpNgayketthuc.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpNgayketthuc.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpNgayketthuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayketthuc.Location = new System.Drawing.Point(169, 162);
            this.dtpNgayketthuc.Name = "dtpNgayketthuc";
            this.dtpNgayketthuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgayketthuc.Size = new System.Drawing.Size(188, 20);
            this.dtpNgayketthuc.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngày kết thúc";
            // 
            // txtSotTTchitiet
            // 
            this.txtSotTTchitiet.Location = new System.Drawing.Point(169, 84);
            this.txtSotTTchitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSotTTchitiet.Name = "txtSotTTchitiet";
            this.txtSotTTchitiet.ReadOnly = true;
            this.txtSotTTchitiet.Size = new System.Drawing.Size(188, 20);
            this.txtSotTTchitiet.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "STT chi tiết";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(375, 562);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 42);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(17, 562);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(94, 42);
            this.btnThanhtoan.TabIndex = 38;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(17, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 240);
            this.groupBox1.TabIndex = 39;
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
            this.dgvThanhToan.Size = new System.Drawing.Size(390, 212);
            this.dgvThanhToan.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(188, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 42);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(344, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 42);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(23, 209);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frmChititethopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 616);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSotTTchitiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayketthuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMakho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSohopdong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabChitiethopdong);
            this.Name = "frmChititethopdong";
            this.Text = "Chi tiết hợp đồng";
            this.Load += new System.EventHandler(this.frmChititethopdong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabChitiethopdong;
        private System.Windows.Forms.TextBox txtSohopdong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSotTTchitiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
    }
}