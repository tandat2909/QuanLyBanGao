
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHangGao.DAO.Repository
{
    public class CategoryException : Exception
    {
        public CategoryException() : base() { }
        public CategoryException(string message) : base(message)
        {
        }
    }
    public class CategoryRepository : ContextRepository
    {
        public Category GetCategory(int categoryId)
        {
            return GetContext().Categories.FirstOrDefault(c => c.CategoryId == categoryId && c.is_active == true);
        }
        public Category GetCategory(string categoryName)
        {
            return GetContext().Categories.FirstOrDefault(c => c.CategoryName == categoryName && c.is_active == true);
        }
        public List<Category> GetAll()
        {
            return GetContext().Categories.Where(c => c.is_active == true).ToList();
        }
        public Category Add(Category category)
        {
            ManageContext context = GetContext();
            if (GetCategory(category.CategoryName) != null) throw new ValidateException("Tên Danh mục đã tồn tại");
            Category instance = context.Categories.Add(category);
            context.SaveChanges();
            return instance;
        }
        public bool Delete(Category category)
        {
            return Delete(category.CategoryId);
        }

        public bool Delete(int categoryId)
        {
            try
            {
                ManageContext context = GetContext();
                Category current = context.Categories.First(p => p.CategoryId == categoryId);
                current.is_active = false;
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw new CategoryException("Không tìm thấy danh mục cần xóa ");
                //return false;
            }
        }

        public Category Update(Category cate)
        {
            try
            {
                ManageContext context = GetContext();
                Category current = context.Categories.First(c => c.CategoryId == cate.CategoryId);
                current.CategoryName = cate.CategoryName;
                context.SaveChanges();
                return current;
            }
            catch
            {
                throw new CategoryException("Cập nhậtthông tin thất bại");
            }

        }
    }
}
