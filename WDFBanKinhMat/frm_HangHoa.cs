﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDFBanKinhMat.BLL;

namespace WDFBanKinhMat
{
    public partial class frm_HangHoa : Form
    {
        Classes.CBBox.CBBox function = new Classes.CBBox.CBBox();
        Classes.DataConnect data = new Classes.DataConnect();
        Decimal GiaBanTu = 0, GiaBanDen = 10000000;
        int MaLoai = 0, MaMau = 0, MaCL = 0, MaDangMat = 0;
        string find;
        public frm_HangHoa()
        {
            InitializeComponent();
            DataTable dtLoaiSP = data.ReadData("select * from LoaiSP");
            function.FillListBox(lstLoaiSP, dtLoaiSP, "TenLoai", "MaLoai");

            DataTable dtChatLieu = data.ReadData("select * from ChatLieu");
            function.FillListBox(lstChatLieu, dtChatLieu, "TenCL", "MaCL");

            DataTable dtMauSac = data.ReadData("select * from Mau");
            function.FillListBox(lstMau, dtMauSac, "TenMau", "MaMau");

            DataTable dtDangMat = data.ReadData("select * from HinhDangMat");
            function.FillListBox(lstDangMat, dtDangMat, "TenDangmat", "MaDangMat");
        }

        // HIỆN CH
        
        private void lvSanPham_Click(object sender, EventArgs e)
        {
            ListViewItem itemselect = lvSanPham.SelectedItems[0];
            int MaSP = int.Parse(itemselect.Name);
            DataTable dt = data.ReadData("Select * from SanPham where MaSP = " + MaSP);
            lblMaSP.Text = dt.Rows[0]["MaSP"].ToString();
            lblTenSP.Text = dt.Rows[0]["TenSP"].ToString();
            lblLoaiSP.Text = dt.Rows[0]["MaLoai"].ToString();
            lblChatLieu.Text = dt.Rows[0]["MaCL"].ToString();
            lblMau.Text = dt.Rows[0]["MaMau"].ToString();
            lblSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
            lblDangMat.Text = dt.Rows[0]["MaDangMat"].ToString();
            lblGiaBan.Text = dt.Rows[0]["DonGiaBan"].ToString();
            lblGiaNhap.Text = dt.Rows[0]["DonGiaNhap"].ToString();
        }
        private void TimKiemSanPham(Decimal GiaTu, Decimal GiaDen, int MaLoai, int MaMau, int MaCL, int DangMat)
        {
            find = "where DonGiaBan > " + GiaTu.ToString() + " and DonGiaBan < " + GiaDen.ToString();
            if (MaLoai != 0)
            {
                find = find + " and MaLoai = " + MaLoai;
            }
            if (MaCL != 0)
            {
                find = find + " and MaCL = " + MaCL;
            }
            if (MaMau != 0)
            {
                find = find + " and MaMau = " + MaMau;
            }
            if(DangMat != 0)
            {
                find = find + " and MaDangMat = " + DangMat;

            }
            DocDuLieu(find);
        }
        private void DocDuLieu(string find)
        {
            lvSanPham.Items.Clear();
            imageList.Images.Clear();
            DataTable dt = data.ReadData("Select * from SanPham " + find);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                imageList.ImageSize = new Size(130, 130);
                imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/../../Anh/" + dt.Rows[i]["Anh"].ToString()));
                ListViewItem item = new ListViewItem();
                item.Name = dt.Rows[i]["MaSP"].ToString();
                item.Text = dt.Rows[i]["TenSP"].ToString();
                item.ImageIndex = i;
                lvSanPham.Items.Add(item);
            }
            Console.WriteLine(lvSanPham.Items.Count);
        }
        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            DocDuLieu("");
            lstChatLieu.SelectedIndex = -1;
            lstMau.SelectedIndex = -1;
            lstLoaiSP.SelectedIndex = -1;
            lstDangMat.SelectedIndex = -1;
        }
        private void rdo100300_Click(object sender, EventArgs e)
        {
            GiaBanTu = 100000;
            GiaBanDen = 300001;
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void rdo300500_Click(object sender, EventArgs e)
        {
            GiaBanTu = 300000;
            GiaBanDen = 500001;
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void rdo5001000_Click(object sender, EventArgs e)
        {
            GiaBanTu = 500000;
            GiaBanDen = 1000001;
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }

        private void lstLoaiSP_Click(object sender, EventArgs e)
        {
            MaLoai = int.Parse(lstLoaiSP.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void lstChatLieu_Click(object sender, EventArgs e)
        {
            MaCL = int.Parse(lstChatLieu.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void lstMau_Click(object sender, EventArgs e)
        {
            MaMau = int.Parse(lstMau.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void lstDangMat_Click(object sender, EventArgs e)
        {
            MaDangMat = int.Parse(lstDangMat.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void menuitemThemSP_Click(object sender, EventArgs e)
        {

        }

        private void menuitemSuaSP_Click(object sender, EventArgs e)
        {

        }

        private void menuitemXoaSP_Click(object sender, EventArgs e)
        {

        }
        
        private void btnLocLai_Click(object sender, EventArgs e)
        {
            lstChatLieu.SelectedIndex = -1;
            lstMau.SelectedIndex = -1;
            lstLoaiSP.SelectedIndex = -1;
            lstDangMat.SelectedIndex = -1;
            MaCL = MaLoai = MaMau = 0;
            GiaBanTu = 0;
            GiaBanDen = 10000000;
            rdo100300.Checked = false;
            rdo300500.Checked = false;
            rdo5001000.Checked = false;
            DocDuLieu("");   
        }
    }
}
