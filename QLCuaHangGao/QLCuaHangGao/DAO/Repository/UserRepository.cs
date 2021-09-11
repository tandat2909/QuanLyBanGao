
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace QLCuaHangGao.DAO.Repository
{

    public class UserException : Exception
    {
        public UserException() : base() { }
        public UserException(string message) : base(message)
        {
        }
    }
    public class ValidateException : Exception
    {
        public ValidateException() : base() { }
        public ValidateException(string message) : base(message)
        {
        }
    }

    public class UserRepository : ContextRepository
    {

        RoleRepository role = new RoleRepository();

        public User getUserById(int id)
        {
            return GetContext().Users.FirstOrDefault(u => u.UserId == id);
        }
        public User GetUserByUserName(string userName)
        {
            return GetContext().Users.Where(u => u.UserName == userName).FirstOrDefault();
        }
        public List<User> GetAll() {

            List<User> users = GetContext().Users.Select(u => u).ToList();
            return users;
        }
        public User Add(User us)
        {
            /*
                Tạo thông tin tài khoản người dùng với quyền Employee
             */

            if (us == null) throw new UserException("Không có đối tượng user");
            Regex rgxUser = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$", RegexOptions.Compiled | RegexOptions.IgnoreCase); // tối thiểu 6 ký tự, ít nhất một chữ cái và một số
            Regex rgxpassword = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", RegexOptions.Compiled);//Tối thiểu tám ký tự, ít nhất một chữ cái, một số và một ký tự đặc biệt
            if (us.UserName == null || !rgxUser.IsMatch(us.UserName)) throw new ValidateException("Username tối thiểu 6 ký tự, ít nhất một chữ cái và một số");
            if (GetUserByUserName(us.UserName) != null) throw new ValidateException("Username tồn tại vui lòng chọn username khác");
            if (us.Password == null || !rgxpassword.IsMatch(us.Password)) throw new ValidateException("Password Tối thiểu tám ký tự, ít nhất một chữ cái, một số và một ký tự đặc biệt");
            // if (us.FirstName == null) throw new ValidateException("First Name không được để trống");
            if (us.LastName == null) throw new ValidateException("Last Name không được để trống");
            if (us.BirthDay == DateTime.MinValue) throw new ValidateException("Không được để trống thông tin birthday");
            us.Password = ComputeSha256Hash(us.Password);
            us.RoleID = role.getRolebyName("Employee").RoleId;
            us.CreatedDate = DateTime.Now;
            us.is_active = true;
            ManageContext context = GetContext();
            User instacne = context.Users.Add(us);
            context.SaveChanges();
            return instacne;

        }
        public User Update(User us)
        {
            ManageContext context = GetContext();
            User db_user =  context.Users.FirstOrDefault(u => u.UserId == us.UserId);
            db_user.BirthDay = us.BirthDay;
            db_user.FirstName = us.LastName;
            if(!CheckPassword(db_user,us.Password))
                db_user.Password = ComputeSha256Hash(us.Password);
            db_user.LastName = us.LastName;
            context.SaveChanges();
            return db_user;
        }
        public bool Delete(User us) {
            /*
             hàm xóa user không xóa user dưới cơ sở dữ liệu chỉ thay đổi trạng thái của cột is_active
             */
            
            return Delete(us.UserId);
        }
        public bool Delete(int userId)
        {
            /*
                hàm xóa user không xóa user dưới cơ sở dữ liệu chỉ thay đổi trạng thái của cột is_active
             */
            try
            {
                ManageContext context = new ManageContext();  
                User u = context.Users.First(us => us.UserId == userId);
                u.is_active = false;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool CheckPassword(User us, string passwordCheck)
        {
            return CheckPassword(us.Password, passwordCheck);
        }
        public List<Order> getOrderbyUser(User us)
        {
            List<Order> orders = new List<Order>();
            return orders;
        }

        public static bool CheckPassword(string password, string passwordCheck)
        {
            return ComputeSha256Hash(passwordCheck).Contains(password);

        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool Login(string username, string password)
        {
            password = ComputeSha256Hash(password);
            User us = GetContext().Users.FirstOrDefault(u => u.UserName == username && u.Password == password && u.is_active == true);
            return us != null;
        }
    }
}
