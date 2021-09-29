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
        CategoryRepository dao_category = new CategoryRepository();

        internal void GetAll(ComboBox cbxCate)
        {
           
            cbxCate.DataSource = dao_category.GetAll(); 
            cbxCate.DisplayMember = "CategoryName";
            

        }
        internal Category Add(TextBox txtCateName)
        {
            Category category = new Category()
            {
                CategoryName = txtCateName.Text
            };
           return dao_category.Add(category);

        }

        internal void GetAll(DataGridView dgvChiTietCate)
        {
            dao_category.GetAll().ForEach(c => dgvChiTietCate.Rows.Add(c.CategoryId, c.CategoryName));
        }

        internal bool Delete(int idcategory)
        {
            return dao_category.Delete(idcategory);
        }

        internal Category Update(TextBox txtCateID,TextBox txtTenCate)
        {
            Category category = new Category()
            {
                CategoryId = int.Parse(txtCateID.Text),
                CategoryName = txtTenCate.Text
            };
            return dao_category.Update(category);
        }
    }
}
