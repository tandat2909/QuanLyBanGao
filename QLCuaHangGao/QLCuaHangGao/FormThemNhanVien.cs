using QLCuaHangGao.DAO.Model;
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
    public partial class FormThemNhanVien : Form
    {
       
        BUS.BUSUser busUser = new BUS.BUSUser();
        public FormThemNhanVien()
        {
            InitializeComponent();
        
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
           
        }
        private void resetinput()
        {
            txtHo.Text = txtPassword.Text = txtTenNV.Text = txtHo.Text = "";
            txtUserName.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User usernew = busUser.AddNV(txtUserName, txtPassword, txtHo, txtTenNV);
                MessageBox.Show("Tạo thông tin tài khoản " + usernew.GetFullName() +" thành công");
                resetinput();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
