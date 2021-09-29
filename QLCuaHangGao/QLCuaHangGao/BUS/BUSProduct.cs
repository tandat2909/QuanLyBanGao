using QLCuaHangGao.DAO.Model;
using QLCuaHangGao.DAO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangGao.BUS
{
    public class BUSProduct
    {
        ProductRepository dao_product = new ProductRepository();
        public Product Add(TextBox txtProductName,ComboBox cbxCate,TextBox txtPrice,TextBox txtDescript)
        {
            Product product = new Product()
            {
                ProductName =txtProductName.Text,
                CategoryID = ((Category)cbxCate.SelectedItem).CategoryId,
                Price = decimal.Parse(txtPrice.Text == null ? "0" : txtPrice.Text),
                Description = txtDescript.Text
            };
            return dao_product.Add(product);

        }

        public void GetAllProduct(ComboBox cbxSP)
        {
            cbxSP.DataSource = dao_product.GetAll();
            cbxSP.DisplayMember = "ProductName";
        }

        public void GetAllProduct(DataGridView dgxProduct)
        {
            dao_product.GetAll().ForEach(p =>
            {
                dgxProduct.Rows.Add(p.ProductId, p.ProductName, p.Category.CategoryName, p.Price, p.Description);
            });

        }

        internal Product GetProductById(TextBox txtSearchSP)
        {
           return dao_product.GetProduct(int.Parse(txtSearchSP.Text));
        }

        internal bool Delete(int productId)
        {
            return dao_product.Delete(productId);
        }

        internal Product Update(TextBox txtMaSP, TextBox txtTenSP, ComboBox cbxCate, TextBox txtDonGia, TextBox txtGhiChu)
        {
            Product p = new Product()
            {
                ProductId = int.Parse(txtMaSP.Text),
                ProductName = txtTenSP.Text,
                Price = decimal.Parse(txtDonGia.Text),
                Description = txtGhiChu.Text,
                Category = (Category)cbxCate.SelectedItem,

            };
            return dao_product.Update(p);
        }

       
    }
}
