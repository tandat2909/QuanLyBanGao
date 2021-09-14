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
    public partial class FormNhanVien : Form
    {
        BUSUser bUSUser = new BUSUser();
        
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            updateListUser();
            bUSUser.loadRole(cbxRole);
            if (isUserLoginRoleAdmin())
            {
                cbxRole.Enabled = true;
            }

        }
        private void updateListUser()
        {
            dgvChiTietNhanVien.Rows.Clear();
            bUSUser.getAllEmloyee(dgvChiTietNhanVien,Utils.userCurrent);
        }

        private void dgvChiTietNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.RowIndex < dgvChiTietNhanVien.Rows.Count - 1 || e.RowIndex <= dgvChiTietNhanVien.Rows.Count - 2))
            {
                txtMaNV.Text = dgvChiTietNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUserName.Text = dgvChiTietNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHo.Text = dgvChiTietNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenNV.Text = dgvChiTietNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNgayBD.Text = dgvChiTietNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbxRole.SelectedIndex = cbxRole.FindString(dgvChiTietNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }
        private bool isUserLoginRoleAdmin()
        {
            return Utils.userCurrent.RoleID == ((Role)cbxRole.Items[cbxRole.FindString("Admin")]).RoleId;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(isUserLoginRoleAdmin())
            {
               if(bUSUser.delete(int.Parse(txtMaNV.Text)))
                {
                    updateListUser();
                    MessageBox.Show("Xóa thông tin User"+txtHo.Text + " " +txtTenNV.Text+" thành công");

                }
                else
                {
                    MessageBox.Show("Xóa thông tin User" + txtHo.Text + " " + txtTenNV.Text + " không thành công");
                }
            }else

            MessageBox.Show("Bạn không có quyền thực hiện hành động này");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isUserLoginRoleAdmin())
            {
                FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
                formThemNhanVien.ShowDialog();
                updateListUser();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            try
            {

                User userUpdate = bUSUser.UpdatebyNV(txtMaNV, txtUserName, txtHo, txtTenNV, isUserLoginRoleAdmin(), cbxRole);

                if (userUpdate != null)
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    updateListUser();
                }else
                MessageBox.Show("Cập nhật thông tin thất bại");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            int emId=0;
            try
            {
                emId = int.Parse(txtMaNV.Text);
            }
            catch { }
            FormChangePassword formChangePassword = new FormChangePassword(emId);
            formChangePassword.ShowDialog();
        }
    }
}
