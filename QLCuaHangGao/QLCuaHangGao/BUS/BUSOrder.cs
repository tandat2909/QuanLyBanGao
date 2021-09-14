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
    public class BUSOrder
    {
        OrderRepository orderRepository = new OrderRepository();

        internal Order Add(DataGridView dgvOrder, User userCurrent)
        {

            List<OrderDetail> listOrderDeltail = new List<OrderDetail>();
            foreach(DataGridViewRow od in dgvOrder.Rows)
            {
                if(od.Cells[1].Value != null)
                {
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        Price = decimal.Parse(od.Cells["colPrice"].Value.ToString()),
                        ProductId = int.Parse(od.Cells["colMaSP"].Value.ToString()),
                        Quantity = decimal.Parse(od.Cells["colSLSP"].Value.ToString()),
                    };
                    if (orderDetail.Quantity == 0) throw new Exception("Yêu cầu nhập số lượng sản phẩm: " + od.Cells["colNameSP"].Value.ToString());
                    listOrderDeltail.Add(orderDetail);
                }
            }
            return orderRepository.Add(listOrderDeltail, userCurrent);
        }

        internal void GetAll(DataGridView dgvChiTietHoaDon,User userLogin)
        {
            orderRepository.GetAllOrderByEmployee(userLogin).ForEach(od =>
            {
                dgvChiTietHoaDon.Rows.Add(od.OrderId, od.User.GetFullName(), od.OrderDate,  od.total);
            });
        }

        internal bool Delete(int orderId)
        {
            return orderRepository.Delete(orderId);
        }
    }
}
