using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public bool is_active { get; set; } = true;
        [Required]
        public int UserId { set; get; }
        public virtual User User { set; get; }
       
    }
}
