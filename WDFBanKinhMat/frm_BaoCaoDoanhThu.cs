using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WDFBanKinhMat.Classes.CBBox;

namespace WDFBanKinhMat
{
    public partial class frm_BaoCaoDoanhThu : Form
    {
        Classes.DataConnect data = new Classes.DataConnect();
        Classes.DataConnect db = new Classes.DataConnect();

        int Nam, Thang, i =0;
        public frm_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        
        public Decimal ChiPhi(int Nam, int Thang)
        {
            String query = "select sum(DonGia*SoLuong-(DonGia*SoLuong*GiamGia)/100) " +
                "from HoaDonNhap inner join ChiTietHDN on HoaDonNhap.SoHDN=ChiTietHDN.SoHDN " +
                "where year(NgayNhap)='" + 2022 + "' and month(NgayNhap)='" + 1 + "'";
            return db.ExcuteScalar(query).ToString() == "" ? 0 : Decimal.Parse(db.ExcuteScalar(query).ToString());
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDoanhThu_Click(object sender, EventArgs e)
        {
            Decimal Tong = 0;
            for (int i = 0; i < 12; i++)
            {
                Tong += Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[i + 1].Value.ToString());
            }
            txtTong.Text = Tong.ToString("#,###0");
            Decimal TongQuyI = Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[1].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[2].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[3].Value.ToString());
            txtQuyI.Text = TongQuyI.ToString("#,###0");
            Decimal TongQuyII = Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[4].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[5].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[6].Value.ToString());
            txtQuyII.Text = TongQuyII.ToString("#,###0");
            Decimal TongQuyIII = +Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[7].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[8].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[9].Value.ToString());
            txtQuyIII.Text = TongQuyIII.ToString("#,###0");
            Decimal TongQuyIV = Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[10].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[11].Value.ToString())
            + Decimal.Parse(dgvDoanhThu.CurrentRow.Cells[12].Value.ToString());
            txtQuy4.Text = TongQuyIV.ToString("#,###0");


            try
            {
                Double max = Double.Parse(dgvDoanhThu.CurrentRow.Cells[1].Value.ToString());
                for (int i = 2; i < 12; i++)
                {
                    if (max < Double.Parse(dgvDoanhThu.CurrentRow.Cells[i].Value.ToString()))
                    {
                        max = Double.Parse(dgvDoanhThu.CurrentRow.Cells[i].Value.ToString());
                    }
                }
                if (chartDoanhThu.ChartAreas[0].AxisY.Maximum < max) chartDoanhThu.ChartAreas[0].AxisY.Maximum = max;

                chartDoanhThu.Series.Clear();
                for (int n = 0; n < dgvDoanhThu.Rows.Count; n++) //Duyệt từ dòng đầu tiên đến dòng cuối cùng của dataGridView1
                {
                    if (dgvDoanhThu.Rows[n].Selected) //Nếu dòng thứ n được chọn thì thêm series cho dòng đó
                    {
                        Console.WriteLine(dgvDoanhThu.Rows[n]);
                        Series s = new Series();
                        s.Name = "Doanh thu";
                        s.ChartType = SeriesChartType.Column;
                        for (int i = 0; i < 12; i++)
                        {
                            DataPoint p = new DataPoint();
                            p.XValue = i;
                            p.SetValueY(dgvDoanhThu.Rows[n].Cells[i + 1].Value.ToString() == "" ? 0 : Double.Parse(dgvDoanhThu.Rows[n].Cells[i + 1].Value.ToString()));
                            p.AxisLabel = "Tháng " + (i + 1).ToString();
                            p.ToolTip = dgvDoanhThu.Rows[n].Cells[i + 1].Value.ToString() == "" ? "0" : dgvDoanhThu.Rows[n].Cells[i + 1].Value.ToString();
                            s.Points.Add(p);
                        }
                        chartDoanhThu.Series.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvDoanhThu_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        
        private void frm_BaoCao_Load(object sender, EventArgs e)
        {
            String query = "select * from (select year(NgayBan) as Nam,month(NgayBan) as Thang,SoLuong*DonGia-(SoLuong*DonGia*GiamGia/100) as ThanhTien " +
                "from  HoaDonBan INNER join ChiTietHDB on HoaDonBan.SoHDB=ChiTietHDB.SoHDB )src pivot(sum(ThanhTien) " +
                "for Thang in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12]))piv;";
            DataTable tbl = db.ReadData(query);

            List<BaoCao> list = new List<BaoCao>();
            BaoCao baoCao = new BaoCao();

            for(int i = 0; i < tbl.Rows.Count; i++)
            {
                Nam = int.Parse(tbl.Rows[i]["Nam"].ToString());
                baoCao = new BaoCao()
                {
                    Nam =int.Parse(tbl.Rows[i]["Nam"].ToString()),
                    T1 = tbl.Rows[i][1].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][1].ToString()) - ChiPhi(Nam, 1)).ToString("#,###0"),
                    T2 = tbl.Rows[i][2].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][2].ToString()) - ChiPhi(Nam, 2)).ToString("#,###0"),
                    T3 = tbl.Rows[i][3].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][3].ToString()) - ChiPhi(Nam, 3)).ToString("#,###0"),
                    T4 = tbl.Rows[i][4].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][4].ToString()) - ChiPhi(Nam, 4)).ToString("#,###0"),
                    T5 = tbl.Rows[i][5].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][5].ToString()) - ChiPhi(Nam, 5)).ToString("#,###0"),
                    T6 = tbl.Rows[i][6].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][6].ToString()) - ChiPhi(Nam, 6)).ToString("#,###0"),
                    T7 = tbl.Rows[i][7].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][7].ToString()) - ChiPhi(Nam, 7)).ToString("#,###0"),
                    T8 = tbl.Rows[i][8].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][8].ToString()) - ChiPhi(Nam, 8)).ToString("#,###0"),
                    T9 = tbl.Rows[i][9].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][9].ToString()) - ChiPhi(Nam, 9)).ToString("#,###0"),
                    T10 = tbl.Rows[i][10].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][10].ToString()) - ChiPhi(Nam, 10)).ToString("#,###0"),
                    T11 = tbl.Rows[i][11].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][11].ToString()) - ChiPhi(Nam, 11)).ToString("#,###0"),
                    T12 = tbl.Rows[i][12].ToString() == "" ? "0" : (decimal.Parse(tbl.Rows[i][12].ToString()) - ChiPhi(Nam, 12)).ToString("#,###0"),
                };
                list.Add(baoCao);
               
            }
            dgvDoanhThu.DataSource = list;
            dgvDoanhThu.Columns[0].HeaderText = "Năm";
            dgvDoanhThu.Columns[1].HeaderText = "Tháng 1";
            dgvDoanhThu.Columns[2].HeaderText = "Tháng 2";
            dgvDoanhThu.Columns[3].HeaderText = "Tháng 3";
            dgvDoanhThu.Columns[4].HeaderText = "Tháng 4";
            dgvDoanhThu.Columns[5].HeaderText = "Tháng 5";
            dgvDoanhThu.Columns[6].HeaderText = "Tháng 6";
            dgvDoanhThu.Columns[7].HeaderText = "Tháng 7";
            dgvDoanhThu.Columns[8].HeaderText = "Tháng 8";
            dgvDoanhThu.Columns[9].HeaderText = "Tháng 9";
            dgvDoanhThu.Columns[10].HeaderText = "Tháng 10";
            dgvDoanhThu.Columns[11].HeaderText = "Tháng 11";
            dgvDoanhThu.Columns[12].HeaderText = "Tháng 12";
            chartDoanhThu.Palette = ChartColorPalette.Chocolate;

        }


    }
}
