using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBA
{
    public class Role
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { set; get; }
        [StringLength(50), Index(IsUnique = true)]
        public string Name { set; get; }
       // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[DefaultValue(typeof(DateTime), DateTime.Now.ToString("yyyy-MM-dd"))]
        public DateTime CreateDate { set; get; } = DateTime.Now;
        public bool is_active { set; get; } = true;
        public virtual ISet<User> Users { get; }
    }
}
