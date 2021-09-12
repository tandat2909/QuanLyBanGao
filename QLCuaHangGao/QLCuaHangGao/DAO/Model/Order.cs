using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangGao.DAO.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public bool is_active { get; set; } = true;
        public decimal total { set; get; }

        [Required]
        public int UserId { set; get; }
        public virtual User User { set; get; }
       
    }
}
