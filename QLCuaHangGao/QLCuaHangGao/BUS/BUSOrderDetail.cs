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
   public class BUSOrderDetail
    {
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        
        internal List<OrderDetail> GetOrderDetailByOrder(int orderId) => orderDetailRepository.GetAllOrderDetailByOrder(orderId);

        internal void GetOrderDetailByOrder(int orderId, DataGridView dgvCTHD)
        {
            orderDetailRepository.GetAllOrderDetailByOrder(orderId)
                .ForEach(o => dgvCTHD.Rows.Add(o.OrderId,o.Product.ProductName,o.Price,o.Quantity));

        }
    }
}
