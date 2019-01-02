namespace QLKhobai
{
    partial class frmMangHinhChinh
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
            this.LabQLKB = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnHopDongThanhToan = new System.Windows.Forms.Button();
            this.btnKhoBai = new System.Windows.Forms.Button();
            this.btnKhuVuc = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabQLKB
            // 
            this.LabQLKB.AutoSize = true;
            this.LabQLKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabQLKB.ForeColor = System.Drawing.Color.Blue;
            this.LabQLKB.Location = new System.Drawing.Point(200, 49);
            this.LabQLKB.Name = "LabQLKB";
            this.LabQLKB.Size = new System.Drawing.Size(357, 42);
            this.LabQLKB.TabIndex = 0;
            this.LabQLKB.Text = "QUẢN LÝ KHO BÃI";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhachHang.Location = new System.Drawing.Point(45, 165);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(117, 95);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHopDongThanhToan
            // 
            this.btnHopDongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHopDongThanhToan.Location = new System.Drawing.Point(190, 165);
            this.btnHopDongThanhToan.Name = "btnHopDongThanhToan";
            this.btnHopDongThanhToan.Size = new System.Drawing.Size(170, 95);
            this.btnHopDongThanhToan.TabIndex = 2;
            this.btnHopDongThanhToan.Text = "Hợp đồng Thanh toán";
            this.btnHopDongThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnKhoBai
            // 
            this.btnKhoBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoBai.Location = new System.Drawing.Point(403, 165);
            this.btnKhoBai.Name = "btnKhoBai";
            this.btnKhoBai.Size = new System.Drawing.Size(117, 95);
            this.btnKhoBai.TabIndex = 3;
            this.btnKhoBai.Text = "Kho bãi";
            this.btnKhoBai.UseVisualStyleBackColor = true;
            // 
            // btnKhuVuc
            // 
            this.btnKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhuVuc.Location = new System.Drawing.Point(560, 165);
            this.btnKhuVuc.Name = "btnKhuVuc";
            this.btnKhuVuc.Size = new System.Drawing.Size(117, 95);
            this.btnKhuVuc.TabIndex = 4;
            this.btnKhuVuc.Text = "Khu vực";
            this.btnKhuVuc.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(651, 390);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(96, 30);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // frmMangHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnKhuVuc);
            this.Controls.Add(this.btnKhoBai);
            this.Controls.Add(this.btnHopDongThanhToan);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.LabQLKB);
            this.Name = "frmMangHinhChinh";
            this.Text = "Quản lý kho bãi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabQLKB;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnHopDongThanhToan;
        private System.Windows.Forms.Button btnKhoBai;
        private System.Windows.Forms.Button btnKhuVuc;
        private System.Windows.Forms.Button btnDangXuat;
    }
}