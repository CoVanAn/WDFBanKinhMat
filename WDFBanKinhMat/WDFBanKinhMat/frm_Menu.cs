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
    public partial class Fomr : Form
    {
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHienThi.Controls.Add(childForm);
            panelHienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void DisableMenuBar()     ///Bấm vào trong phần giao diện thì thanh Menu tạm thời k bấm đc
        {
            btnHangHoa.Enabled = false;
            btnHoaDonBan.Enabled = false;
            btnHoaDonNhap.Enabled = false;
            btnKhachHang.Enabled = false;
            btnNhanVien.Enabled = false;
            ///btnBaoCao.Enabled = false;
        }

        public void EnableMenuBar()     ///Bấm 
        {
            btnHangHoa.Enabled = true;
            btnHoaDonBan.Enabled = true;
            btnHoaDonNhap.Enabled = true;
            btnKhachHang.Enabled = true;
            btnNhanVien.Enabled = true;
            ///btnBaoCao.Enabled = true;
        }

        public Fomr()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHangHoa_MouseEnter(object sender, EventArgs e)
        {
            btnHangHoa.BackColor = SystemColors.Highlight;
            btnHangHoa.ForeColor = Color.White;
        }

        private void btnHangHoa_MouseLeave(object sender, EventArgs e)
        {
            btnHangHoa.BackColor = SystemColors.Window;
            btnHangHoa.ForeColor = Color.Black;
        }

        private void btnHoaDonNhap_MouseEnter(object sender, EventArgs e)
        {
            btnHoaDonNhap.BackColor = SystemColors.Highlight;
            btnHoaDonNhap.ForeColor = Color.White;
        }

        private void btnHoaDonNhap_MouseLeave(object sender, EventArgs e)
        {
            btnHoaDonNhap.BackColor = SystemColors.Window;
            btnHoaDonNhap.ForeColor = Color.Black;
        }

        private void btnHoaDonBan_MouseEnter(object sender, EventArgs e)
        {
            btnHoaDonBan.BackColor = SystemColors.Highlight;
            btnHoaDonBan.ForeColor = Color.White;
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = SystemColors.Highlight;
            btnNhanVien.ForeColor = Color.White;
        }

        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            btnKhachHang.BackColor = SystemColors.Highlight;
            btnKhachHang.ForeColor = Color.White;
        }

        private void btnHoaDonBan_MouseLeave(object sender, EventArgs e)
        {
            btnHoaDonBan.BackColor = SystemColors.Window;
            btnHoaDonBan.ForeColor = Color.Black;
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = SystemColors.Window;
            btnNhanVien.ForeColor = Color.Black;
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            btnKhachHang.BackColor = SystemColors.Window;
            btnKhachHang.ForeColor = Color.Black;
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_HangHoa());
        }

        private void panelHienThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_NhanVienMoi());
            
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_KhachHangMoi());
        }

        /// <summary>
        /// GỌI ĐẾN FORM LÀ NHƯ NÀY
        /// </summary>
        /// 



        
    }
}
