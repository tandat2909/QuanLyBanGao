
using QLCuaHangGao.BUS;
using QLCuaHangGao.DAO;
using QLCuaHangGao.DAO.Repository;
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
    public partial class FormLogin : Form
    {
        BUSUser bus = new BUSUser();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = bus.Login(txtID, txtPass);
                if (status)
                {
                    FormQLBanHang formQLBanHang = new FormQLBanHang(this);
                    formQLBanHang.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
