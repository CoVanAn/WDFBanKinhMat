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
    public partial class frm_ThemNhanVien : Form
    {

        DataConnect data = new DataConnect();
        CBBox cbBox;
        frm_NhanVienMoi frm_NhanVien;

        public frm_ThemNhanVien(frm_NhanVienMoi NV)
        {
            InitializeComponent();
            frm_NhanVien = NV;
            cbBox = new CBBox();
            DataTable dtCL = new DataTable();
            dtCL = data.ReadData("Select * from CongViec");
            //dgvTest.DataSource = dtCL;
            cbBox.FillComboBox(cboCongViecThem, dtCL, "TenCV", "MaCV");
            
            rdoNu.Checked = false;
            rdoNam.Checked = false;
            cboCongViecThem.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Text = SinhMa().ToString();
        }

        int SinhMa()
        {

            string Ma = "Select MaNV from NhanVien";
            DataTable dt = data.ReadData(Ma);
            int MaSinh = 1;
            int i = 0;
            //MessageBox.Show(dt.Rows[1]["MaKH"].ToString());
            try
            {
                while (MaSinh == int.Parse(dt.Rows[i]["MaNV"].ToString()))
                {
                    //if (MaSinh != int.Parse(dt.Rows[i]["MaKH"].ToString()))
                    //{

                    MaSinh++;
                    i++;
                    //MessageBox.Show(MaSinh.ToString());
                    //}
                    //else { }
                }
            }
            catch (Exception ex)
            {

            }
            return MaSinh;
        }

        public string GetGioiTinh()
        {
            if(rdoNam.Checked == true)
            {
                return "Nam";
            }
            else { return "Nữ"; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ThemNhanVien_Load(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Ma Nhan Vien chua dc nhap");
                txtMaNhanVien.Focus();
            }
            else
            {
                if(txtTenNhanVien.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập tên nhân viên");
                    txtTenNhanVien.Focus();
                }
                else
                { 
                    if(rdoNam.Checked == false && rdoNu.Checked == false)
                    {
                        MessageBox.Show("Chưa chọn giới tính");
                        grbGioiTinh.Focus();
                    }
                    else
                    {
                        if (cboCongViecThem.Text.Trim() == "")
                        {
                            MessageBox.Show("Công việc chưa được chọn");
                            grbGioiTinh.Focus();
                        }
                        else
                        {
                            DataTable dtCheck = data.ReadData("select * from NhanVien where MaNV = '" + txtMaNhanVien.Text + "'");
                            if (dtCheck.Rows.Count > 0)
                            {
                                //MessageBox.Show("Ma nhan vien da ton tai, vui longf nhap ma khac");
                                //txtMaNhanVien.Focus();
                                return;
                            }
                            else
                            {
                                //MessageBox.Show(cboCongViecThem.SelectedValue.ToString());
                                //string sqlInsert = "insert into NhanVien values ('"+txtMaNhânVien.Text+"','"+txtTenNhanVien.Text+"',1,'"+DateTime.Parse(dtNgaySinh.Value.ToString())+"',N'"+txtDiaChi.Text+"',N'"+txtDienThoai.Text+"','"+cbxCongViec.SelectedValue+"')";
                                string sqlInsert = "INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [MaCV]) VALUES (" + txtMaNhanVien.Text + ", N'" + txtTenNhanVien.Text + "', N'" + GetGioiTinh().ToString() + "', N'" + dtNgaySinhThem.Value.Day.ToString() + "/" + dtNgaySinhThem.Value.Month.ToString() + "/" + dtNgaySinhThem.Value.Year.ToString() + "', N'" + txtDiaChi.Text + "', N'" + txtSDT.Text + "', " + cboCongViecThem.SelectedValue + ")";
                                data.ChangeData(sqlInsert);

                                MessageBox.Show("Đã thêm Nhân vien mới!");
                                frm_NhanVien.LoadData();
                                this.Close();
                            }
                        }   
                    }
                }
            }
        }

        private void cboCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnBo_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtNgaySinhThem_ValueChanged(object sender, EventArgs e)
        {

        }


        void NhapLai()
        {
            //txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            cboCongViecThem.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtNgaySinhThem.Value = DateTime.Now;
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
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
