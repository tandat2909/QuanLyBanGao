using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DBA;
using DBA.Repository;
namespace Business
{
    public class BUSProduct
    {
        ProductRepository productRepository = new ProductRepository();

        public Product addProduct(TextBox txtProName,TextBox txtPrice,ComboBox cbxCate)
        {
            Product productNew = new Product()
            {
                ProductName = txtProName.Text,
                Price = decimal.Parse(txtPrice.Text),
                CategoryID = ((Category) cbxCate.SelectedItem).CategoryId
            };
            return productRepository.Add(productNew);


           
        }
        public void updateList(DataGridView dataGridView)
        {
            dataGridView.DataSource = productRepository.GetAll();
        }
    }
}
