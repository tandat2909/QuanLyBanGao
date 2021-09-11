using QLCuaHangGao.BUS;
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
    public partial class FormNhanVien : Form
    {
        BUSUser bUSUser = new BUSUser();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            updateListUser();
        }
        private void updateListUser()
        {
            bUSUser.getAllEmloyee(dgvChiTietNhanVien);
        }
    }
}
