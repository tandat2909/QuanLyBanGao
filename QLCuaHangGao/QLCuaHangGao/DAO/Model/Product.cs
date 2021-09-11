using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangGao.DAO.Model
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required, StringLength(50), Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }
        [Display(Name = "Mô tả sản phẩm")]
        public string Description { get; set; }
        [Required, Display(Name = "Giá")]
        public decimal Price { get; set; } = decimal.MinValue;

        public bool is_active { get; set; } = true;
        public decimal Amount { set; get; }
        [Required, Display(Name = "Danh mục")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public override string ToString()
        {
            return string.Format("Product<ProductId = {0}; ProductName = {1}; Price = {2} ;Amount = {3} Category = {4}>; is_active = {5} ",
                ProductId,ProductName,Price,Amount,CategoryID,is_active
                );
        }
    }

}
