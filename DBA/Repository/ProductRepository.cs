using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBA.Repository
{
    public class ProductRepository:ContextRepository
    {
        public Product GetProduct(int productId)
        {

            throw new Exception("Viết phương thuc get products");
        }
        public List<Product> GetAll()
        {
                /*
                    khi lấy danh sách hay lấy một sản phẩm thì phải thêm điều kiện is_active = true
                 */
            return GetContext().Products.Select(p => p).ToList();
        }
        public List<Product> GetProductByName(string productName)
        {
            /*
             Có thể dùng cho chức năng search product theo tên
             */
            throw new Exception("Viết phương thức get product theo tên");
        }
        public Product Add(Product product)
        {
            /*
             Phương thức thêm sản phẩm vào cơ sở dữ liệu trả ra đối tượng mới được thêm vào 
             vd : Product instance = context.Product.Add(product)
                  context.SaveChanges()
                  return instance
             */
            
            return product;
        }

        public Product Update()
        {
            /*
             * Phuong thức update cho cập nhật thong tin sản phẩm không cho thay đổi trường is_active
             */
            throw new Exception("chưa làm");
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
                ManageContext db = new ManageContext();
                Product product = GetContext().Products.Where(p => p.ProductId == productId).First(); //method
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
