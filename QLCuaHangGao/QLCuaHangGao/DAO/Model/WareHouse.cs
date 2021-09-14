using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangGao.DAO.Model
{
    public class WareHouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WareHouseId{ set; get; }
        [Required]
        public int ProductId { set; get; }
        public virtual Product Product { set; get; }
        public DateTime DateAdd { set; get; } = DateTime.Now;
        public decimal AmountAdd { set; get; } = 0;
        public decimal Inventory { set; get; } = 0;
        [Required]
        public int UserId { set; get; }
        public virtual User User { set; get; }
    }
}
