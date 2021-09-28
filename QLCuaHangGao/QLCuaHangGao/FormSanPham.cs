using QLCuaHangGao.BUS;
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
    public partial class FormSanPham : Form
    {
        BUSProduct busProduct = new BUSProduct();
        BUSCategory busCategory = new BUSCategory();
        
        public FormSanPham()
        {
            InitializeComponent();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            busCategory.GetAll(cbxCate);
            loadProductAll();
        }
        private void loadProductAll()
        {
            dgvChiTietSanPham.Rows.Clear(); // lênh xoa các phần tử trong datagrview
            busProduct.GetAllProduct(dgvChiTietSanPham);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                busProduct.Add(txtTenSP, cbxCate, txtDonGia, txtGhiChu);  
                loadProductAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            string masp = txtMaSP.Text;
            if (masp.Length == 0)
            {
                MessageBox.Show("Chọn sản phẩm cần xóa");
                return;
            }
            if (busProduct.Delete(int.Parse(masp)))
            {
                loadProductAll();
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            else MessageBox.Show("Xóa sản phẩm thất bại");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = busProduct.Update(txtMaSP,txtTenSP, cbxCate, txtDonGia, txtGhiChu);
                loadProductAll();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dgvChiTietSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.RowIndex < dgvChiTietSanPham.Rows.Count - 1 || e.RowIndex <= dgvChiTietSanPham.Rows.Count - 2))
            {
                txtMaSP.Text = dgvChiTietSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvChiTietSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
               
                txtDonGia.Text = dgvChiTietSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGhiChu.Text = dgvChiTietSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();

                cbxCate.SelectedIndex = cbxCate.FindString(dgvChiTietSanPham.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.ShowDialog();
            busCategory.GetAll(cbxCate);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int masp = int.Parse(txtMaSP.Text);
                if (masp >= 0)
                {
                    Product result = busProduct.GetProductById(txtMaSP);
                    txtMaSP.Text = result.ProductId.ToString();
                    txtTenSP.Text = result.ProductName;

                    txtDonGia.Text = result.Price.ToString();
                    txtGhiChu.Text = result.Description;
                    cbxCate.SelectedIndex = cbxCate.FindString(result.Category.CategoryName);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ");
                    txtMaSP.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
            }
        }
    }
}

