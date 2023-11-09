using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDFBanKinhMat
{
    public partial class frm_SuaSanPham : Form
    {
        Classes.DataConnect data = new Classes.DataConnect();
        Classes.CBBox.CBBox function = new Classes.CBBox.CBBox();
        string query = "select top 1 MaSP from SanPham order by MaSP desc";
        Boolean hp;
        int i = 1;
        public static int SoLuong = 0;
        public static Decimal DonGiaNhap = 0;
        public static String TenSP = "";
        public static int flag = 0;

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public frm_SuaSanPham()
        {
            InitializeComponent();

            DataTable dtLoaiSP = data.ReadData("select * from LoaiSP");
            function.FillComboBox(cboLoaiSP, dtLoaiSP, "TenLoai", "MaLoai");

            DataTable dtChatLieu = data.ReadData("select * from ChatLieu");
            function.FillComboBox(cboChatieu, dtChatLieu, "TenCL", "MaCL");

            DataTable dtMauSac = data.ReadData("select * from Mau");
            function.FillComboBox(cboMau, dtMauSac, "TenMau", "MaMau");

            DataTable dtDangMat = data.ReadData("select * from HinhDangMat");
            function.FillComboBox(cboHinhDangMat, dtDangMat, "TenDangmat", "MaDangMat");

            tmr.Start();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (hp)
            {
                if (lblMesseage.Width + lblMesseage.Left > 0)
                {
                    lblMesseage.Left -= 5;
                }
                else
                {
                    hp = false;
                }
            }
            else
            {
                if (lblMesseage.Left < 300)
                {
                    lblMesseage.Left += 5;
                }
                else
                {
                    hp = true;
                }
            }
        }

        private void frm_SuaSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = data.ReadData("Select * from SanPham where MaSP = " + frm_SanPham.MaSP);
            cboLoaiSP.SelectedValue = dt.Rows[0]["MaLoai"].ToString();
            txtTenSP.Text = dt.Rows[0]["TenSP"].ToString();
            cboChatieu.SelectedValue = dt.Rows[0]["MaCL"].ToString();
            cboMau.SelectedValue = dt.Rows[0]["MaMau"].ToString();
            nmrSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
            cboHinhDangMat.SelectedValue = dt.Rows[0]["MaDangMat"].ToString();
            txtDonGiaNhap.Text = dt.Rows[0]["DonGiaNhap"].ToString();
            txtDonGiaBan.Text = dt.Rows[0]["DonGiaBan"].ToString();
            lblMesseage.Text = txtTenSP.Text  + "           Mã: " + dt.Rows[0]["MaSP"].ToString();
            hp = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                strSql = "Update SanPham SET ";
                strSql += "TenSP = N'" + txtTenSP.Text + "',";
                strSql += "MaLoai = '" + cboLoaiSP.SelectedValue.ToString() + "',";
                strSql += "MaCL = '" + cboChatieu.SelectedValue.ToString() + "',";
                strSql += "MaMau = N'" + cboMau.SelectedValue.ToString() + "',";
                strSql += "MaDangMat = '" + cboHinhDangMat.SelectedValue.ToString() + "',";
                strSql += "SoLuong = N'" + nmrSoLuong.Value.ToString() + "', ";
                strSql += "DonGiaNhap = N'" + txtDonGiaNhap.Text + "', ";
                strSql += "DonGiaBan = N'" + txtDonGiaBan.Text + "' ";
                strSql += "Where MaSP = '" + frm_SanPham.MaSP + "'";
                data.ChangeData(strSql);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
