
using QLCuaHangGao.BUS;
using QLCuaHangGao.DAO;
using QLCuaHangGao.DAO.Model;
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
            bus.initData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void loginuser()
        {
            try
            {
                if (String.IsNullOrEmpty(txtPass.Text.Trim()) && String.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    MessageBox.Show("Please enter Username and Password !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (String.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    MessageBox.Show("Please enter Username!     ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtPass.Text.Trim()))
                {
                    MessageBox.Show("Please enter Password!     ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Focus();
                    return;
                }
                User userLogin = bus.Login(txtID, txtPass);
                if (userLogin != null)
                {
                    Utils.userCurrent = userLogin;
                    FormQLBanHang formQLBanHang = new FormQLBanHang(this);
                    formQLBanHang.Show();
                    txtID.Clear();
                    txtPass.Clear();
                    this.Hide();
                }
                else
                {

                    txtID.Focus();
                    MessageBox.Show("You entered the wrong password or username, please re-enter!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginuser();
           
        }
        void loginWithKeyEnter(PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) loginuser();
        }
        private void txtPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            loginWithKeyEnter(e);
        }

        private void txtID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            loginWithKeyEnter(e);
        }
    }
}
