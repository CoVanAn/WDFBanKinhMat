using Base_Form_1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDFBanKinhMat.Classes.CBBox;

namespace WDFBanKinhMat
{
    public partial class frm_NhanVien : Form
    {
        DataConnect data = new DataConnect();
        CBBox cbBox;
        public frm_NhanVien()
        {
            InitializeComponent();
            cbBox = new CBBox();
            DataTable dtCL = new DataTable();
            dtCL = data.ReadData("Select * from CongViec");
            DataTable dt = data.ReadData("select MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV");
            dgvNhanVien.DataSource = dt;
            cbBox.FillComboBox(cboCongViec, dtCL, "TenCV", "MaCV");
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            btnHuy.Visible = false;
            btnHuy.Enabled = false;
            btnXacNhan.Visible = false;
            btnXacNhan.Enabled = false;
        }

        void EnableChucNang()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnTimKiem.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Visible = false;
            btnHuy.Enabled = false;
            btnXacNhan.Visible = false;
            btnXacNhan.Enabled = false;
        }
        void DisableChucNang()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnTimKiem.Enabled = false;
            btnXoa.Enabled = false;
        }

        void KhongTuongTac()
        {
            btnTimKiem.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled= false;
        }
        void TuongTac()
        {
            btnTimKiem.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        public void Tim(string sqlFind)
        {
            DataTable dt = data.ReadData(sqlFind);
            dgvNhanVien.DataSource = dt;
        }

        bool checkForm()
        {
            bool check = true;
            if(txtMaNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Ma Nhan Vie la bat buoc");
                txtMaNhanVien.Focus();
                return false;

            }
            return check;
        }



        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            //btnSua.Visible = false;
            //btnSua.Enabled=false;
        }

        int GetGioiTinh(ComboBox cbo)
        {
            int i = 0;
            if (cbo.SelectedValue == "Nam")
            {
                i = 1;
            }
            else
            {
                i = 0;
            }


            return i;
        }

        public void LoadData()
        {

            DataTable dt = data.ReadData("select MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai, TenCV from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV");
            dgvNhanVien.DataSource = dt;

            //KhongTuongTac();

            /*dgvNhanVien.Columns[0].HeaderText = "ma";
            dgvNhanVien.Columns[1].HeaderText = "Ten";
            dgvNhanVien.Columns[2].HeaderText = "gioi tinh";
            dgvNhanVien.Columns[3].HeaderText = "ngay sinh";
            dgvNhanVien.Columns[4].HeaderText = "dia chi";
            dgvNhanVien.Columns[6].HeaderText = "dien thoai";*/

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            //frm_ThemNhanVien frm_ThemNhanVien = new frm_ThemNhanVien(this);
            //frm_ThemNhanVien.ShowDialog();
        }

        private void cboCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TuongTac();
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            //Dme 1 tieng cua t

            string[] date = dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Split('/');
            //MessageBox.Show(date[0] + " " + date[1] + " " + date[2]);

            string ngay = "" + date[1] + "/" + date[0] + "/" + date[2];

            //dtNgaySinh.Value= DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString());
            //string ngay = "" + DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString()).Day.ToString() + "/" + DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString()).Month.ToString()+"/"+ DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString()).Year.ToString()+"";
            dtNgaySinh.Value = Convert.ToDateTime(ngay);
            //String.Format("{0:MM/dd/yyyy}", dtNgaySinh);
            //MessageBox.Show(DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString()).Day.ToString());
            txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            cboCongViec.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtDiaCHi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon xoa ?", "co hay k", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sqlDelete = "delete from NhanVien where MaNV='" + txtMaNhanVien.Text + "'";
                    data.ChangeData(sqlDelete);
                    MessageBox.Show("");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Khong the xoa do co hoa don");
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
            btnXacNhan.Visible = true;
            btnHuy.Visible = true;
            btnHuy.Enabled = true;
            DisableChucNang();
            //string update = "UPDATE NhanVien SET TenKH = N'"+txtTenNhanVien.Text.ToString()+"', GioiTinh ="+ cboGioiTinh.SelectedValue.ToString()+" WHERE MaNV = '"+txtMaNhanVien.Text.ToString()+"'";


        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string update = "UPDATE NhanVien SET TenNV = N'" + txtTenNhanVien.Text.ToString()+"' WHERE MaNV = '" + txtMaNhanVien.Text.ToString() + "'";
            if(MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.ChangeData(update);
            }
            LoadData();




            //EnableChucNang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {



            //EnableChucNang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_TimKiem frm_TimKiem = new frm_TimKiem(this);
            frm_TimKiem.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
