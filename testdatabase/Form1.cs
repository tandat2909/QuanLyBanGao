using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBA.Repository;
using DBA;

namespace testdatabase
{
    public partial class Form1 : Form
    {
      
        UserRepository usermanager = new UserRepository();
        ProductRepository p = new ProductRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            usermanager.GetAll().ForEach(i => label1.Text += i.GetFullName());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                MessageBox.Show(textBox1.Text);
                User sssss = new User()
                {
                    LastName = "Tấn Đạt",
                    FirstName = "Vũ",
                    Password = "Tinice@123",
                    UserName = textBox1.Text,
                    BirthDay = DateTime.Now
                };
                MessageBox.Show((sssss.BirthDay == DateTime.MinValue).ToString());
                User instance = usermanager.Add(sssss);
                MessageBox.Show("sdfsdf :" + instance.GetFullName());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
                MessageBox.Show(ex.HelpLink);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usermanager.Login(txtusername.Text, txtpassword.Text))
            {
                MessageBox.Show("Login thành công");
            }
            else
            {
                MessageBox.Show("login Thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usermanager.Delete(int.Parse(textBox1.Text)))
            {
                MessageBox.Show("xóa thành công");
            }
            else
            {
                MessageBox.Show("xóa Thất bại");
            }
        }
    }
}
