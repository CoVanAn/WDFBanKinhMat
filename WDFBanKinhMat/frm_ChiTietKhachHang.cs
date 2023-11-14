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
using WDFBanKinhMat.Classes.CBBox;

namespace WDFBanKinhMat
{
    public partial class frm_ChiTietKhachHang : Form
    {
        DataConnect data = new DataConnect();
        CBBox CBBox = new CBBox();
        frm_KhachHangMoi KhachHang;
        string Ma;

        public frm_ChiTietKhachHang(frm_KhachHangMoi frm_KhachHangMoi, string MaKH)
        {
            
            InitializeComponent();
            KhachHang = frm_KhachHangMoi;
            Ma = MaKH;
            LoadData();
            Xem(false);
            txtMaKhach.Enabled = false;
        }

        private void frm_ChiTietKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            //MessageBox.Show(Ma);
            string sql = "select MaKH, TenKH, DienThoai, DiaChi, Email from KhachHang where MaKH = '"+Ma+"'";
            DataTable dt = data.ReadData(sql);
            try
            {
                txtMaKhach.Text = dt.Rows[0]["MaKH"].ToString();
                txtTenKhach.Text = dt.Rows[0]["TenKH"].ToString();
                txtSDTKhach.Text = dt.Rows[0]["DienThoai"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmailKhach.Text = dt.Rows[0]["Email"].ToString();
            }
            catch 
            {
                MessageBox.Show("Lỗi");
                this.Close();
            }


        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void Xem(bool tt)
        {
            
            txtTenKhach.Enabled = tt;
            txtDiaChi.Enabled = tt;
            txtEmailKhach.Enabled = tt;
            txtSDTKhach.Enabled = tt;

            btnChinhSua.Enabled = !tt;
            btnXoa.Enabled = !tt;

            btnXacNhan.Enabled = tt;
            btnXacNhan.Visible = tt;
            btnHuy.Enabled = tt;
            btnHuy.Visible = tt;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            Xem(false);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Xem(true);
            txtTenKhach.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn cập nhật thông tin khách hàng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    
                    string update = "UPDATE KhachHang SET TenKH = N'" + txtTenKhach.Text + "', DienThoai = '"+ txtSDTKhach.Text + "', DiaChi = N'" + txtDiaChi.Text + "', Email = N'" + txtEmailKhach.Text + "' WHERE MaKH ='" + txtMaKhach.Text + "'";
                    data.ChangeData(update);
                    
                    KhachHang.LoadData();
                    MessageBox.Show("Cập Nhật Thành Công!");
                    LoadData();
                    Xem(false);

                }
                
                catch 
                {
                    MessageBox.Show("Cập Nhật Thất Bại");
                }
                
            }
            else
            {
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn XÓA thông tin khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string luu = txtMaKhach.Text;
                    string sqlDelete = "delete from KhachHang where MaKH='" + txtMaKhach.Text + "'";
                    data.ChangeData(sqlDelete);
                    

                    ///LoadDataF();
                    KhachHang.LoadData();
                    MessageBox.Show("Xóa Thành Công khách hàng có mã " + luu);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại");
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
