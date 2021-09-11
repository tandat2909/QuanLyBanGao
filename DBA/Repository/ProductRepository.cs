using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace DBA.Repository
{
    public class ProductException : Exception
    {
        public ProductException() : base() { }
        public ProductException(string message) : base(message)
        {
        }
        
    }
    public class ProductRepository:ContextRepository
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public Product GetProduct(int productId)
        {
            /*ManageContext db = new ManageContext();
            var pro = db.Products.Where(p => p.ProductId == productId && p.is_active == true).FirstOrDefault();
            return (Product)pro;*/

            return GetContext().Products.FirstOrDefault(p => p.ProductId == productId && p.is_active == true);
           
        }

        public Product GetProduct(string name)
        {

            return GetContext().Products.FirstOrDefault(p => p.ProductName == name && p.is_active == true);

        }
        public List<Product> GetAll()
        {
            /*
                khi lấy danh sách hay lấy một sản phẩm thì phải thêm điều kiện is_active = true
                */
            return GetContext().Products.Where(p=> p.is_active == true).ToList();
        }

        public List<Product> GetProductByName(string productName)
        {
            // Gạo tẻ 
            // Gạo nếp
            // gạo
            // where ProductName like %gạo%
            return GetContext().Products.Where(p => p.is_active == true && p.ProductName.Contains(productName)).ToList();
            /*
             Có thể dùng cho chức năng search product theo tên
             */
        }
        public Product Add(Product product)
        {
            // 1 sản phảm tạo mới không được trùng tên sản hiện có trong database
            try
            {
                ValidateProduct(product);
                if (GetProduct(product.ProductName) != null) throw new ValidateException("Tên sản phẩm tồn tại");
                ManageContext context = GetContext();
                if(product.CategoryID == 0)
                {
                    product.CategoryID = product.Category.CategoryId;
                }

                Product instance = context.Products.Add(product);
                context.SaveChanges();
                return instance;
            }
            catch (DbUpdateException)
            {
                throw new ProductException("Thêm sản phẩm mới thất bại");
            }
            /*
             Phương thức thêm sản phẩm vào cơ sở dữ liệu trả ra đối tượng mới được thêm vào 
             vd : Product instance = context.Product.Add(product)
                  context.SaveChanges()
                  return instance
             */
        }
        private bool ValidateProduct(Product productNew)
        {
           
            if (productNew.ProductName == null || productNew.ProductName.Trim().Length <= 0 ) throw new ValidateException("Tên sản phẩm không được để trống");
            if (productNew.Price == decimal.MinValue ) throw new ValidateException("Giá sản phẩm không được để trống");
            if (productNew.Price < 1) throw new ValidateException("Giá sản phẩm không hợp lệ");
            
            if (productNew.CategoryID == 0)
            {
                if (productNew.Category == null)
                {
                    throw new ProductException("Danh mục sản phảm không thể để trống");
                }
            }
            
            if(categoryRepository.GetCategory(productNew.CategoryID) == null )
            {
                if(categoryRepository.GetCategory(productNew.Category.CategoryId) == null)
                     throw new ValidateException("Danh mục không tồn tại");
                
            }
            return true;
        }
        public Product Update (Product productNew)
        {
            /*
             * Phuong thức update cho cập nhật thong tin sản phẩm không cho thay đổi trường is_active
             */
            try
            {
                //validate product
                ValidateProduct(productNew);
                ManageContext db = GetContext();
                Product current = db.Products.First(p => p.ProductId == productNew.ProductId && p.is_active == true);
                current.ProductName = productNew.ProductName;
                current.Price = productNew.Price;
                current.Description = productNew.Description;
                current.CategoryID = productNew.CategoryID;
                current.Amount = productNew.Amount;
                db.SaveChanges();
                return current;
            }
            catch( DbUpdateException)
            {
                throw new ProductException("Cập nhật sản phẩm thất bại");
            }
        }
        public bool Delete(Product p)
        {
            return Delete(p.ProductId);
        }

        public bool Delete(int productId)
        {
            /*
             Phương thức delete chỉ thay đổi trường is_active = false rồi lưu lại trả về true nếu có sai hoặc không tìm thấy thì trả ra false 
             */
            try
            {
                //ApplicationDBContext db = new ApplicationDBContext();
                
                ManageContext db = GetContext();
                Product product = db.Products.First(p => p.ProductId == productId); //method
                product.is_active = false; 
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }

    }
}
