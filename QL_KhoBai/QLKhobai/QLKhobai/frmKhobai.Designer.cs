namespace QLKhobai
{
    partial class frmKhobai
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
            this.LabKB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.txtMakho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenkho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiahcikho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMakhuvuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDongia1m3ngay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // LabKB
            // 
            this.LabKB.AutoSize = true;
            this.LabKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabKB.ForeColor = System.Drawing.Color.Blue;
            this.LabKB.Location = new System.Drawing.Point(83, 29);
            this.LabKB.Name = "LabKB";
            this.LabKB.Size = new System.Drawing.Size(152, 42);
            this.LabKB.TabIndex = 2;
            this.LabKB.Text = "Kho bãi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(345, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 389);
            this.groupBox1.TabIndex = 3;
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
            this.dgvThanhToan.Size = new System.Drawing.Size(390, 341);
            this.dgvThanhToan.TabIndex = 1;
            // 
            // txtMakho
            // 
            this.txtMakho.Location = new System.Drawing.Point(126, 97);
            this.txtMakho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.ReadOnly = true;
            this.txtMakho.Size = new System.Drawing.Size(194, 20);
            this.txtMakho.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã kho";
            // 
            // txtTenkho
            // 
            this.txtTenkho.Location = new System.Drawing.Point(126, 125);
            this.txtTenkho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenkho.Name = "txtTenkho";
            this.txtTenkho.ReadOnly = true;
            this.txtTenkho.Size = new System.Drawing.Size(194, 20);
            this.txtTenkho.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên kho";
            // 
            // txtDiahcikho
            // 
            this.txtDiahcikho.Location = new System.Drawing.Point(126, 153);
            this.txtDiahcikho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiahcikho.Name = "txtDiahcikho";
            this.txtDiahcikho.ReadOnly = true;
            this.txtDiahcikho.Size = new System.Drawing.Size(194, 20);
            this.txtDiahcikho.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Địa chỉ kho";
            // 
            // txtMakhuvuc
            // 
            this.txtMakhuvuc.Location = new System.Drawing.Point(126, 181);
            this.txtMakhuvuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakhuvuc.Name = "txtMakhuvuc";
            this.txtMakhuvuc.ReadOnly = true;
            this.txtMakhuvuc.Size = new System.Drawing.Size(194, 20);
            this.txtMakhuvuc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã khu vực";
            // 
            // txtDongia1m3ngay
            // 
            this.txtDongia1m3ngay.Location = new System.Drawing.Point(126, 209);
            this.txtDongia1m3ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDongia1m3ngay.Name = "txtDongia1m3ngay";
            this.txtDongia1m3ngay.ReadOnly = true;
            this.txtDongia1m3ngay.Size = new System.Drawing.Size(194, 20);
            this.txtDongia1m3ngay.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn giá (1m3/ngày)";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(26, 278);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 42);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(126, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 42);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(226, 278);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 42);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(194, 356);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 42);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(70, 356);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(687, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 42);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmKhobai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 463);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtDongia1m3ngay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMakhuvuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiahcikho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenkho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMakho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabKB);
            this.Name = "frmKhobai";
            this.Text = "frmKhobai";
            this.Load += new System.EventHandler(this.frmKhobai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabKB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.TextBox txtMakho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiahcikho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMakhuvuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDongia1m3ngay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBack;
    }
}