namespace WDFBanKinhMat
{
    partial class frm_HangHoa
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocLai = new System.Windows.Forms.Button();
            this.grbMauSac = new System.Windows.Forms.GroupBox();
            this.lstMau = new System.Windows.Forms.ListBox();
            this.grbChatLieu = new System.Windows.Forms.GroupBox();
            this.lstChatLieu = new System.Windows.Forms.ListBox();
            this.grbLoaiHang = new System.Windows.Forms.GroupBox();
            this.lstLoaiSP = new System.Windows.Forms.ListBox();
            this.grbMucGia = new System.Windows.Forms.GroupBox();
            this.rdo5001000 = new System.Windows.Forms.RadioButton();
            this.rdo300500 = new System.Windows.Forms.RadioButton();
            this.rdo100300 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.ctmnSanPham = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMau = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblChatLieu = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.grbMauSac.SuspendLayout();
            this.grbChatLieu.SuspendLayout();
            this.grbLoaiHang.SuspendLayout();
            this.grbMucGia.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ctmnSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnLocLai);
            this.panel1.Controls.Add(this.grbMauSac);
            this.panel1.Controls.Add(this.grbChatLieu);
            this.panel1.Controls.Add(this.grbLoaiHang);
            this.panel1.Controls.Add(this.grbMucGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 653);
            this.panel1.TabIndex = 0;
            // 
            // btnLocLai
            // 
            this.btnLocLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocLai.Location = new System.Drawing.Point(32, 591);
            this.btnLocLai.Name = "btnLocLai";
            this.btnLocLai.Size = new System.Drawing.Size(95, 31);
            this.btnLocLai.TabIndex = 8;
            this.btnLocLai.Text = "Lọc lại";
            this.btnLocLai.UseVisualStyleBackColor = true;
            this.btnLocLai.Click += new System.EventHandler(this.btnLocLai_Click);
            // 
            // grbMauSac
            // 
            this.grbMauSac.Controls.Add(this.lstMau);
            this.grbMauSac.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMauSac.Location = new System.Drawing.Point(0, 420);
            this.grbMauSac.Name = "grbMauSac";
            this.grbMauSac.Size = new System.Drawing.Size(166, 140);
            this.grbMauSac.TabIndex = 7;
            this.grbMauSac.TabStop = false;
            this.grbMauSac.Text = "Màu sắc";
            // 
            // lstMau
            // 
            this.lstMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMau.FormattingEnabled = true;
            this.lstMau.ItemHeight = 22;
            this.lstMau.Location = new System.Drawing.Point(3, 24);
            this.lstMau.Margin = new System.Windows.Forms.Padding(10);
            this.lstMau.Name = "lstMau";
            this.lstMau.Size = new System.Drawing.Size(160, 113);
            this.lstMau.TabIndex = 4;
            // 
            // grbChatLieu
            // 
            this.grbChatLieu.Controls.Add(this.lstChatLieu);
            this.grbChatLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChatLieu.Location = new System.Drawing.Point(0, 280);
            this.grbChatLieu.Name = "grbChatLieu";
            this.grbChatLieu.Size = new System.Drawing.Size(166, 140);
            this.grbChatLieu.TabIndex = 6;
            this.grbChatLieu.TabStop = false;
            this.grbChatLieu.Text = "Chất liệu";
            // 
            // lstChatLieu
            // 
            this.lstChatLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChatLieu.FormattingEnabled = true;
            this.lstChatLieu.ItemHeight = 22;
            this.lstChatLieu.Location = new System.Drawing.Point(3, 24);
            this.lstChatLieu.Margin = new System.Windows.Forms.Padding(10);
            this.lstChatLieu.Name = "lstChatLieu";
            this.lstChatLieu.Size = new System.Drawing.Size(160, 113);
            this.lstChatLieu.TabIndex = 4;
            // 
            // grbLoaiHang
            // 
            this.grbLoaiHang.Controls.Add(this.lstLoaiSP);
            this.grbLoaiHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoaiHang.Location = new System.Drawing.Point(0, 140);
            this.grbLoaiHang.Name = "grbLoaiHang";
            this.grbLoaiHang.Size = new System.Drawing.Size(166, 140);
            this.grbLoaiHang.TabIndex = 5;
            this.grbLoaiHang.TabStop = false;
            this.grbLoaiHang.Text = "Loại hàng";
            // 
            // lstLoaiSP
            // 
            this.lstLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLoaiSP.FormattingEnabled = true;
            this.lstLoaiSP.ItemHeight = 22;
            this.lstLoaiSP.Location = new System.Drawing.Point(3, 24);
            this.lstLoaiSP.Margin = new System.Windows.Forms.Padding(10);
            this.lstLoaiSP.Name = "lstLoaiSP";
            this.lstLoaiSP.Size = new System.Drawing.Size(160, 113);
            this.lstLoaiSP.TabIndex = 3;
            // 
            // grbMucGia
            // 
            this.grbMucGia.Controls.Add(this.rdo5001000);
            this.grbMucGia.Controls.Add(this.rdo300500);
            this.grbMucGia.Controls.Add(this.rdo100300);
            this.grbMucGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMucGia.Location = new System.Drawing.Point(0, 0);
            this.grbMucGia.Name = "grbMucGia";
            this.grbMucGia.Size = new System.Drawing.Size(166, 140);
            this.grbMucGia.TabIndex = 4;
            this.grbMucGia.TabStop = false;
            this.grbMucGia.Text = "Mức giá";
            // 
            // rdo5001000
            // 
            this.rdo5001000.AutoSize = true;
            this.rdo5001000.Location = new System.Drawing.Point(12, 89);
            this.rdo5001000.Name = "rdo5001000";
            this.rdo5001000.Size = new System.Drawing.Size(125, 26);
            this.rdo5001000.TabIndex = 7;
            this.rdo5001000.TabStop = true;
            this.rdo5001000.Text = "500k-1000k";
            this.rdo5001000.UseVisualStyleBackColor = true;
            // 
            // rdo300500
            // 
            this.rdo300500.AutoSize = true;
            this.rdo300500.Location = new System.Drawing.Point(12, 60);
            this.rdo300500.Name = "rdo300500";
            this.rdo300500.Size = new System.Drawing.Size(115, 26);
            this.rdo300500.TabIndex = 6;
            this.rdo300500.TabStop = true;
            this.rdo300500.Text = "300k-500k";
            this.rdo300500.UseVisualStyleBackColor = true;
            // 
            // rdo100300
            // 
            this.rdo100300.AutoSize = true;
            this.rdo100300.Location = new System.Drawing.Point(12, 31);
            this.rdo100300.Name = "rdo100300";
            this.rdo100300.Size = new System.Drawing.Size(115, 26);
            this.rdo100300.TabIndex = 5;
            this.rdo100300.TabStop = true;
            this.rdo100300.Text = "100k-300k";
            this.rdo100300.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lvSanPham);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 653);
            this.panel2.TabIndex = 1;
            // 
            // lvSanPham
            // 
            this.lvSanPham.ContextMenuStrip = this.ctmnSanPham;
            this.lvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.LargeImageList = this.imageList;
            this.lvSanPham.Location = new System.Drawing.Point(0, 140);
            this.lvSanPham.Margin = new System.Windows.Forms.Padding(10);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(866, 513);
            this.lvSanPham.TabIndex = 1;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            // 
            // ctmnSanPham
            // 
            this.ctmnSanPham.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmnSanPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSảnPhẩmToolStripMenuItem,
            this.sửaSảnPhẩmToolStripMenuItem,
            this.xóaSảnPhẩmToolStripMenuItem});
            this.ctmnSanPham.Name = "ctmnSanPham";
            this.ctmnSanPham.Size = new System.Drawing.Size(184, 76);
            // 
            // thêmSảnPhẩmToolStripMenuItem
            // 
            this.thêmSảnPhẩmToolStripMenuItem.Name = "thêmSảnPhẩmToolStripMenuItem";
            this.thêmSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.thêmSảnPhẩmToolStripMenuItem.Text = "Thêm sản phẩm";
            // 
            // sửaSảnPhẩmToolStripMenuItem
            // 
            this.sửaSảnPhẩmToolStripMenuItem.Name = "sửaSảnPhẩmToolStripMenuItem";
            this.sửaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.sửaSảnPhẩmToolStripMenuItem.Text = "Sửa sản phẩm";
            // 
            // xóaSảnPhẩmToolStripMenuItem
            // 
            this.xóaSảnPhẩmToolStripMenuItem.Name = "xóaSảnPhẩmToolStripMenuItem";
            this.xóaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.xóaSảnPhẩmToolStripMenuItem.Text = "Xóa sản phẩm";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblGiaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGiaBan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblTenSP);
            this.groupBox1.Controls.Add(this.lblMau);
            this.groupBox1.Controls.Add(this.lblMaSP);
            this.groupBox1.Controls.Add(this.lblChatLieu);
            this.groupBox1.Controls.Add(this.lblTheLoai);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Location = new System.Drawing.Point(663, 60);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(63, 22);
            this.lblGiaNhap.TabIndex = 33;
            this.lblGiaNhap.Text = "Mã SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(663, 31);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(63, 22);
            this.lblGiaBan.TabIndex = 31;
            this.lblGiaBan.Text = "Mã SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Giá nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Loại hàng:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(413, 89);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 22);
            this.lblSoLuong.TabIndex = 30;
            this.lblSoLuong.Text = "Mã SP";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(163, 60);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(63, 22);
            this.lblTenSP.TabIndex = 25;
            this.lblTenSP.Text = "Mã SP";
            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.Location = new System.Drawing.Point(413, 60);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(63, 22);
            this.lblMau.TabIndex = 29;
            this.lblMau.Text = "Mã SP";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(163, 31);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(63, 22);
            this.lblMaSP.TabIndex = 26;
            this.lblMaSP.Text = "Mã SP";
            // 
            // lblChatLieu
            // 
            this.lblChatLieu.AutoSize = true;
            this.lblChatLieu.Location = new System.Drawing.Point(413, 29);
            this.lblChatLieu.Name = "lblChatLieu";
            this.lblChatLieu.Size = new System.Drawing.Size(63, 22);
            this.lblChatLieu.TabIndex = 28;
            this.lblChatLieu.Text = "Mã SP";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(163, 89);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(63, 22);
            this.lblTheLoai.TabIndex = 27;
            this.lblTheLoai.Text = "Mã SP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(570, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Giá bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Chất liệu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Màu:";
            // 
            // frm_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_HangHoa";
            this.Text = "HangHoa";
            this.Load += new System.EventHandler(this.frm_HangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.grbMauSac.ResumeLayout(false);
            this.grbChatLieu.ResumeLayout(false);
            this.grbLoaiHang.ResumeLayout(false);
            this.grbMucGia.ResumeLayout(false);
            this.grbMucGia.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ctmnSanPham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbMauSac;
        private System.Windows.Forms.GroupBox grbChatLieu;
        private System.Windows.Forms.GroupBox grbLoaiHang;
        private System.Windows.Forms.GroupBox grbMucGia;
        private System.Windows.Forms.ListBox lstMau;
        private System.Windows.Forms.ListBox lstChatLieu;
        private System.Windows.Forms.ListBox lstLoaiSP;
        private System.Windows.Forms.Button btnLocLai;
        private System.Windows.Forms.RadioButton rdo5001000;
        private System.Windows.Forms.RadioButton rdo300500;
        private System.Windows.Forms.RadioButton rdo100300;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblChatLieu;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip ctmnSanPham;
        private System.Windows.Forms.ToolStripMenuItem thêmSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSảnPhẩmToolStripMenuItem;
    }
}