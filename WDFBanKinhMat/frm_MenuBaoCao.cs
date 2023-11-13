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
    public partial class frm_MenuBaoCao : Form
    {
        public frm_MenuBaoCao()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frm_MenuBaoCao_Load(object sender, EventArgs e)
        {

         
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_BaoCaoDoanhThu());
        }

        private void doanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_BaoCaoDoanhSo());

        }

        private void chiPhisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_BaoCaoChiPhi());

        }
    }
}
