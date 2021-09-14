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
    public partial class FormChiTietHoaDon : Form
    {
        BUS.BUSOrderDetail busOrderDetail = new BUS.BUSOrderDetail();
        int orderId;
        public FormChiTietHoaDon(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            loadChiTietHoaDon();
        }
        void loadChiTietHoaDon()
        {
            busOrderDetail.GetOrderDetailByOrder(orderId, dgvCTHD);
        }
    }
}
