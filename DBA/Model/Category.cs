using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBA
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required, StringLength(50), Display(Name = "Tên danh mục"), Index(IsUnique = true)]
        public string CategoryName { get; set; }
        [Display(Name = "Mô tả chi tiết")]
        public string Description { get; set; }
        public bool is_active { set; get; } = true;

       // public ISet<Product> Products;
    }
}
