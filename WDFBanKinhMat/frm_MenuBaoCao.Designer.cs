namespace WDFBanKinhMat
{
    partial class frm_MenuBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doanhSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiPhisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.doanhSốToolStripMenuItem,
            this.chiPhisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuBaoCao";
            // 
            // doanhSốToolStripMenuItem
            // 
            this.doanhSốToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhSốToolStripMenuItem.Name = "doanhSốToolStripMenuItem";
            this.doanhSốToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.doanhSốToolStripMenuItem.Text = "Doanh Số";
            this.doanhSốToolStripMenuItem.Click += new System.EventHandler(this.doanhSốToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // chiPhisToolStripMenuItem
            // 
            this.chiPhisToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiPhisToolStripMenuItem.Name = "chiPhisToolStripMenuItem";
            this.chiPhisToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.chiPhisToolStripMenuItem.Text = "Chi Phí";
            this.chiPhisToolStripMenuItem.Click += new System.EventHandler(this.chiPhisToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 722);
            this.panel1.TabIndex = 1;
            // 
            // frm_MenuBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MenuBaoCao";
            this.Text = "frm_MenuBaoCao";
            this.Load += new System.EventHandler(this.frm_MenuBaoCao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiPhisToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}