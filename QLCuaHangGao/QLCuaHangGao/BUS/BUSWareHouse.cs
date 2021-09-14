using QLCuaHangGao.DAO.Repository;
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangGao.BUS
{
    public class BUSWareHouse
    {
        WareHouseRepository wareHouseRepository = new WareHouseRepository();
        UserRepository userRepository = new UserRepository();
        internal void GetAll(DataGridView dgvChiTietKhoHang)
        {
            wareHouseRepository.GetAll().ForEach(i => 
            dgvChiTietKhoHang.Rows.Add(i.WareHouseId,i.Product.ProductName,i.User.GetFullName(),i.DateAdd,i.AmountAdd,i.Inventory));
        }

        internal WareHouse Add(ComboBox cbxSP, TextBox txtSoLuong)
        {
            if (txtSoLuong.Text.Trim().Length <= 0) throw new Exception("Yêu cầu nhập số lượng");
            WareHouse wareHouse = new WareHouse()
            {
                ProductId = ((Product)cbxSP.SelectedItem).ProductId,
                UserId = Utils.userCurrent.UserId,
                AmountAdd = decimal.Parse(txtSoLuong.Text)
            };
           return wareHouseRepository.Add(wareHouse);
           
        }

        internal void Delete(TextBox txtMaKho)
        {
            wareHouseRepository.DeleteWareHouse(int.Parse(txtMaKho.Text),Utils.userCurrent) ;
        }

        internal WareHouse Update(TextBox txtMaKho, TextBox txtSoLuong)
        {
            WareHouse a = new WareHouse()
            {
                WareHouseId = int.Parse(txtMaKho.Text),
                AmountAdd = decimal.Parse(txtSoLuong.Text)
            };
           return wareHouseRepository.UpdateAmountAdd(a,Utils.userCurrent);
        }
    }
}
