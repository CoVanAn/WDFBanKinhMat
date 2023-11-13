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
    public partial class frm_NhanVienMoi : Form
    {
        DataConnect data = new DataConnect();
        Classes.CBBox.CBBox cbBox = new Classes.CBBox.CBBox();

        public frm_NhanVienMoi()
        {

            InitializeComponent();
            DataTable dtCV = data.ReadData("select * from CongViec");
            dtCV.Rows.Add("10000", "Tất cả");
            cbBox.FillComboBox(cbxCongViec, dtCV, "TenCV", "MaCV");
            
        }

        private void frm_NhanVienMoi_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvThongTinNV.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvThongTinNV.Columns[0].Width = 100;
            dgvThongTinNV.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvThongTinNV.Columns[1].Width = 250;
            dgvThongTinNV.Columns[2].HeaderText = "Chức Vụ";
            dgvThongTinNV.Columns[2].Width = 350;

        }

        public void LoadData()
        {
            DataTable dt = data.ReadData("select MaNV, TenNV, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV");
            dgvThongTinNV.DataSource = dt;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (txtMa.Text != "")
            {
                string Select = "select MaNV, TenNV, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV where MaNV like '" + txtMa.Text + "%'";
                DataTable dtSl = data.ReadData(Select);
                dgvThongTinNV.DataSource = dtSl;
            }
            else 
            {
                LoadData();
            }
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if(txtTen.Text != "")
            {
                string Select = "select MaNV, TenNV, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV where TenNV like N'%" + txtTen.Text + "%'";
                DataTable dtSl = data.ReadData(Select);
                dgvThongTinNV.DataSource = dtSl;
            }
            else { LoadData(); }
        }

        private void cbxCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///MessageBox.Show(cbxCongViec.Text);
            if (cbxCongViec.Text != "Tất cả")
            {
                
                string Select = "select MaNV, TenNV, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV where TenCV like N'%" + cbxCongViec.Text + "%'";
                DataTable dt = data.ReadData(Select);
                dgvThongTinNV.DataSource = dt;
            }
            else
            {
                LoadData();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frm_ThemNhanVien Them = new frm_ThemNhanVien(this);
            Them.ShowDialog();
            
        }

        private void dgvThongTinNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ChiTietNhanVien NhanVien = new frm_ChiTietNhanVien(dgvThongTinNV.CurrentRow.Cells[0].Value.ToString(), this);
            NhanVien.ShowDialog();
        }

        private void dgvThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
