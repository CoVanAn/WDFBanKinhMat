using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDFBanKinhMat
{
    public partial class frm_ThemSanPham : Form
    {
        Classes.DataConnect data = new Classes.DataConnect();
        Classes.CBBox.CBBox function = new Classes.CBBox.CBBox();

        String FileName = "", Extension = "", NamePic = "";
        
        public static int SoLuong = 0;
        public static Decimal DonGiaNhap = 0;
        public static String TenSP = "";
        public static int flag = 0;

        //
        // TRUYỀN DỮ LIỆU VÀO COMBOBOX
        //

        public frm_ThemSanPham()
        {
            InitializeComponent();

            DataTable dtLoaiSP = data.ReadData("select * from LoaiSP");
            function.FillComboBox(cboLoaiSP, dtLoaiSP, "TenLoai", "MaLoai");

            DataTable dtChatLieu = data.ReadData("select * from ChatLieu");
            function.FillComboBox(cboCL, dtChatLieu, "TenCL", "MaCL");

            DataTable dtMauSac = data.ReadData("select * from Mau");
            function.FillComboBox(cboMau, dtMauSac, "TenMau", "MaMau");

            DataTable dtDangMat = data.ReadData("select * from HinhDangMat");
            function.FillComboBox(cboHinhDangMat, dtDangMat, "TenDangmat", "MaDangMat");
        }

        //
        //  TỰ ĐỘNG TẠO MÃ SP
        //

        private void frm_ThemSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Text = frm_SanPham.MaSP.ToString();
            txtMaSP.Enabled = false;
        }

        //
        //  MỞ FILE + CHỌN ẢNH 
        //

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG|*.jpg";
            dlgOpen.FilterIndex = 1;
            dlgOpen.Title = "Chọn ảnh cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                FileName = dlgOpen.FileName;
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                Extension = Path.GetExtension(dlgOpen.FileName);
                NamePic = frm_SanPham.MaSP.ToString() + Extension;
            }
        }

        //
        //  ĐÓNG CHỨC NĂNG THÊM
        //

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //  THÊM SẢN PHẨM MỚI 
        //

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strSql = "";          
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (txtDonGiaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng ghi đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng ghi đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            try
            {
                strSql = "INSERT INTO SanPham(MaSP, TenSP, MaLoai, MaCL, MaMau, MaDangMat, SoLuong, DonGiaNhap, DonGiaBan, Anh) VALUES(";
                strSql += "N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + cboLoaiSP.SelectedValue.ToString() + "','" + cboCL.SelectedValue.ToString() + "',N'"
                    + cboMau.SelectedValue.ToString()   + "',N'" + cboHinhDangMat.SelectedValue.ToString() + "',N'" + nmrSoLuong.Value.ToString() + "',N'" + txtDonGiaNhap.Text + "',N'"
                    + txtDonGiaBan.Text + "',N'" + NamePic + "')";

                data.ChangeData(strSql);
                File.Copy(FileName, Environment.CurrentDirectory + "/../../Anh/" + NamePic);
                //Image.FromFile(Environment.CurrentDirectory + "/../../Anh/" + NamePic).Dispose();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);          
                picAnh.Refresh();
                flag = 1;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }
    }
}
