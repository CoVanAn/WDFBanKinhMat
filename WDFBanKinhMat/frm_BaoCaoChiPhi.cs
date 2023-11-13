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
    public partial class frm_BaoCaoChiPhi : Form
    {
        DataConnect db = new DataConnect();

        public frm_BaoCaoChiPhi()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoChiPhi_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            String query = "select NhaCungCap.MaNCC,NhaCungCap.TenNCC,Sum(TongTien)as ChiPhi from NhaCungCap inner join HoaDonNhap on NhaCungCap.MaNCC=HoaDonNhap.MaNCC where NgayNhap>='" + dtpTu.Value + "' and NgayNhap<='" + dtpDen.Value + "' group by NhaCungCap.MaNCC,NhaCungCap.TenNCC";
            DataTable tbl = db.ReadData(query);
            Decimal Tong = 0;
            dgvChiPhi.Rows.Clear();
            foreach (DataRow row in tbl.Rows)
            {
                String[] rowss =
                {
                    row["MaNCC"].ToString(),
                    row["TenNCC"].ToString(),
                    Decimal.Parse(row["ChiPhi"].ToString()).ToString("#,###0")
                };
                Tong += Decimal.Parse(row["ChiPhi"].ToString());
                dgvChiPhi.Rows.Add(rowss);
            }
            txtTongKH.Text = Tong.ToString("#,###0");
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
            exRange.Range["C4:F4"].Value = "BÁO CÁO CHI PHÍ THEO NHÀ CUNG CẤP";
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
            exRange.Range["C8:C8"].Value = "Mã nhà cung cấp";
            exRange.Range["C8:C8"].ColumnWidth = 20;
            exRange.Range["D8:D8"].Value = "Tên nhà cung cấp";
            exRange.Range["D8:D8"].ColumnWidth = 30;
            exRange.Range["E8:E8"].ColumnWidth = 30;
            exRange.Range["E8:E8"].Value = "Chi phí";
            for (i = 0; i < dgvChiPhi.Rows.Count; i++)
            {
                exSheet.Range["A" + (i + 9).ToString() + ":F" + (i + 9).ToString()].Font.Bold = false;
                exSheet.Range["A" + (i + 9).ToString() + ":F" + (i + 9).ToString()].Font.Size = 13;
                exSheet.Range["B" + (i + 9).ToString()].Value = (i + 1).ToString();
                exSheet.Range["C" + (i + 9).ToString()].Value = dgvChiPhi.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["D" + (i + 9).ToString()].Value = dgvChiPhi.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["E" + (i + 9).ToString()].Value = dgvChiPhi.Rows[i].Cells[2].Value.ToString();
            }
            exRange.Range["E" + (i + 9).ToString()].Font.Size = 13;
            exRange.Range["E" + (i + 9).ToString()].Value = "Tổng chi phí:  " + txtTongKH.Text + " VNĐ";
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].Font.Size = 13;
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].MergeCells = true;
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D" + (i + 11).ToString() + ":E" + (i + 11).ToString()].Value = "Người lập báo cáo";
            exSheet.Range["D" + (i + 12).ToString() + ":E" + (i + 12)].MergeCells = true;
            exSheet.Range["D" + (i + 12).ToString() + ":E" + (i + 12).ToString()].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D" + (i + 12).ToString() + ":E" + (i + 12).ToString()].Value = "(Ký,họ tên)";
            exSheet.Name = "BC-CPNH";
            exApp.Visible = true;
        }
    }
}
