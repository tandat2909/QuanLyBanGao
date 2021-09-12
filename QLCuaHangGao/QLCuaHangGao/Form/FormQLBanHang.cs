using QLCuaHangGao.BUS;
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangGao
{
    public partial class FormQLBanHang : Form
    {
        int PanelWidth;
        bool isCollapsed;
        FormLogin formLogin;
        BUSProduct busProduct = new BUSProduct();
        BUSOrder busOrder = new BUSOrder();
        public FormQLBanHang(FormLogin form)
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            formLogin = form;

        }

        public FormQLBanHang()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
           
        }
        private void FormQLBanHang_Load(object sender, EventArgs e)
        {
          
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
            Utils.userCurrent = null;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Product sp =  busProduct.GetProductById(txtSearchSP);
            if (sp != null)
            {
                lbMaSP.Text = sp.ProductId.ToString();
                lbNameSP.Text = sp.ProductName;
                lbPriceSP.Text = sp.Price.ToString();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm với mã sản phẩm là: " + txtSearchSP.Text);
            }

        }

        private void txtSearchSP_TextChanged(object sender, EventArgs e)
        {
            Regex number = new Regex(@"^\d+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!number.IsMatch(txtSearchSP.Text))
            {
                if (txtSearchSP.Text.Length >= 1) txtSearchSP.Text = txtSearchSP.Text.Substring(0, txtSearchSP.Text.Length - 1);
                else txtSearchSP.Text = "";
                txtSearchSP.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool kiemtra = true;

            foreach (DataGridViewRow item in dgvOrder.Rows)
            {
                Console.WriteLine(item.Cells[1].Value);
                if (item.Cells[1].Value != null && item.Cells[1].Value.ToString() == lbMaSP.Text.ToString()) //co maSP hay ko
                {
                    kiemtra = false;
                    // tang so luong
                    item.Cells[2].Value = decimal.Parse(item.Cells[2].Value.ToString()) + nubSL.Value;
                    break;
                }
            }
            if (kiemtra) dgvOrder.Rows.Add(lbNameSP.Text, lbMaSP.Text, nubSL.Value.ToString(), lbPriceSP.Text);
            
            lbTongTien.Text = (decimal.Parse(lbTongTien.Text) + decimal.Parse(lbPriceSP.Text) * nubSL.Value).ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgvOrder.SelectedCells)
            {
                if (  c.RowIndex >= dgvOrder.Rows.Count -1)
                {
                    MessageBox.Show("Chọn sản phẩm cần xóa");
                    break;
                }
                if (c.Selected)
                    dgvOrder.Rows.RemoveAt(c.RowIndex);
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            Order od = busOrder.Add(dgvOrder, Utils.userCurrent);
            MessageBox.Show("MÃ Hóa đơn: " +  od.OrderId+ "Tổng hóa đơn: " + od.total.ToString());
        }

        
    }
}
