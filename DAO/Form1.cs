using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public partial class Form1 : Form
    {
        ManageContext s = new ManageContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Role a = new Role()
            {
                Name = "Admin",
                CreateDate = DateTime.Now,
                is_active = true,
                RoleId =1
                
            };
            Role b = new Role()
            {
                Name = "Customer",
                CreateDate = DateTime.Now,
                is_active = true
            };
            s.Roles.Add(a);
            s.SaveChanges();
        }
    }
}
