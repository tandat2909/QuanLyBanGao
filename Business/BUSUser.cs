using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DAO.Repository;
namespace Business
{
    public class BUSUser
    {
        UserRepository userRepository = new UserRepository();
        RoleRepository r = new RoleRepository();

         public bool Login(TextBox txtUserName,TextBox txtpassword)
        {
            Role a = new Role()
            {
                Name = "Admin",
                CreateDate = DateTime.Now,
                is_active = true
            };
            Role b = new Role()
            {
                Name = "Customer",
                CreateDate = DateTime.Now,
                is_active = true
            };
            r.add(a);
            r.add(b);
            userRepository.Add(new User()
            {
                UserName = "admin",
                Password = "Admin@123",
                BirthDay = DateTime.Now,
                FirstName = " Vũ Tấn",
                LastName = "Đạt",

            });

            return userRepository.Login(txtUserName.Text, txtpassword.Text);
        }
    }
}
