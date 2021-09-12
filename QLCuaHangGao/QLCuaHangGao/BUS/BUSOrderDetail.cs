using QLCuaHangGao.DAO.Repository;
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangGao.BUS
{
   public class BUSOrderDetail
    {
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        internal List<OrderDetail> GetOrderDetailByOrder(int orderId) => orderDetailRepository.GetAllOrderDetailByOrder(orderId);
    }
}
