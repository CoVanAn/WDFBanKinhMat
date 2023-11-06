using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDFBanKinhMat.BLL;

namespace WDFBanKinhMat
{
    public partial class frm_HangHoa : Form
    {
        Classes.CBBox.CBBox function = new Classes.CBBox.CBBox();
        Classes.DataConnect data = new Classes.DataConnect();
        Decimal GiaBanTu = 0, GiaBanDen = 0;
        int i = 0, j =0, MaTL = 0, MaMau = 0, MaCL = 0;
        public frm_HangHoa()
        {
            InitializeComponent();
            DataTable dtLoaiSP = data.ReadData("select * from LoaiSP");
            function.FillListBox(lstLoaiSP, dtLoaiSP, "TenLoai", "MaLoai");

            DataTable dtChatLieu = data.ReadData("select * from ChatLieu");
            function.FillListBox(lstChatLieu, dtChatLieu, "TenCL", "MaCL");

            DataTable dtMauSac = data.ReadData("select * from Mau");
            function.FillListBox(lstMau, dtMauSac, "TenMau", "MaMau");

        }
        private void DisplayData(List<SanPham> lstSanPham)
        {
            lvSanPham.Items.Clear();
            foreach (SanPham SP in lstSanPham)
            {
                imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/../../Photos/" + SP.Anh));
                ListViewItem item = new ListViewItem();
                item.Name = SP.MaSP.ToString();
                item.Text = SP.TenSP;
                item.ImageIndex = i;
                lvSanPham.Items.Add(item);
                i++;
            }
        }
        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            DataTable dt = data.ReadData("Select * from SanPham");
            imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/../../Anh/1.jpg"));
            Console.WriteLine(dt.Rows[1].ToString());
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                j = i+1;
                imageList.ImageSize = new Size(110, 110);
                imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "/../../Anh/"+j+".jpg"));
                ListViewItem item = new ListViewItem();
                item.Name = dt.Rows[i]["MaSP"].ToString();
                item.Text = dt.Rows[i]["TenSP"].ToString();
                item.ImageIndex = i;
                lvSanPham.Items.Add(item);
            }    
            lvSanPham = new ListView();            
        }
        private void rdo100_Click(object sender, EventArgs e)
        {
            GiaBanTu = 0;
            GiaBanDen = 100000;
            //DisplayData(SanPhamBLL.TinKiemSanPham(GiaBanTu, GiaBanDen, MaTL, MaMau, MaCL));
        }

        private void rdo100300_Click(object sender, EventArgs e)
        {
            GiaBanTu = 100000;
            GiaBanDen = 300000;
            //DisplayData(SanPhamBLL.TinKiemSanPham(GiaBanTu, GiaBanDen, MaTL, MaMau, MaCL));
        }

        private void rdo300500_Click(object sender, EventArgs e)
        {
            GiaBanTu = 300000;
            GiaBanDen = 500000;
            //DisplayData(SanPhamBLL.TinKiemSanPham(GiaBanTu, GiaBanDen, MaTL, MaMau, MaCL));
        }

        private void btnLocLai_Click(object sender, EventArgs e)
        {
            lstChatLieu.SelectedIndex = -1;
            lstMau.SelectedIndex = -1;
            lstLoaiSP.SelectedIndex = -1;

        }
    }
}
