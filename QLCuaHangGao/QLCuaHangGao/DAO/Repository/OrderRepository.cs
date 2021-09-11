
using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHangGao.DAO.Repository
{
    public class OrderRepository:ContextRepository
    {
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public Order GetOrder(int orderId) { throw new Exception("chưa làm"); }
        public List<Order> GetAllOrderByEmployee(User employee)
        {
            //selete * from orders where employeeID = 2
            //ApplicationContext db = new ApplicationContext();
            ManageContext db = new ManageContext();
            List<Order> dv = db.Orders.Where(o => o.UserId == employee.UserId).ToList();
            return dv;
        }
        public List<Order> GetAll(User admin)
        {
            /*
             * Chỉ admin mới được phép xem tất cả hóa đơn
             kiểm tra admin có role admin khong nếu không văng lỗi khong có quyền hoặc trả về mảng rổng nên văng lỗi không có quyền
             */
            if(admin.Role.Name != "Admin")
            {
                throw new Exception("Bạn không có quyền truy cập");
            }
            return GetContext().Orders.Where(o => o.is_active == true).ToList();

        }
        public List<Order> GetOrdersByDate(User employee, DateTime start, DateTime end)
        {
            /* chức năng tìm kiếm hóa đơn theo ngày của user nào đó */
            return GetContext().Orders.Where(o => o.is_active == true 
                                                && o.UserId == employee.UserId 
                                                && o.OrderDate >= start 
                                                && o.OrderDate <= end).ToList();
        }
        public Order Add(List<OrderDetail> orderDetails, User user)
        {
            return Add(orderDetails, user.UserId);
        }

        public Order Add(List<OrderDetail> orderDetails, int userId)
        {

            ManageContext context = GetContext();
            Order ordernew = new Order()
            {
                UserId = userId
            };
            Order instance_order = context.Orders.Add(ordernew);

            foreach(OrderDetail od  in orderDetails)
            {
                od.OrderId = instance_order.OrderId;
                orderDetailRepository.Add(od);
            }
            context.SaveChanges();
            return instance_order;
        }
/*        public Order Update(Order order)
        {
            throw new Exception("Chưa làm");
        }*/
        public bool Delete(Order order)
        {
            return Delete(order.OrderId);
        }

        public bool Delete(int orderId)
        {
            try
            {
                ManageContext context = GetContext();
                Order current = context.Orders.Where(o => o.OrderId == orderId).First();
                current.is_active = false;
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
