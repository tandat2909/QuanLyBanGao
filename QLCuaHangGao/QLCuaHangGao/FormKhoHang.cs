using QLCuaHangGao.BUS;
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
    public partial class FormKhoHang : Form
    {
        BUSWareHouse busWareHouse = new BUSWareHouse();
        BUSProduct busProduct = new BUSProduct();
        public FormKhoHang()
        {
            InitializeComponent();
        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            loadWareHouse();
            busProduct.GetAllProduct(cbxSP);
        }
        void loadWareHouse()
        {
            dgvChiTietKhoHang.Rows.Clear();
            busWareHouse.GetAll(dgvChiTietKhoHang);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                busWareHouse.Add(cbxSP, txtSoLuong);
                loadWareHouse();
                MessageBox.Show("Thêm vào kho thành công");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                busWareHouse.Delete(txtMaKho);
                loadWareHouse();
                MessageBox.Show("Xóa Thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            { 
                busWareHouse.Update(txtMaKho, txtSoLuong);
                loadWareHouse();
                MessageBox.Show("Cập nhật thành công");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void dgvChiTietKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.RowIndex < dgvChiTietKhoHang.Rows.Count - 1 || e.RowIndex <= dgvChiTietKhoHang.Rows.Count - 2))
            {
                txtMaKho.Text = dgvChiTietKhoHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbxSP.SelectedIndex = cbxSP.FindStringExact(dgvChiTietKhoHang.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtNV.Text = dgvChiTietKhoHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNgayNhap.Text = dgvChiTietKhoHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSoLuong.Text = dgvChiTietKhoHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTonKho.Text = dgvChiTietKhoHang.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
