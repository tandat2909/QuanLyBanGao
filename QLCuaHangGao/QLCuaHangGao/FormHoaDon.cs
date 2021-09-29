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
    public partial class FormHoaDon : Form
    {
        BUSOrder busOrder = new BUSOrder();
        public FormHoaDon()
        {
            InitializeComponent();
            
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            loadOrder();
        }
        void loadOrder()
        {
            dgvChiTietHoaDon.Rows.Clear();
            busOrder.GetAll(dgvChiTietHoaDon,Utils.userCurrent);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgvChiTietHoaDon.SelectedCells)
            {
                if (c.RowIndex >= dgvChiTietHoaDon.Rows.Count - 1)
                {
                    MessageBox.Show("Chọn hóa đơn cần xóa");
                    break;
                }
                if (c.Selected)
                {
                    if (busOrder.Delete(int.Parse(dgvChiTietHoaDon.Rows[c.RowIndex].Cells[0].Value.ToString())))
                    {
                        dgvChiTietHoaDon.Rows.RemoveAt(c.RowIndex);
                        loadOrder();
                        MessageBox.Show("Xóa hóa đơn thành công");
                    }
                    else MessageBox.Show("Xóa hóa đơn thất bại");
                    break;

                }

            }
        }



        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && e.RowIndex < dgvChiTietHoaDon.Rows.Count - 1)
            {
                txtHD.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNhanVien.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNgayBan.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = dgvChiTietHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
               
           
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgvChiTietHoaDon.SelectedCells)
            {
                if (c.RowIndex >= dgvChiTietHoaDon.Rows.Count - 1)
                {
                    MessageBox.Show("Chọn hóa đơn cần xem");
                    break;
                }
                if (c.Selected)
                {
                    FormChiTietHoaDon formChiTietHoaDon = new FormChiTietHoaDon(int.Parse(dgvChiTietHoaDon.Rows[c.RowIndex].Cells[0].Value.ToString()));
                    formChiTietHoaDon.Show();
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           foreach(DataGridViewRow r in dgvChiTietHoaDon.Rows)
            {
                if (r.Cells[0].Value != null && r.Cells[0].Value.ToString() == txtHD.Text)
                {

                    txtNhanVien.Text = r.Cells[1].Value.ToString();
                    txtNgayBan.Text = r.Cells[2].Value.ToString();
                    txtDonGia.Text = r.Cells[3].Value.ToString();
                    return;
                }

            }
            MessageBox.Show("Không tìm thấy hóa đơn " + txtHD.Text +". VUi lòng nhập hóa đơn khác");
        }
    }
}
