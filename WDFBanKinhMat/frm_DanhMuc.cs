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
    public partial class frm_DanhMuc : Form
    {
        Classes.DataConnect data = new Classes.DataConnect();
        string DanhMuc = "danh mục", Bang, Ten, Ma, ChonMa;
       
        public frm_DanhMuc()
        {
            InitializeComponent();
        }

        //
        //  KIỂM TRA XEM MÃ VÀ TÊN CÓ TRÙNG VỚI DANH MỤC ĐÃ CÓ KHÔNG
        //
        private void KiemTraMa(string Ma, string Ten, string Bang)
        {
            DataTable dt = data.ReadData("Select * from "  + Bang );
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(txtMaDanhMuc.Text == dt.Rows[i][Ma].ToString())
                {
                    MessageBox.Show("Mã " + DanhMuc + " đã tồn tại. Hãy chọn mã khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDanhMuc.Focus();
                    break;
                }
                if (txtTenDanhMuc.Text == dt.Rows[i][Ten].ToString())
                {
                    MessageBox.Show("Mã " + DanhMuc + " đã tồn tại. Hãy chọn mã khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenDanhMuc.Focus();
                    break;
                }
            }
        }

        //
        //  LỌC LẠI DỮ LIỆU THEO BẢNG ĐANG ĐƯỢC YÊU CẦU SỬ DỤNG
        //

        private void LocDuLieu(string Bang, string Ma, string Ten)
        {
            lblTieuDe.Text = DanhMuc.ToUpper();
            txtMaDanhMuc.Text = txtTenDanhMuc.Text = null;
            dgvDanhMuc.Rows.Clear();
            DataTable dt = data.ReadData("Select * from " + Bang);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Name = dt.Rows[i][Ma].ToString();
                string Text = dt.Rows[i][Ten].ToString();
                String[] rows =
                {
                   Name, Text
                };
                dgvDanhMuc.Rows.Add(rows);
            }

            string query = "select top 1 " + Ma + " from " + Bang + " order by " + Ma + " desc";
            DataTable dtSP = data.ReadData(query);
        }
        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            DanhMuc = "loại sản phẩm";
            Bang = "LoaiSP";
            Ma = "MaLoai";
            Ten = "TenLoai";
            LocDuLieu(Bang, Ma, Ten);
        }

        private void btnChatLieu_Click(object sender, EventArgs e)
        {
            DanhMuc = "chất liệu";
            Bang = "ChatLieu";
            Ma = "MaCL";
            Ten = "TenCL";
            LocDuLieu(Bang, Ma, Ten);
        }

        private void btnDangMat_Click(object sender, EventArgs e)
        {
            DanhMuc = "hình dạng mắt";
            Bang = "HinhDangMat";
            Ma = "MaDangMat";
            Ten = "TenDangMat";
            LocDuLieu(Bang, Ma, Ten);
        }
        private void btnMauSac_Click(object sender, EventArgs e)
        {
            DanhMuc = "màu sắc";
            Bang = "Mau";
            Ma = "MaMau";
            Ten = "TenMau";
            LocDuLieu(Bang, Ma, Ten);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string strSql = "";

            if (txtMaDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã " + DanhMuc  +"!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDanhMuc.Focus();
                return;
            }
            if (txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên " + DanhMuc + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDanhMuc.Focus();
                return;
            }
            KiemTraMa(Ma, Ten, Bang);
            try
            {
                strSql = "INSERT INTO "+ Bang + "( " +Ma + ", " + Ten + " ) VALUES(";
                strSql += "N'" + txtMaDanhMuc.Text + "',N'" + txtTenDanhMuc.Text +"')";
                data.ChangeData(strSql);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LocDuLieu(Bang, Ma, Ten);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void dgvDanhMuc_Click(object sender, EventArgs e)
        {
            ChonMa = dgvDanhMuc.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn " + DanhMuc + " bạn muốn xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá mã " + ChonMa + " không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string strSql = "Delete From " + Bang + " Where " + Ma + "  = N'" + ChonMa + "'";
                        data.ChangeData(strSql);
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LocDuLieu(Bang, Ma, Ten);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btmTaiLai_Click(object sender, EventArgs e)
        {
            LocDuLieu(Bang, Ma, Ten);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
