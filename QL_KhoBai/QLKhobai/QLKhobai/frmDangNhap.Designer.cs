using System;
using System.Windows.Forms;
namespace QLKhobai
{
    partial class FrmDangNhap
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
            System.Windows.Forms.CheckBox chbxShowPass;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatkhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDangnhap = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            chbxShowPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbxShowPass
            // 
            chbxShowPass.AutoSize = true;
            chbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            chbxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chbxShowPass.Location = new System.Drawing.Point(124, 73);
            chbxShowPass.Margin = new System.Windows.Forms.Padding(2);
            chbxShowPass.Name = "chbxShowPass";
            chbxShowPass.Size = new System.Drawing.Size(114, 19);
            chbxShowPass.TabIndex = 26;
            chbxShowPass.Text = "Show Password";
            chbxShowPass.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(chbxShowPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTendangnhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbMatkhau);
            this.panel1.Location = new System.Drawing.Point(14, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 94);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txbTendangnhap
            // 
            this.txbTendangnhap.Location = new System.Drawing.Point(124, 12);
            this.txbTendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.txbTendangnhap.Name = "txbTendangnhap";
            this.txbTendangnhap.Size = new System.Drawing.Size(176, 20);
            this.txbTendangnhap.TabIndex = 0;
            this.txbTendangnhap.Text = "admin";
            this.txbTendangnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txbMatkhau
            // 
            this.txbMatkhau.Location = new System.Drawing.Point(124, 49);
            this.txbMatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txbMatkhau.Name = "txbMatkhau";
            this.txbMatkhau.Size = new System.Drawing.Size(176, 20);
            this.txbMatkhau.TabIndex = 1;
            this.txbMatkhau.Text = "123456";
            this.txbMatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMatkhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(113, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "ĐĂNG NHẬP";
            // 
            // BtnDangnhap
            // 
            this.BtnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnDangnhap.Location = new System.Drawing.Point(48, 183);
            this.BtnDangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDangnhap.Name = "BtnDangnhap";
            this.BtnDangnhap.Size = new System.Drawing.Size(117, 32);
            this.BtnDangnhap.TabIndex = 28;
            this.BtnDangnhap.Text = "Đăng Nhập";
            this.BtnDangnhap.UseVisualStyleBackColor = true;
            this.BtnDangnhap.Click += new System.EventHandler(this.BtnDangnhap_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnThoat.Location = new System.Drawing.Point(196, 183);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(98, 32);
            this.BtnThoat.TabIndex = 29;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(362, 224);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnDangnhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatkhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDangnhap;
        private System.Windows.Forms.Button BtnThoat;
    }
}

