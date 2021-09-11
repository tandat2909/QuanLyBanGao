using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace DAO
{
    public class User
    {
        
        [Key,Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [StringLength(50), Index(IsUnique = true)]
        public string UserName { set; get; }
        [StringLength(300)]
        public string Password { set; get; }
        //[Timestamp]
        public DateTime BirthDay { set; get; } 
        [StringLength(50)]
        public string FirstName { set; get; }
        [StringLength(50)]
        public string LastName { set; get; }

        public DateTime CreatedDate { set; get; } = DateTime.Now;

        public bool is_active { get; set; } = true;

        [Required]
        public int RoleID { set; get; }

        public virtual Role Role { set; get; }

        #region Function

        public string GetFullName()
        {
            return FirstName + LastName;
        }
       
        public override string ToString()
        {

            return FirstName + " " + LastName;
        }
        #endregion
       
    }
}
