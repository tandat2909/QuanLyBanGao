
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

            ManageContext context = new ManageContext();
            BUSUser bus = new BUSUser();

            try
            {
                 bool status = bus.Login(txtID, txtPass);
                if (status)
                {
                    MessageBox.Show("Login thành công");
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
