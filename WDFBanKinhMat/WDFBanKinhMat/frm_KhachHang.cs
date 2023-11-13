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
    public partial class frm_KhachHang : Form
    {
        DataConnect data = new DataConnect();
        Classes.CBBox.CBBox cbBox;
        

        public frm_KhachHang()
        {
            InitializeComponent();
            cbBox = new Classes.CBBox.CBBox();
            DataTable dt = data.ReadData("select * from KhachHang");
            dgvKhachHang.DataSource = dt;

        }

        void LamMoi()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtSDTKhach.Text = "";
            txtDiaChi.Text = "";
            txtEmailKhach.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            LamMoi();
            DataTable dt = data.ReadData("select MaKH, TenKH, DiaChi, DienThoai, Email from KhachHang");
            dgvKhachHang.DataSource = dt;
        }
        public void LoadTim(string str)
        {
            DataTable dt = data.ReadData(str);
            dgvKhachHang.DataSource= dt;
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKhach_Click(object sender, EventArgs e)
        {
            frm_TimKiemKhachHang Khach = new frm_TimKiemKhachHang(this);
            Khach.ShowDialog();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();

            txtTenKhach.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSDTKhach.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmailKhach.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSuaKhach_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon xoa khong?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sqlDelete = "delete from KhachHang where MaKH='" + txtMaKhach.Text + "'";
                    data.ChangeData(sqlDelete);
                    MessageBox.Show("Xoa thanh cong");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Khong the xoa do khach da mua hang");
                }
            }
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            //frm_ThemKhachHang frm_ThemKhach = new frm_ThemKhachHang(this);
            //frm_ThemKhach.ShowDialog();
        }
    }
}
