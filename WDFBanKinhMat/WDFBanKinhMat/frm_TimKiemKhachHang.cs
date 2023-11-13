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
using WDFBanKinhMat.Classes;
using WDFBanKinhMat.Classes.CBBox;

namespace WDFBanKinhMat
{
    public partial class frm_TimKiemKhachHang : Form
    {
        DataConnect data = new DataConnect();
        CBBox cbBox;
        frm_KhachHang frm_KhachHang;

        public frm_TimKiemKhachHang(frm_KhachHang Khach)
        {
            InitializeComponent();
            cbBox = new CBBox();
            DataTable dt = data.ReadData("select MaKH from KhachHang");
            cbBox.FillComboBox(cbxMaTim, dt, "MaKH", "MaKH");
            //rdoYes.Checked = true; rdoNo.Checked = false;
            frm_KhachHang = Khach;
        }

        void reNew()
        {
            cbxMaTim.Text = "";
            txtTenTim.Text = "";
            txtSDTTim.Text = "";
            cbxMaTim.SelectedValue = 1;
        }

        private void cbxMaTim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            string Find = "select * from KhachHang where MaKH is not null ";
            /*
            if (cbxMaTim.SelectedValue.Equals(0))
            {

            }
            else
            {
                if (cbxMaTim.SelectedValue.ToString() != "")
                {
                    MessageBox.Show(cbxMaTim.SelectedValue.ToString());
                    Find += "and MaKH ='" + cbxMaTim.SelectedValue.ToString() + "'";
                }
            }
            */
            if (txtTenTim.Text.ToString() != "")
            {
                Find += "and TenKH like N'%"+ txtTenTim.Text.ToString() +"%'";
            }
            if(txtSDTTim.Text != "")
            {
                Find += "and DienThoai ='" + txtSDTTim.Text + "'";
            }
            if (chkNgay.Checked)
            {
                Find += "";
            }
            MessageBox.Show(Find);
            DataTable tim = data.ReadData(Find);
            frm_KhachHang.LoadTim(Find);
        }

        private void grpCheck_Enter(object sender, EventArgs e)
        {

        }

        private void chkNgay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_TimKiemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            reNew();
        }
    }
}
