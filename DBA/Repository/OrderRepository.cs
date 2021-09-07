using System;
using System.Collections.Generic;
using System.Text;

namespace DBA.Repository
{
    public class OrderRepository:ContextRepository
    {
        public Order GetOrder(int orderId) { throw new Exception("chưa làm"); }
        public List<Order> GetAllOrderByEmployee(User employee)
        {
            /*
              kiểm tra user đó có phải là quyền employee (Role)
            */
            throw new Exception("Chưa làm");
        }
        public List<Order> GetAll(User admin)
        {
            /*
             * Chỉ admin mới được phép xem tất cả hóa đơn
             kiểm tra admin có role admin khong nếu không văng lỗi khong có quyền hoặc trả về mảng rổng nên văng lỗi không có quyền

             */
            throw new Exception("Chưa làm");
        }
        public List<Order> GetOrdersByDate(User employee, DateTime start, DateTime end)
        {
            /* chức năng tìm kiếm hóa đơn theo ngày của user nào đó */
            throw new Exception("chưa làm");
        }
        public Order Add(List<OrderDetail> orderDetails, User user)
        {
            return Add(orderDetails, user.UserId);
        }
        public Order Add(List<OrderDetail> orderDetails, int userId)
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
