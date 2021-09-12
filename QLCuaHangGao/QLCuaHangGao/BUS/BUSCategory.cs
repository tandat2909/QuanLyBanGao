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
    }
}
