using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangGao.DAO.Model
{
    public class OrderDetail
    {
        [Key]
        [Column (Order =1)]
        public int OrderId { get; set; }
        public virtual Order OrderTable { get; set; }
        [Key]
        [Column(Order = 2),Index(IsUnique = true)]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
