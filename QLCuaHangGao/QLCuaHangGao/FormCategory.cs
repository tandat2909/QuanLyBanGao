using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangGao
{
    public partial class FormCategory : Form
    {
        BUS.BUSCategory busCategory = new BUS.BUSCategory();
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        void loadCategory()
        {
            dgvChiTietCate.Rows.Clear();
            busCategory.GetAll(dgvChiTietCate);
        }

        private void btnThemCate_Click(object sender, EventArgs e)
        {
            try
            {
                Category catgenew = busCategory.Add(txtTenCate);
                loadCategory();
                MessageBox.Show("Thêm danh mục " + catgenew.CategoryName + " thành công");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtCateID.Text))
            {
                MessageBox.Show("Chọn loại cần xóa");
                return;
            }
            if (busCategory.Delete(int.Parse(txtCateID.Text)))
            {
                loadCategory();
                MessageBox.Show("Xóa loại thành công");
            }

            else MessageBox.Show("Xóa loại thất bại");

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                busCategory.Update(txtCateID ,txtTenCate);
                loadCategory();
                MessageBox.Show("Sửa danh mục thành công");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvChiTietCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0 && e.RowIndex < dgvChiTietCate.Rows.Count - 1)
            {
                txtCateID.Text = dgvChiTietCate.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtTenCate.Text = dgvChiTietCate.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
        }

     
    }
}
