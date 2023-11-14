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
    public partial class frm_ChiTietNhanVien : Form
    {
        DataConnect data = new DataConnect();
        CBBox CBBox = new CBBox();
        string Ma;
        frm_NhanVienMoi NhanVienMoi;

        public frm_ChiTietNhanVien(string MaNV, frm_NhanVienMoi NhanVien)
        {
            InitializeComponent();
            NhanVienMoi = NhanVien;
            Ma = MaNV;
            string cv = "select * from CongViec";
            DataTable dcv = data.ReadData(cv);
            CBBox.FillComboBox(cboCongViec, dcv, "TenCV", "MaCV");
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Text = MaNV;
            LoadDataF();

        }

        void LoadDataF()
        {
            string select = "select MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, TenCV, DiaChi from NhanVien join CongViec on NhanVien.MaCV = CongViec.MaCV where MaNV ='" + Ma + "'";
            DataTable dt = data.ReadData(select);
            //dgvTest.DataSource = dt;
            txtTenNhanVien.Text = dt.Rows[0][1].ToString();
            cboGioiTinh.Text = dt.Rows[0][2].ToString();



            //dtNgaySinh.Text = dt.Rows[0][3].ToString();
            //dtNgaySinh.Text =
            ///MessageBox.Show(string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(dt.Rows[0][3].ToString())));
            string[] date = dt.Rows[0]["NgaySinh"].ToString().Split('/');
            string ngay = "" + date[1] + "/" + date[0] + "/" + date[2];
            //MessageBox.Show(ngay);
            dtNgaySinh.Value = Convert.ToDateTime(ngay);
            txtDienThoai.Text = dt.Rows[0][4].ToString();
            cboCongViec.Text = dt.Rows[0][5].ToString();
            txtDiaCHi.Text = dt.Rows[0][6].ToString();
            Xem(false);
            /*btnXacNhan.Visible = false;
            btnXacNhan.Enabled = false;
            btnHuy.Visible = false;
            btnHuy.Enabled = false;*/
        }
        void Xem(bool tt)
        {
            //txtMaNhanVien.Enabled = tt;
            txtTenNhanVien.Enabled = tt;
            cboGioiTinh.Enabled = tt;
            dtNgaySinh.Enabled = tt;
            txtDienThoai.Enabled = tt;
            txtDiaCHi.Enabled = tt;
            cboCongViec.Enabled = tt;
            btnChinhSua.Enabled = !tt;
            btnXoa.Enabled = !tt;
            btnXacNhan.Enabled=tt;
            btnHuy.Enabled=tt;
            btnXacNhan.Visible=tt;
            btnHuy.Visible=tt;
        }
        

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void frm_ChiTietNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Xem(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDataF();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon xoa ?", "co hay k", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sqlDelete = "delete from NhanVien where MaNV='" + txtMaNhanVien.Text + "'";
                    data.ChangeData(sqlDelete);
                    MessageBox.Show("Xoa Thanh Cong");
                    
                    ///LoadDataF();
                    NhanVienMoi.LoadData();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Khong the xoa do co hoa don");
                }

            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thực sự muốn cập nhật thông tin khách hàng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string[] date = dtNgaySinh.Value.ToShortDateString().ToString().Split('/');
                    string ngay = "" + date[1] + "/" + date[0] + "/" + date[2];
                    //MessageBox.Show(ngay);
                    //dtNgaySinh.Value = Convert.ToDateTime(ngay);
                    string update = "UPDATE NhanVien SET TenNV = N'" + txtTenNhanVien.Text + "', DienThoai = '" + txtDienThoai.Text + "', DiaChi = N'" + txtDiaCHi.Text + "', MaCV = '" + cboCongViec.SelectedValue.ToString() + "', GioiTinh = N'"+cboGioiTinh.Text+"', NgaySinh ='"+ngay+"' WHERE MaNV ='" + txtMaNhanVien.Text + "'";
                    data.ChangeData(update);

                    NhanVienMoi.LoadData();
                    MessageBox.Show("Cập Nhật Thành Công!");
                    LoadDataF();
                    Xem(false);

                }

                catch
                {
                    MessageBox.Show("Cập Nhật Thất Bại");
                }

            }
            else
            {
                LoadDataF();
                Xem(false );
            }


            Xem(false);
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
