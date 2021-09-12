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
    }
}
