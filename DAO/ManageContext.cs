using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAO
{
    public class ManageContext : DbContext
    {
        private static string connentstring = "Data Source=DESKTOP-TINICE;Initial Catalog=QLBANGAO;Integrated Security=True";
        public ManageContext(): base(connentstring) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails {set;get;}
        
     
    }
}
