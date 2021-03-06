using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DBA.Repository
{
   public class RoleRepository:ContextRepository
    {

        
        public Role add(Role r)
        {
            return GetContext().Roles.Add(r);
        }

        public List<Role> getAll()
        {
            
            List<Role> role = GetContext().Roles.Select(u => u).ToList();
            return role;
        }
        public Role getRolebyName(string name){
            Role r = GetContext().Roles.FirstOrDefault(u => u.Name == name);
           
            return r;
        }

        public bool delete(int id)
        {
            try
            {
                ManageContext context = GetContext();
                Role r = context.Roles.FirstOrDefault(o => o.RoleId == id);
                r.is_active = false;
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("RoleRepository:delete"+e.Message);
                Console.WriteLine("RoleRepository:delete"+e.StackTrace);
                return false;
            }
           
        }
    }
}
