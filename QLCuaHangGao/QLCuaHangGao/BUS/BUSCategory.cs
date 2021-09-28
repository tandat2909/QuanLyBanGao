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
   public class BUSCategory
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        internal void GetAll(ComboBox cbxCate)
        {
           
            cbxCate.DataSource = categoryRepository.GetAll(); 
            cbxCate.DisplayMember = "CategoryName";
            

        }
        internal Category Add(TextBox txtCateName)
        {
            Category category = new Category()
            {
                CategoryName = txtCateName.Text
            };
           return categoryRepository.Add(category);

        }

        internal void GetAll(DataGridView dgvChiTietCate)
        {
            categoryRepository.GetAll().ForEach(c => dgvChiTietCate.Rows.Add(c.CategoryId, c.CategoryName));
        }

        internal bool Delete(int v)
        {
            return categoryRepository.Delete(v);
        }

        internal Category Update(TextBox txtCateID,TextBox txtTenCate)
        {
            Category category = new Category()
            {
                CategoryId = int.Parse(txtCateID.Text),
                CategoryName = txtTenCate.Text
            };
            return categoryRepository.Update(category);
        }
    }
}
