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
    public partial class FormChangePassword : Form
    {
        BUS.BUSUser busUser = new BUS.BUSUser();
        
        int EmployeeId = 0;
        public FormChangePassword(int EmployeeId)
        {
            InitializeComponent();
            this.EmployeeId = EmployeeId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (busUser.user_isAdmin(Utils.userCurrent))
                {
                    busUser.ChangePasswordByAdmin(EmployeeId, txtPassNew);
                }
                else 
                busUser.ChangePassword(txtPassOld, txtPassNew);
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            if (busUser.user_isAdmin(Utils.userCurrent))
            {
                txtPassOld.Enabled = false;
            }

        }
    }
}
