
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHangGao.DAO.Repository
{
    public class OrderDetailRepository:ContextRepository
    {
        public OrderDetail GetOrderDetail(int orderDetailId,int productId) { throw new Exception("chưa làm"); }
        
        public List<OrderDetail> GetAllOrderDetailByOrder(int orderId){
            /*
             lấy tất cả chi tiết hóa đơn theo hóa đơn
            */
            return GetContext().OrderDetails.Where(od => od.OrderId == orderId).ToList();
        }
        /*public List<OrderDetail> GetAll()
        {
           
             * Chỉ admin mới được phép xem tất cả hóa đơn
             kiểm tra admin có role admin khong nếu không văng lỗi khong có quyền hoặc trả về mảng rổng nên văng lỗi không có quyền

             
            throw new Exception("Chưa làm");
        }*/
       
        public OrderDetail Add(OrderDetail orderDetails)
        {
            ManageContext context = GetContext();
            OrderDetail od =  context.OrderDetails.Add(orderDetails);
            context.SaveChanges();
            return od;
        }

        public List<OrderDetail> AddRange(List<OrderDetail> orderDetails)
        {
            ManageContext context = GetContext();
            List<OrderDetail> ors =  context.OrderDetails.AddRange(orderDetails).ToList();
            context.SaveChanges();
            return ors;

        }
     
        public OrderDetail Update(OrderDetail orderDetail)
        {
            if (orderDetail.Price <= 0) throw new ValidateException("Giá Không hợp lệ");
            if (orderDetail.Quantity <= 0) throw new ValidateException("Số lượng không hợp lệ");
            ManageContext context = GetContext();
            OrderDetail od = context.OrderDetails.First(o => o.OrderId == orderDetail.OrderId && o.ProductId == o.ProductId);
            od.Price = orderDetail.Price;
            od.Quantity = orderDetail.Quantity;
            context.SaveChanges();
            return od;

        }
        public bool Delete(OrderDetail order)
        {
            return Delete(order.OrderId,order.ProductId);
        }

        public bool Delete(int orderId, int product)
        {
            try
            {
                ManageContext context = GetContext();
                OrderDetail od = context.OrderDetails.First(o => o.OrderId == orderId && o.ProductId == product);
                context.OrderDetails.Remove(od);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
