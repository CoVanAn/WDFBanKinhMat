﻿namespace WDFBanKinhMat
{
    partial class frm_DanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnChatLieu = new System.Windows.Forms.Button();
            this.btnMauSac = new System.Windows.Forms.Button();
            this.btnDangMat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btmTaiLai = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.colMaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(306, 39);
            this.lblTieuDe.TabIndex = 11;
            this.lblTieuDe.Text = "BẢNG DANH MỤC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.BackColor = System.Drawing.Color.Teal;
            this.btnLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSP.Location = new System.Drawing.Point(107, 105);
            this.btnLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(140, 66);
            this.btnLoaiSP.TabIndex = 21;
            this.btnLoaiSP.Text = "Loại sản phẩm";
            this.btnLoaiSP.UseVisualStyleBackColor = false;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnChatLieu
            // 
            this.btnChatLieu.BackColor = System.Drawing.Color.Teal;
            this.btnChatLieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatLieu.ForeColor = System.Drawing.Color.White;
            this.btnChatLieu.Location = new System.Drawing.Point(380, 105);
            this.btnChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChatLieu.Name = "btnChatLieu";
            this.btnChatLieu.Size = new System.Drawing.Size(140, 66);
            this.btnChatLieu.TabIndex = 22;
            this.btnChatLieu.Text = "Chất liệu";
            this.btnChatLieu.UseVisualStyleBackColor = false;
            this.btnChatLieu.Click += new System.EventHandler(this.btnChatLieu_Click);
            // 
            // btnMauSac
            // 
            this.btnMauSac.BackColor = System.Drawing.Color.Teal;
            this.btnMauSac.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMauSac.ForeColor = System.Drawing.Color.White;
            this.btnMauSac.Location = new System.Drawing.Point(655, 105);
            this.btnMauSac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMauSac.Name = "btnMauSac";
            this.btnMauSac.Size = new System.Drawing.Size(140, 66);
            this.btnMauSac.TabIndex = 23;
            this.btnMauSac.Text = "Màu sắc";
            this.btnMauSac.UseVisualStyleBackColor = false;
            this.btnMauSac.Click += new System.EventHandler(this.btnMauSac_Click);
            // 
            // btnDangMat
            // 
            this.btnDangMat.BackColor = System.Drawing.Color.Teal;
            this.btnDangMat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangMat.ForeColor = System.Drawing.Color.White;
            this.btnDangMat.Location = new System.Drawing.Point(879, 105);
            this.btnDangMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangMat.Name = "btnDangMat";
            this.btnDangMat.Size = new System.Drawing.Size(140, 66);
            this.btnDangMat.TabIndex = 24;
            this.btnDangMat.Text = "Dạng mắt";
            this.btnDangMat.UseVisualStyleBackColor = false;
            this.btnDangMat.Click += new System.EventHandler(this.btnDangMat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Location = new System.Drawing.Point(435, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 44);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnMauSac);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnLoaiSP);
            this.panel2.Controls.Add(this.btnDangMat);
            this.panel2.Controls.Add(this.btnChatLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 210);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btmTaiLai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(828, 210);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 543);
            this.panel3.TabIndex = 27;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.OliveDrab;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(63, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 71);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OliveDrab;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(63, 154);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 71);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoá ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(65, 380);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 66);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btmTaiLai
            // 
            this.btmTaiLai.BackColor = System.Drawing.Color.OliveDrab;
            this.btmTaiLai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTaiLai.ForeColor = System.Drawing.Color.White;
            this.btmTaiLai.Location = new System.Drawing.Point(63, 271);
            this.btmTaiLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmTaiLai.Name = "btmTaiLai";
            this.btmTaiLai.Size = new System.Drawing.Size(112, 71);
            this.btmTaiLai.TabIndex = 19;
            this.btmTaiLai.Text = "Tải lại";
            this.btmTaiLai.UseVisualStyleBackColor = false;
            this.btmTaiLai.Click += new System.EventHandler(this.btmTaiLai_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.dgvDanhMuc);
            this.panel4.Controls.Add(this.txtTenDanhMuc);
            this.panel4.Controls.Add(this.txtMaDanhMuc);
            this.panel4.Controls.Add(this.lblTen);
            this.panel4.Controls.Add(this.lblMa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 210);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 543);
            this.panel4.TabIndex = 28;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTL,
            this.colTenTL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvDanhMuc.Location = new System.Drawing.Point(126, 137);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(689, 309);
            this.dgvDanhMuc.TabIndex = 21;
            // 
            // colMaTL
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaTL.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaTL.HeaderText = "Mã hàng";
            this.colMaTL.MinimumWidth = 6;
            this.colMaTL.Name = "colMaTL";
            this.colMaTL.ReadOnly = true;
            this.colMaTL.Width = 110;
            // 
            // colTenTL
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenTL.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTenTL.HeaderText = "Tên hàng";
            this.colTenTL.MinimumWidth = 6;
            this.colTenTL.Name = "colTenTL";
            this.colTenTL.ReadOnly = true;
            this.colTenTL.Width = 250;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(248, 70);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(377, 28);
            this.txtTenDanhMuc.TabIndex = 20;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(248, 26);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(377, 28);
            this.txtMaDanhMuc.TabIndex = 19;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(128, 79);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(77, 20);
            this.lblTen.TabIndex = 18;
            this.lblTen.Text = "Tên loại:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.White;
            this.lblMa.Location = new System.Drawing.Point(128, 33);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(74, 20);
            this.lblMa.TabIndex = 17;
            this.lblMa.Text = "Mã loại:";
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DanhMuc";
            this.Text = "frm_DanhMuc";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.Button btnChatLieu;
        private System.Windows.Forms.Button btnMauSac;
        private System.Windows.Forms.Button btnDangMat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btmTaiLai;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTL;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
    }
}