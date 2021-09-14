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
        RoleRepository roleRepository = new RoleRepository();
        public User Login(TextBox txtUserName, TextBox txtPassword)
        {
            return userRepository.Login(txtUserName.Text, txtPassword.Text);
        }
        internal void initData()
        {
            if( roleRepository.getAll().Count <= 0)
            {

              
                Role radmin = new Role()
                {
                    Name = "Admin"
                };
                Role rem = new Role()
                {
                    Name = "Employee"
                };
                Role instance_admin = roleRepository.add(radmin);
                roleRepository.add(rem);
                User us_admin = new User()
                {
                    UserName = "Admin123",
                    Password = "Admin@123",
                    FirstName = "Admin",
                    RoleID = instance_admin.RoleId,
                    LastName = "",
                };
                userRepository.AddAdmin(us_admin);

            }
        }
        internal void ChangePassword(TextBox txtPassOld, TextBox txtPassNew)
        {
            
            if (userRepository.CheckPassword(Utils.userCurrent, txtPassOld.Text))
                userRepository.ChangePassword(Utils.userCurrent.UserId, txtPassNew.Text);
            else throw new Exception("Mật khẩu cũ không đúng");
        }
        internal void ChangePasswordByAdmin(int employeeId, TextBox txtPassNew)
        {
            userRepository.ChangePassword(employeeId, txtPassNew.Text);
        }
        internal void loadRole(ComboBox cbxRole)
        {
            cbxRole.DataSource = roleRepository.getAll();
            cbxRole.DisplayMember = "Name";
        }

        internal User AddNV(TextBox txtUserName, TextBox txtPassword, TextBox txtHo, TextBox txtTenNV)
        {
            User usernew = new User()
            {
                FirstName = txtHo.Text,
                LastName = txtTenNV.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
            };
            return userRepository.Add(usernew);
        }

        public void getAllEmloyee(DataGridView dgvUser, User userLogin)
        {
            List<Role> rols = roleRepository.getAll();
            userRepository.GetAll(userLogin).
            ForEach(u => dgvUser.Rows.Add(u.UserId,u.UserName, u.FirstName, u.LastName, rols.Find(r => r.RoleId == u.RoleID).Name, u.CreatedDate));
        }

        internal bool delete(int userId)
        {
            return userRepository.Delete(userId);
        }

        internal User UpdatebyNV(TextBox txtMaNV,TextBox txtUserName, TextBox txtHo, TextBox txtTenNV, bool v, ComboBox cbxRole)
        {
            User a = new User
            {
                UserId = int.Parse(txtMaNV.Text),
                UserName = txtUserName.Text,
                FirstName = txtHo.Text,
                LastName = txtTenNV.Text,
                RoleID = v ? ((Role)cbxRole.SelectedItem).RoleId : 0
            };
            return userRepository.Update(a);
        }
        internal bool user_isAdmin(User user)
        {
            return user.RoleID == roleRepository.getRolebyName("Admin").RoleId;
        }

    }
}
