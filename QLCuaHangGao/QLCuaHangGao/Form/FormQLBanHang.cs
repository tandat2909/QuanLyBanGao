using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangGao
{
    public partial class FormQLBanHang : Form
    {
        int PanelWidth;
        bool isCollapsed;
        FormLogin formLogin;
        public FormQLBanHang(FormLogin form)
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            formLogin = form;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTimer.Text = dt.ToString("HH:mm:ss");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            formLogin.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            f.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            FormKhoHang f = new FormKhoHang();
            f.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien();
            f.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            f.ShowDialog();
        }
    }
}
