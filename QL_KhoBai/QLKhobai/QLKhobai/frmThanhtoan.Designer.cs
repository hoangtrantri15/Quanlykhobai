namespace QLKhobai
{
    partial class frmThanhtoan
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSotTTchitiet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSophieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSotienthu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaylapphieu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // LabKB
            // 
            this.LabKB.AutoSize = true;
            this.LabKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabKB.ForeColor = System.Drawing.Color.Blue;
            this.LabKB.Location = new System.Drawing.Point(127, 9);
            this.LabKB.Name = "LabKB";
            this.LabKB.Size = new System.Drawing.Size(218, 42);
            this.LabKB.TabIndex = 3;
            this.LabKB.Text = "Thanh toán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(32, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 240);
            this.groupBox1.TabIndex = 42;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(390, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 42);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtSotTTchitiet
            // 
            this.txtSotTTchitiet.Location = new System.Drawing.Point(182, 149);
            this.txtSotTTchitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSotTTchitiet.Name = "txtSotTTchitiet";
            this.txtSotTTchitiet.ReadOnly = true;
            this.txtSotTTchitiet.Size = new System.Drawing.Size(188, 20);
            this.txtSotTTchitiet.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "STT chi tiết";
            // 
            // txtSophieu
            // 
            this.txtSophieu.Location = new System.Drawing.Point(182, 67);
            this.txtSophieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSophieu.Name = "txtSophieu";
            this.txtSophieu.ReadOnly = true;
            this.txtSophieu.Size = new System.Drawing.Size(188, 20);
            this.txtSophieu.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Số phiếu";
            // 
            // txtSotienthu
            // 
            this.txtSotienthu.Location = new System.Drawing.Point(182, 121);
            this.txtSotienthu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSotienthu.Name = "txtSotienthu";
            this.txtSotienthu.ReadOnly = true;
            this.txtSotienthu.Size = new System.Drawing.Size(188, 20);
            this.txtSotienthu.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Số tiền thu";
            // 
            // dtpNgaylapphieu
            // 
            this.dtpNgaylapphieu.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpNgaylapphieu.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpNgaylapphieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaylapphieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylapphieu.Location = new System.Drawing.Point(182, 94);
            this.dtpNgaylapphieu.Name = "dtpNgaylapphieu";
            this.dtpNgaylapphieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgaylapphieu.Size = new System.Drawing.Size(188, 20);
            this.dtpNgaylapphieu.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ngày lập phiếu";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(200, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 42);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(356, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 42);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(35, 199);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frmThanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 570);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpNgaylapphieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSotienthu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSophieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSotTTchitiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.LabKB);
            this.Name = "frmThanhtoan";
            this.Text = "frmHoadon";
            this.Load += new System.EventHandler(this.frmThanhtoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabKB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSotTTchitiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSophieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSotienthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaylapphieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
    }
}