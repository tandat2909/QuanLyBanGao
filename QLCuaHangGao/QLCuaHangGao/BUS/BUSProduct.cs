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
        ProductRepository productRepository = new ProductRepository();
        public Product Add(TextBox txtProductName,ComboBox cbxCate,TextBox txtPrice,TextBox txtDescript)
        {
            Product product = new Product()
            {
                ProductName =txtProductName.Text,
                CategoryID = ((Category)cbxCate.SelectedItem).CategoryId,
                Price = decimal.Parse(txtPrice.Text == null ? "0" : txtPrice.Text),
                Description = txtDescript.Text
            };
            return productRepository.Add(product);

        }

        internal void GetAllProduct(ComboBox cbxSP)
        {
            cbxSP.DataSource = productRepository.GetAll();
            cbxSP.DisplayMember = "ProductName";
        }

        public void GetAllProduct(DataGridView dgxProduct)
        {
            productRepository.GetAll().ForEach(p =>
            {
                dgxProduct.Rows.Add(p.ProductId, p.ProductName, p.Category.CategoryName, p.Price, p.Description);
            });

        }

        internal Product GetProductById(TextBox txtSearchSP)
        {
           return productRepository.GetProduct(int.Parse(txtSearchSP.Text));
        }

        internal bool Delete(int productId)
        {
            return productRepository.Delete(productId);
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
            return productRepository.Update(p);
        }

       
    }
}
