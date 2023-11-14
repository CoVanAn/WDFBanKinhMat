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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace WDFBanKinhMat
{
    public partial class frm_BaoCaoDoanhSo : Form
    {
        string Desc = "SoLuong";
        DataConnect db = new DataConnect();
        public frm_BaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            String queryKH = "select KhachHang.MaKH,KhachHang.TenKH,Sum(TongTien) as DoanhThu " +
                "from KhachHang inner join HoaDonBan on KhachHang.MaKH=HoaDonBan.MaKH where NgayBan>='" + dtpTu.Value + "'and NgayBan<='" + dtpDen.Value +
                "' group by KhachHang.MaKH,KhachHang.TenKH " +
                "order by DoanhThu Desc";
            DataTable tbl = db.ReadData(queryKH);
            Decimal TongKH = 0;
            dgvKhachHang.Rows.Clear();
            foreach (DataRow row in tbl.Rows)
            {
                String[] rowss =
                {
                    row["MaKH"].ToString(),
                    row["TenKH"].ToString(),
                    Decimal.Parse(row["DoanhThu"].ToString()).ToString("#,###0")
                };
                TongKH += Decimal.Parse(row["DoanhThu"].ToString());
                dgvKhachHang.Rows.Add(rowss);
            }
            txtTongKH.Text = TongKH.ToString("#,###0");
        }
       
        private void HienThi()
        {
            Decimal TongDTSP = 0;
            int TongSL = 0;
            dgvSanPham.Rows.Clear();
            String quemua = "select MaSP, SUM(SoLuong) from ChiTietHDB GROUP BY MaSP ";
            String query = "select SanPham.MaSP,SanPham.TenSP,SanPham.MaLoai,Sum(ChiTietHDB.SoLuong) as SoLuong," +
                "Sum(ChiTietHDB.SoLuong*ChiTietHDB.DonGia-(ChiTietHDB.SoLuong*ChiTietHDB.DonGia*ChiTietHDB.GiamGia)/100) as ThanhTien " +
                "from SanPham inner join ChiTietHDB on SanPham.MaSP=ChiTietHDB.MaSP inner join HoaDonBan on ChiTietHDB.SoHDB =HoaDonBan.SoHDB " +
                "where NgayBan>='" + dtpTuSP.Value + "' and NgayBan<='" + dtpDenSP.Value + "' group by SanPham.MaSP,SanPham.TenSP,SanPham.MaLoai " +
                "order by " + Desc + " Desc";
            DataTable tbl = db.ReadData(query);

            for (int i = 0; i < tbl.Rows.Count; i++)
            {

            }
            foreach (DataRow row in tbl.Rows)
            {
                String[] rows =
                {
                    row["MaSP"].ToString(),
                    row["TenSP"].ToString(),
                    row["MaLoai"].ToString(),
                    row["SoLuong"].ToString(),
                    Decimal.Parse(row["ThanhTien"].ToString()).ToString("#,###0")
                };
                TongDTSP += Decimal.Parse(row["ThanhTien"].ToString());
                TongSL += int.Parse(row["SoLuong"].ToString());
                dgvSanPham.Rows.Add(rows);
            }
            txtTongTienSP.Text = TongDTSP.ToString("#,###0");
            txtTongSoLuong.Text = TongSL.ToString();
        }
        private void frm_BaoCaoDoanhSo_Load(object sender, EventArgs e)
        {

        }

        private void btnXemSP_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int i = 0;
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Cambria";
            exRange.Range["A1:C3"].Font.Size = 15;
            exRange.Range["A1:C3"].Font.Bold = true;
            exRange.Range["A1:C3"].Font.Color = Color.Aqua; //Màu xanh da trời
            exRange.Range["A1:C1"].MergeCells = true;

            exRange.Range["A1:B1"].Value = "Hệ Thống Thời Trang TOP";
            exRange.Range["C4:F4"].MergeCells = true;
            exRange.Range["C4:F4"].Font.Size = 20;
            exRange.Range["C4:F4"].Font.Name = "Cambria";
            exRange.Range["C4:F4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C4:F4"].Value = "BÁO CÁO BÁN HÀNG THEO KHÁCH HÀNG";
            exRange.Range["C5:F5"].MergeCells = true;
            exRange.Range["C5:F5"].Font.Size = 13;
            exRange.Range["C5:E5"].Font.Italic = true;
            exRange.Range["C5:E5"].MergeCells = true;
            exRange.Range["C5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:E5"].Value = "Từ ngày " + dtpTu.Value.ToString("dd-MM-yyyy") + " đến " + dtpDen.Value.ToString("dd-MM-yyyy");
            exRange.Range["A7:G7"].Font.Bold = true;
            exRange.Range["A7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["A8:F8"].Font.Bold = true;
            exRange.Range["B8:B8"].Value = "STT";
            exRange.Range["C8:C8"].Value = "Mã khách hàng";
            exRange.Range["C8:C8"].ColumnWidth = 20;
            exRange.Range["D8:D8"].Value = "Tên khách hàng";
            exRange.Range["D8:D8"].ColumnWidth = 30;
            exRange.Range["E8:E8"].ColumnWidth = 30;
            exRange.Range["E8:E8"].Value = "Doanh thu";
            for (i = 0; i < dgvKhachHang.Rows.Count; i++)
            {
                exSheet.Range["A" + (i + 9).ToString() + ":F" + (i + 9).ToString()].Font.Bold = false;
                exSheet.Range["A" + (i + 9).ToString() + ":F" + (i + 9).ToString()].Font.Size = 13;
                exSheet.Range["B" + (i + 9).ToString()].Value = (i + 1).ToString();
                exSheet.Range["C" + (i + 9).ToString()].Value = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["D" + (i + 9).ToString()].Value = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["E" + (i + 9).ToString()].Value = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            }
            exRange.Range["E" + (i + 9).ToString()].Font.Size = 13;
            exRange.Range["E" + (i + 9).ToString()].Value = "Tổng doanh thu:  " + txtTongKH.Text + " VNĐ";
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].Font.Size = 13;
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].MergeCells = true;
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].Value = "Người lập báo cáo";
            exSheet.Range["D" + (i + 12).ToString() + ":E" + (i + 12)].MergeCells = true;
            exSheet.Range["D" + (i + 12).ToString() + ":E" + (i + 12).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D" + (i + 12).ToString() + ":E" + (i + 12).ToString()].Value = "(Ký,họ tên)";
            exSheet.Name = "BC-DTKH";
            exApp.Visible = true;
        }

        private void btnXuatSP_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exbook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exbook.Worksheets[1];

            COMExcel.Range tenCuaHang = (COMExcel.Range)exSheet.Cells[1, 1];
            tenCuaHang.Font.Size = 13;
            tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Color = Color.Blue;
            tenCuaHang.Font.Name = "Cambria";
            tenCuaHang.Value = "HỆ THỐNG THỜI TRANG TOP";

            COMExcel.Range header = (COMExcel.Range)exSheet.Cells[5, 3];
            exSheet.get_Range("C5:F5").Merge(true);
            header.Font.Size = 20;
            header.Font.Name = "Cambria";
            header.Font.Bold = true;
            header.Font.Color = Color.Green;
            header.Value = "BÁO CÁO DOANH THU THEO SẢN PHẨM";

            exSheet.Range["A7:F7"].Font.Name = "Cambria";
            exSheet.Range["A7:F7"].Font.Bold = true;
            exSheet.Range["A7:F7"].Font.Size = 13;
            exSheet.Range["A7:H7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D7:H7"].ColumnWidth = 15;
            exSheet.Range["A7:A7"].Value = "STT";
            exSheet.Range["B7:B7"].ColumnWidth = 15;
            exSheet.Range["B7:B7"].Value = "Mã sản phẩm";
            exSheet.Range["C7:C7"].Value = "Tên sản phẩm";
            exSheet.Range["C7:C7"].ColumnWidth = 60;
            exSheet.Range["D7:D7"].ColumnWidth = 30;
            exSheet.Range["D7:D7"].Value = "Nhóm sản phẩm";
            exSheet.Range["E7:E7"].ColumnWidth = 30;
            exSheet.Range["E7:E7"].Value = "Số lượng bán";
            exSheet.Range["F7:F7"].ColumnWidth = 30;
            exSheet.Range["F7:F7"].Value = "Doanh thu";
            exSheet.Name = "BC-DTSP";
            int i = 0;
            for (i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                exSheet.get_Range("A" + (i + 8).ToString() + ":F" + (i + 8).ToString()).Font.Bold = false;
                exSheet.get_Range("A" + (i + 8).ToString() + ":F" + (i + 8).ToString()).Font.Name = "Cambria";
                exSheet.get_Range("A" + (i + 8).ToString() + ":F" + (i + 8).ToString()).Font.Size = 13;
                exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                exSheet.get_Range("B" + (i + 8).ToString()).Value = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                exSheet.get_Range("C" + (i + 8).ToString()).Value = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                exSheet.get_Range("D" + (i + 8).ToString()).Value = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                exSheet.get_Range("E" + (i + 8).ToString()).Value = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                exSheet.get_Range("F" + (i + 8).ToString()).Value = dgvSanPham.Rows[i].Cells[4].Value.ToString();
            }
            exSheet.Range["E" + (i + 8).ToString()].Font.Size = 13;
            exSheet.Range["E" + (i + 8).ToString()].Font.Name = "Cambria";
            exSheet.Range["E" + (i + 8).ToString()].Value = txtTongSoLuong.Text;
            exSheet.Range["F" + (i + 8).ToString()].Font.Size = 13;
            exSheet.Range["F" + (i + 8).ToString()].Font.Name = "Cambria";
            exSheet.Range["F" + (i + 8).ToString()].Value = txtTongTienSP.Text;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].Font.Name = "Cambria";
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].Font.Size = 13;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].MergeCells = true;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].Value = "Hà Nội, Ngày.......,tháng......, năm.......";
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].Font.Name = "Cambria";
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].Font.Size = 13;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].MergeCells = true;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["E" + (i + 10).ToString() + ":F" + (i + 10).ToString()].Value = "Hà Nội, Ngày.......,tháng......, năm.......";
            exSheet.Range["E" + (i + 11).ToString() + ":F" + (i + 11).ToString()].Font.Name = "Cambria";
            exSheet.Range["E" + (i + 11).ToString() + ":F" + (i + 11).ToString()].Font.Size = 13;
            exSheet.Range["E" + (i + 11).ToString() + ":F" + (i + 11).ToString()].MergeCells = true;
            exSheet.Range["E" + (i + 11).ToString() + ":F" + (i + 11).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["E" + (i + 11).ToString() + ":F" + (i + 11).ToString()].Value = "Người lập phiếu";
            exSheet.Range["E" + (i + 12).ToString() + ":F" + (i + 12).ToString()].Font.Name = "Cambria";
            exSheet.Range["E" + (i + 12).ToString() + ":F" + (i + 12).ToString()].Font.Size = 13;
            exSheet.Range["E" + (i + 12).ToString() + ":F" + (i + 12).ToString()].MergeCells = true;
            exSheet.Range["E" + (i + 12).ToString() + ":F" + (i + 12).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["E" + (i + 12).ToString() + ":F" + (i + 12).ToString()].Value = "(Ký,họ tên)";
            exApp.Visible = true;
        }

        private void btnSLB_Click(object sender, EventArgs e)
        {
            Desc = "SoLuong";
            HienThi();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            Desc = "ThanhTien";
            HienThi();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
