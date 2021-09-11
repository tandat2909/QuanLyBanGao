using QLCuaHangGao.DAO.Model;
using QLCuaHangGao.DAO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangGao.BUS
{
    public class BUSUser
    {
        UserRepository userRepository = new UserRepository();
        public bool Login(TextBox txtUserName,TextBox txtPassword)
        {
           /* User a = new User()
            {
                FirstName = "Vũ Tấn",
                LastName = "Đạt",
                BirthDay = DateTime.Now,
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            userRepository.Add(a);*/

            return userRepository.Login(txtUserName.Text, txtPassword.Text);
        }
        public void getAllEmloyee(DataGridView dgvUser)
        {
            dgvUser.DataSource = userRepository.GetAll();

        }
    }
}
