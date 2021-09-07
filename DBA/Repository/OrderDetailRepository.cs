using System;
using System.Collections.Generic;
using System.Text;

namespace DBA.Repository
{
    public class OrderDetailRepository:ContextRepository
    {
        public OrderDetail GetOrderDetail(int orderDetailId) { throw new Exception("chưa làm"); }
        public List<OrderDetail> GetAllOrderDetailByOrder(Order order){
            /*
             lấy tất cả chi tiết hóa đơn theo hóa đơn
            */
            throw new  Exception("Chưa làm");
        }
        /*public List<OrderDetail> GetAll()
        {
           
             * Chỉ admin mới được phép xem tất cả hóa đơn
             kiểm tra admin có role admin khong nếu không văng lỗi khong có quyền hoặc trả về mảng rổng nên văng lỗi không có quyền

             
            throw new Exception("Chưa làm");
        }*/
       
        public Order Add(OrderDetail orderDetails)
        {
           throw new Exception("Chưa làm");
        }
     
        public Order Update(Order order)
        {
            throw new Exception("Chưa làm");
        }
        public bool Delete(Order order)
        {
            return Delete(order.OrderId);
        }

        public bool Delete(int orderId)
        {
            throw new Exception("Chưa làm");
        }
    }
}
