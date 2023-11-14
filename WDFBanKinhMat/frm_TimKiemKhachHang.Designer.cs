namespace WDFBanKinhMat
{
    partial class frm_TimKiemKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkThang = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.txtSDTTim = new System.Windows.Forms.TextBox();
            this.txtTenTim = new System.Windows.Forms.TextBox();
            this.cbxMaTim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnMoi);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(450, 32);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 48);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(312, 32);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(98, 48);
            this.btnMoi.TabIndex = 1;
            this.btnMoi.Text = "Làm Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(17, 32);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(207, 48);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkThang);
            this.groupBox2.Controls.Add(this.chkNam);
            this.groupBox2.Controls.Add(this.chkNgay);
            this.groupBox2.Controls.Add(this.txtSDTTim);
            this.groupBox2.Controls.Add(this.txtTenTim);
            this.groupBox2.Controls.Add(this.cbxMaTim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 353);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // chkThang
            // 
            this.chkThang.AutoSize = true;
            this.chkThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThang.Location = new System.Drawing.Point(17, 248);
            this.chkThang.Name = "chkThang";
            this.chkThang.Size = new System.Drawing.Size(314, 29);
            this.chkThang.TabIndex = 5;
            this.chkThang.Text = "Đã Mua Hàng Trong Tháng Này";
            this.chkThang.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNam.Location = new System.Drawing.Point(17, 299);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(298, 29);
            this.chkNam.TabIndex = 5;
            this.chkNam.Text = "Đã Mua Hàng Trong Năm Nay";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // chkNgay
            // 
            this.chkNgay.AutoSize = true;
            this.chkNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNgay.Location = new System.Drawing.Point(17, 194);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(298, 29);
            this.chkNgay.TabIndex = 5;
            this.chkNgay.Text = "Đã Mua Hàng Trong Hôm Nay";
            this.chkNgay.UseVisualStyleBackColor = true;
            this.chkNgay.CheckedChanged += new System.EventHandler(this.chkNgay_CheckedChanged);
            // 
            // txtSDTTim
            // 
            this.txtSDTTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTTim.Location = new System.Drawing.Point(250, 141);
            this.txtSDTTim.Name = "txtSDTTim";
            this.txtSDTTim.Size = new System.Drawing.Size(309, 30);
            this.txtSDTTim.TabIndex = 3;
            // 
            // txtTenTim
            // 
            this.txtTenTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTim.Location = new System.Drawing.Point(250, 92);
            this.txtTenTim.Name = "txtTenTim";
            this.txtTenTim.Size = new System.Drawing.Size(309, 30);
            this.txtTenTim.TabIndex = 2;
            // 
            // cbxMaTim
            // 
            this.cbxMaTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaTim.FormattingEnabled = true;
            this.cbxMaTim.Location = new System.Drawing.Point(250, 39);
            this.cbxMaTim.Name = "cbxMaTim";
            this.cbxMaTim.Size = new System.Drawing.Size(309, 33);
            this.cbxMaTim.TabIndex = 1;
            this.cbxMaTim.SelectedIndexChanged += new System.EventHandler(this.cbxMaTim_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm Kiếm Theo SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm Theo Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo Mã:";
            // 
            // frm_TimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TimKiemKhachHang";
            this.Text = "Tìm Kiếm Khách Hàng";
            this.Load += new System.EventHandler(this.frm_TimKiemKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSDTTim;
        private System.Windows.Forms.TextBox txtTenTim;
        private System.Windows.Forms.ComboBox cbxMaTim;
        private System.Windows.Forms.CheckBox chkNgay;
        private System.Windows.Forms.CheckBox chkThang;
        private System.Windows.Forms.CheckBox chkNam;
    }
}