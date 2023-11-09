using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDFBanKinhMat
{
    public partial class frm_SanPham : Form
    {
        Classes.CBBox.CBBox function = new Classes.CBBox.CBBox();
        Classes.DataConnect data = new Classes.DataConnect();
        Decimal GiaBanTu = 0, GiaBanDen = 10000000;
        int MaLoai = 0, MaMau = 0, MaCL = 0, MaDangMat = 0;
        frm_Menu Menu;

        public static int MaSP;
        string find;
        string StrSql, TenAnh;

        //
        // TRUYỀN DỮ LIỆU VÀO CÁC COMBOBOX
        //

        public frm_SanPham()
        {
            InitializeComponent();

            DataTable dtLoaiSP = data.ReadData("select * from LoaiSP");
            function.FillListBox(lstLoaiSP, dtLoaiSP, "TenLoai", "MaLoai");

            DataTable dtChatLieu = data.ReadData("select * from ChatLieu");
            function.FillListBox(lstChatLieu, dtChatLieu, "TenCL", "MaCL");

            DataTable dtMauSac = data.ReadData("select * from Mau");
            function.FillListBox(lstMau, dtMauSac, "TenMau", "MaMau");

            DataTable dtDangMat = data.ReadData("select * from HinhDangMat");
            function.FillListBox(lstDangMat, dtDangMat, "TenDangmat", "MaDangMat");

            string query = "select top 1 MaSP from SanPham order by MaSP desc";
            DataTable dtSP = data.ReadData(query);
            MaSP = int.Parse(dtSP.Rows[0][0].ToString()) + 1;
            Console.WriteLine(MaSP);
        }

        //
        // TRUYỀN DỮ LIỆU CÁC SẢN PHẨM VÀO LISTVIEW    
        //

        private void lvSanPham_Click(object sender, EventArgs e)
        {
            ListViewItem itemselect = lvSanPham.SelectedItems[0];
            int MaSP = int.Parse(itemselect.Name);
            DataTable dt = data.ReadData("Select * from SanPham where MaSP = " + MaSP);
            lblMaSP.Text = dt.Rows[0]["MaSP"].ToString();
            lblTenSP.Text = dt.Rows[0]["TenSP"].ToString();
            lblLoaiSP.Text = dt.Rows[0]["MaLoai"].ToString();
            lblChatLieu.Text = dt.Rows[0]["MaCL"].ToString();
            lblMau.Text = dt.Rows[0]["MaMau"].ToString();
            lblSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
            lblDangMat.Text = dt.Rows[0]["MaDangMat"].ToString();
            lblGiaBan.Text = dt.Rows[0]["DonGiaBan"].ToString();
            lblGiaNhap.Text = dt.Rows[0]["DonGiaNhap"].ToString();
        }

        //
        // HÀM TÌM THEO DANH SÁCH CHỌN
        //

        private void TimKiemSanPham(Decimal GiaTu, Decimal GiaDen, int MaLoai, int MaMau, int MaCL, int DangMat)
        {
            find = "where DonGiaBan > " + GiaTu.ToString() + " and DonGiaBan < " + GiaDen.ToString();
            if (MaLoai != 0)
            {
                find = find + " and MaLoai = " + MaLoai;
            }
            if (MaCL != 0)
            {
                find = find + " and MaCL = " + MaCL;
            }
            if (MaMau != 0)
            {
                find = find + " and MaMau = " + MaMau;
            }
            if (DangMat != 0)
            {
                find = find + " and MaDangMat = " + DangMat;

            }
            DocDuLieu(find);
        }

        //
        // ĐỌC DỮ LIỆU SAU KHI ĐC TRUYỀN LỆNH FIND
        //

        public void DocDuLieu(string find)
        {
            lvSanPham.Items.Clear();
            imageList.Images.Clear();
            DataTable dt = data.ReadData("Select * from SanPham " + find);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                imageList.ImageSize = new Size(180, 180);
                imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/../../Anh/" + dt.Rows[i]["Anh"].ToString()));
                ListViewItem item = new ListViewItem();
                item.Name = dt.Rows[i]["MaSP"].ToString();
                item.Text = dt.Rows[i]["TenSP"].ToString();
                //+"\n" + dt.Rows[i]["SoLuong"].ToString() + "\n" + dt.Rows[i]["DonGiaBan"].ToString()
                item.ImageIndex = i;
                lvSanPham.Items.Add(item);
                Image.FromFile(Environment.CurrentDirectory + "/../../Anh/" + dt.Rows[i]["Anh"].ToString()).Dispose();
            }
        }

        //
        // LỌC DỮ LIỆU
        //

        private void LocLaiDuLieu()
        {
            lblChatLieu.Text = lblDangMat.Text = lblGiaBan.Text = lblGiaNhap.Text
                = lblLoaiSP.Text = lblMaSP.Text = lblMau.Text = lblSoLuong.Text = lblTenSP.Text = "...";
            lstChatLieu.SelectedIndex = -1;
            lstMau.SelectedIndex = -1;
            lstLoaiSP.SelectedIndex = -1;
            lstDangMat.SelectedIndex = -1;
            MaCL = MaLoai = MaMau = 0;
            GiaBanTu = 0;
            GiaBanDen = 10000000;
            rdo100300.Checked = false;
            rdo300500.Checked = false;
            rdo5001000.Checked = false;
            DocDuLieu("");
        }
        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            LocLaiDuLieu();
        }

        //
        // CÁC BỘ LỌC
        //

        private void rdo100300_Click(object sender, EventArgs e)
        {
            GiaBanTu = 100000;
            GiaBanDen = 300001;
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void rdo300500_Click(object sender, EventArgs e)
        {
            GiaBanTu = 300000;
            GiaBanDen = 500001;
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void rdo5001000_Click(object sender, EventArgs e)
        {
            GiaBanTu = 500000;
            GiaBanDen = 1000001;
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }

        private void lstLoaiSP_Click(object sender, EventArgs e)
        {
            MaLoai = int.Parse(lstLoaiSP.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }

        private void lstChatLieu_Click(object sender, EventArgs e)
        {
            MaCL = int.Parse(lstChatLieu.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void lstMau_Click(object sender, EventArgs e)
        {
            MaMau = int.Parse(lstMau.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }
        private void lstDangMat_Click(object sender, EventArgs e)
        {
            MaDangMat = int.Parse(lstDangMat.SelectedValue.ToString());
            TimKiemSanPham(GiaBanTu, GiaBanDen, MaLoai, MaMau, MaCL, MaDangMat);
        }

        private void btnLocLai_Click(object sender, EventArgs e)
        {
            LocLaiDuLieu();
        }

        //
        // THÊM SỬA XÓA
        //

        private void menuItemThemSP_Click(object sender, EventArgs e)
        {
            frm_ThemSanPham frmThem = new frm_ThemSanPham();
            frmThem.ShowDialog();
            if (frm_ThemSanPham.flag == 1)
            {
                DocDuLieu("");
            }
        }

        private void menuItemSuaSP_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MaSP = int.Parse(lblMaSP.Text.Trim());
                frm_SuaSanPham frmSua = new frm_SuaSanPham();
                frmSua.ShowDialog();
                if (frm_SuaSanPham.flag == 1)
                {
                    DocDuLieu("");
                }
            }
        }

        private void menuItemXoaSP_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm bạn muốn xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm " + lblTenSP.Text + " không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataTable dt = data.ReadData("Select * from SanPham where MaSP = " + lblMaSP.Text);
                        StrSql = "Delete From SanPham Where MaSP = N'" + lblMaSP.Text + "'";
                        TenAnh = dt.Rows[0]["Anh"].ToString();
                        imageList.Images.RemoveByKey(TenAnh);
                        //File.Delete(Environment.CurrentDirectory + "/../../Anh/" + TenAnh);
                        data.ChangeData(StrSql);
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LocLaiDuLieu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
