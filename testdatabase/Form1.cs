using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBA.Repository;
using DBA;
using Business;

namespace testdatabase
{
    public partial class Form1 : Form
    {
        BUSProduct bUSPRoduct = new BUSProduct();



        UserRepository usermanager = new UserRepository();
        ProductRepository productRepository = new ProductRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            usermanager.GetAll().ForEach(i => label1.Text += i.GetFullName());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(textBox1.Text);
                User sssss = new User()
                {
                    LastName = "Tấn Đạt",
                    FirstName = "Vũ",
                    Password = "Tinice@123",
                    UserName = textBox1.Text,
                    BirthDay = DateTime.Now
                };
                MessageBox.Show((sssss.BirthDay == DateTime.MinValue).ToString());
                User instance = usermanager.Add(sssss);
                MessageBox.Show("sdfsdf :" + instance.GetFullName());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
                MessageBox.Show(ex.HelpLink);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usermanager.Login(txtusername.Text, txtpassword.Text))
            {
                MessageBox.Show("Login thành công");
            }
            else
            {
                MessageBox.Show("login Thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usermanager.Delete(int.Parse(textBox1.Text)))
            {
                MessageBox.Show("xóa thành công");
            }
            else
            {
                MessageBox.Show("xóa Thất bại");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCateAdd_Click(object sender, EventArgs e)
        {

            Category cate = categoryRepository.Add(new Category()
            {
                CategoryName = txtCate.Text

            });
            MessageBox.Show(cate.ToString());
            UpdateListCate();
        }
        public void UpdateListCate()
        {
            cbxCate.DataSource = categoryRepository.GetAll();
            cbxCate.DisplayMember = "CategoryName";
            //cbxCate.SelectedIndex = 0;

        }
        private void UpdateListProduct()
        {
            cbxProduct.DataSource = productRepository.GetAll();
            cbxProduct.DisplayMember = "ProductName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListCate();
            UpdateListProduct();
        }

        private void cbxCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cateSelect = (Category)cbxCate.SelectedItem;
            txtCate.Text = cateSelect.CategoryName;

        }

        private void btnCateDelete_Click(object sender, EventArgs e)
        {
            Category cateSelect = (Category)cbxCate.SelectedItem;
            if (categoryRepository.Delete(cateSelect))
            {
                MessageBox.Show("Xóa thành công");
                UpdateListCate();
            }

            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnCateUpdate_Click(object sender, EventArgs e)
        {
            Category cateSelect = (Category)cbxCate.SelectedItem;
            cateSelect.CategoryName = txtCate.Text;
            categoryRepository.Update(cateSelect);
            UpdateListCate();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {

            Product pronew = bUSPRoduct.addProduct(txtProductName, txtProPrice, cbxCate);
            UpdateListProduct();


            Category cateSelect = (Category)cbxCate.SelectedItem;
            Product newProduct = new Product()
            {
                Price = decimal.Parse(txtProPrice.Text),
                ProductName = txtProductName.Text,
                CategoryID = cateSelect.CategoryId,
                Amount = 100
            };
            MessageBox.Show(newProduct.ToString());
            Product p = productRepository.Add(newProduct);
            MessageBox.Show(p.ToString());
            UpdateListProduct();
        }

    

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            Product pro = (Product)cbxProduct.SelectedItem;
            if (productRepository.Delete(pro)) {
                MessageBox.Show("Xóa sản phẩm thành công");
                UpdateListProduct();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }
    }
}
