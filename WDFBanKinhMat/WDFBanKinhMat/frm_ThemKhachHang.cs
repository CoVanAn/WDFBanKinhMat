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
    public partial class frm_ThemKhachHang : Form
    {
        DataConnect data = new DataConnect();
        frm_KhachHangMoi frm_Khach;

        public frm_ThemKhachHang(frm_KhachHangMoi khachHang)
        {
            InitializeComponent();
            frm_Khach = khachHang;
            txtMaKhachThem.Text = SinhMa().ToString();
            txtMaKhachThem.Enabled = false;
        }

        int SinhMa()
        {
            
            string Ma = "Select MaKH from KhachHang";
            DataTable dt = data.ReadData(Ma);
            int MaSinh = 10000;
            int i = 0;
            //MessageBox.Show(dt.Rows[1]["MaKH"].ToString());
            
            while(MaSinh == int.Parse(dt.Rows[i]["MaKH"].ToString()))
            {
                //if (MaSinh != int.Parse(dt.Rows[i]["MaKH"].ToString()))
                //{
                    
                    MaSinh++;
                    i++;
                    //MessageBox.Show(MaSinh.ToString());
                //}
                //else { }
            }
            return MaSinh;
        }

        void Moi()
        {
            //txtMaKhachThem.Text = "";
            txtTenKhachThem.Text = "";
            txtDiaChiKhachThem.Text = "";
            txtSDTKahchThem.Text = "";
            txtEmailKhachThem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhachThem.Text.Trim() == "")
            {
               // MessageBox.Show("Ma Nhan Vien chua dc nhap");
                //txtMaKhachThem.Focus();
            }
            else
            {
                if (txtTenKhachThem.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Khách Hàng chưa được nhập");
                    txtTenKhachThem.Focus();
                }
                else
                {
                    if (txtSDTKahchThem.Text.Trim() == "")
                    {
                        MessageBox.Show("Chưa nhập số điện thoại");
                        txtSDTKahchThem.Focus();
                    }
                    else
                    {
                        DataTable dtCheck = data.ReadData("select * from KhachHang where MaKH = '" + txtMaKhachThem.Text + "'");
                        if (dtCheck.Rows.Count > 0)
                        {
                            //MessageBox.Show("Ma nhan vien da ton tai, vui longf nhap ma khac");
                            //txtMaKhachThem.Focus();
                            return;
                        }
                        else
                        {
                            //MessageBox.Show(cboCongViecThem.SelectedValue.ToString());
                            //string sqlInsert = "insert into NhanVien values ('"+txtMaNhânVien.Text+"','"+txtTenNhanVien.Text+"',1,'"+DateTime.Parse(dtNgaySinh.Value.ToString())+"',N'"+txtDiaChi.Text+"',N'"+txtDienThoai.Text+"','"+cbxCongViec.SelectedValue+"')";
                            string sqlInsert = "INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email]) VALUES ("+txtMaKhachThem.Text+", N'"+txtTenKhachThem.Text+"', N'"+txtDiaChiKhachThem.Text+"', N'"+txtSDTKahchThem.Text+"', N'"+txtEmailKhachThem.Text+"')";
                            data.ChangeData(sqlInsert);

                            MessageBox.Show("Thêm mới thành công");
                            frm_Khach.LoadData();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void frm_ThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void txtSDTKahchThem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDTKahchThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaKhachThem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Moi();
        }
    }
}
