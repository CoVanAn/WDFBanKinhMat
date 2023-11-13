using Base_Form_1.Classes;
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
    public partial class frm_TimKiem : Form
    {
        DataConnect data = new DataConnect();
        Classes.CBBox.CBBox cbx;
        frm_NhanVien frm_NhanVien;

        void NhapLai()
        {
            txtMaNhanVienTim.Text = "";
            txtTenNhanVienTim.Text = "";
            cbxCongViecTim.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        bool GetGioiTinh()
        {
            if (rdoNam.Checked == true)
            {
                return true;
            }
            else { return false; }
        }

        public frm_TimKiem(frm_NhanVien NhanVien)
        {
            InitializeComponent();
            cbx = new Classes.CBBox.CBBox();
            DataTable dtCV = data.ReadData("select * from CongViec");
            cbx.FillComboBox(cbxCongViecTim,dtCV,"TenCV","MaCV");
            frm_NhanVien = NhanVien;
            NhapLai();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string find = "select MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV where MaNV is not null ";
            if (txtMaNhanVienTim.Text.Trim().Length > 0)
            {
                find += "and MaNV ='"+txtMaNhanVienTim.Text+"'";
            }
            if (txtTenNhanVienTim.Text.Trim().Length > 0)
            {
                find += "and TenNV ='" + txtTenNhanVienTim.Text + "'";
            }
            if (cbxCongViecTim.Text != "")
            {
                find += "and NhanVien.MaCV ='" + cbxCongViecTim.SelectedValue.ToString() + "'";
            }
            if (rdoNam.Checked == true || rdoNu.Checked == true)
            {
                find += "and GioiTinh ='" + GetGioiTinh().ToString() + "'";
            }

            frm_NhanVien.Tim(find);
            this.Close();
        }

        private void frm_TimKiem_Load(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCongViecTim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
