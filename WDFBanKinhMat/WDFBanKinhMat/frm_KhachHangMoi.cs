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
    public partial class frm_KhachHangMoi : Form
    {
        DataConnect data = new DataConnect();
        Classes.CBBox.CBBox cbBox = new Classes.CBBox.CBBox();

        public frm_KhachHangMoi()
        {
            InitializeComponent();
            LoadData();

            
        }

        private void frm_KhachHangMoi_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            string sql = "select MaKH, TenKH, DienThoai, Email from KhachHang";
            DataTable dt = data.ReadData(sql);
            dgvThongTinKH.DataSource = dt;
        }

        void TimKiemChung()
        {
            //frm_ChiTietKhachHang KhachHang = new frm_ChiTietKhachHang(this, txtMa.Text);
        }



        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frm_ThemKhachHang them = new frm_ThemKhachHang(this);
            them.ShowDialog();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if(txtTen.Text.Trim() != "" || txtMa.Text.Trim() != "" || txtSDT.Text.Trim() != "")
            {
                string select = "select MaKH, TenKH, DienThoai, Email from KhachHang where MaKH like '%"+txtMa.Text+"%' and TenKH like N'%"+txtTen.Text+"%' and DienThoai like '%"+txtSDT.Text+"%'";
                DataTable dt = data.ReadData(select);
                dgvThongTinKH .DataSource = dt;
            }
            else
            {
                LoadData();
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "" || txtMa.Text.Trim() != "" || txtSDT.Text.Trim() !="")
            {
                //string select = "select MaKH, TenKH, DienThoai, Email from KhachHang where TenKH like N'%" + txtTen.Text + "%'";
                string select = "select MaKH, TenKH, DienThoai, Email from KhachHang where MaKH like '%" + txtMa.Text + "%' and TenKH like N'%" + txtTen.Text + "%' and DienThoai like '%" + txtSDT.Text + "%'";
                DataTable dt = data.ReadData(select);
                dgvThongTinKH.DataSource = dt;
            }
            else
            {
                LoadData();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            if (txtTen.Text.Trim() != "" || txtMa.Text.Trim() != "" || txtSDT.Text.Trim() != "")
            {
                //string select = "select MaKH, TenKH, DienThoai, Email from KhachHang where DienThoai like '%" + txtSDT.Text + "%'";
                string select = "select MaKH, TenKH, DienThoai, Email from KhachHang where MaKH like '%" + txtMa.Text + "%' and TenKH like N'%" + txtTen.Text + "%' and DienThoai like '%" + txtSDT.Text + "%'";
                DataTable dt = data.ReadData(select);
                dgvThongTinKH.DataSource = dt;
            }
            else
            {
                LoadData();
            }
        }

        private void dgvThongTinKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frm_ChiTietKhachHang KhachHang = new frm_ChiTietKhachHang(this, dgvThongTinKH.CurrentRow.Cells[0].Value.ToString());
                KhachHang.ShowDialog();
            }
            catch { }
        }

        private void dgvThongTinKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
