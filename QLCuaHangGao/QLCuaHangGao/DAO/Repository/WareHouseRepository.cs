using QLCuaHangGao.DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangGao.DAO.Repository
{
    public class WareHouseRepository:ContextRepository
    {
       
        RoleRepository roleRepository = new RoleRepository();
        ProductRepository productRepository = new ProductRepository();
        public WareHouse Add(WareHouse wareHouse)
        {

            if (wareHouse.ProductId == 0) throw new ValidateException("Vui lòng chọn sản phẩm cần thêm");
            if (wareHouse.AmountAdd <= 0) throw new ValidateException("Vui lòng nhập số lượng ");
            wareHouse.Inventory = wareHouse.AmountAdd;
            ManageContext db = GetContext();
            WareHouse instance =  db.WareHouses.Add(wareHouse);
            db.SaveChanges();
            return instance;
        }

        public WareHouse GetWareHouse(int wareHouse)
        {
            return GetContext().WareHouses.FirstOrDefault(wh=>wh.WareHouseId == wareHouse);
        }

        public List<WareHouse> GetWareHouseByProduct(int ProdcuctId)
        {
            return GetContext().WareHouses.Where(wh => wh.ProductId == ProdcuctId).ToList();
        }
        public List<WareHouse> GetAll()
        {
            return GetContext().WareHouses.ToList();
        }
        public bool DeleteWareHouse(WareHouse wareHouse, User userCurrent) 
        {
            return DeleteWareHouse(wareHouse.WareHouseId, userCurrent);
        }

        public bool DeleteWareHouse(int wareHouseId, User admin)
        {
            try
            {
                /* if (admin.RoleID != roleRepository.getRolebyName("Admin").RoleId)
                     throw new ValidateException("Bạn không có quyền xóa. Liên hệ với Chủ cửa hàng");*/
                ManageContext db = GetContext();
                db.WareHouses.Remove(db.WareHouses.Find(wareHouseId));
                db.SaveChanges();
                return true;
            }
            catch
            {
                throw new Exception("Xóa kho sản phẩm thất bại");
            }
        }

        public WareHouse UpdateAmountAdd(WareHouse wareHouse, User admin)
        {
            
            if (admin.RoleID != roleRepository.getRolebyName("Admin").RoleId) 
                throw new ValidateException("Bạn không có quyền cập nhật số lượng kho. Liên hệ với Chủ cửa hàng");
            if (wareHouse.AmountAdd <= 0) throw new ValidateException("Vui lòng nhập số lượng ");
            ManageContext db = GetContext();
            WareHouse current = db.WareHouses.FirstOrDefault(wh => wh.WareHouseId == wareHouse.WareHouseId);
            if (current == null) throw new ValidateException("Mã Kho không hợp lệ vui lòng chọn lại");
            
            current.Inventory = current.Inventory + (wareHouse.AmountAdd - current.AmountAdd);
            if (current.Inventory < 0) current.Inventory = 0;

            current.AmountAdd = wareHouse.AmountAdd;
            db.SaveChanges();
            return current;
        }
        
        public WareHouse UpdateInventory(WareHouse wareHouse)
        {
            ManageContext db = GetContext();
            WareHouse s=db.WareHouses.Find(wareHouse.WareHouseId);
            s.Inventory = wareHouse.Inventory;
            db.SaveChanges();
            return s;
        }
        public (decimal,List<WareHouse>) GetInventorybyProduct(int ProductId)
        {
            decimal sum = 0;
            List<WareHouse> wh = GetWareHouseByProduct(ProductId);
            wh.ForEach(i => sum += i.Inventory);
            ;
            return (sum, wh.OrderBy(o => o.DateAdd).ToList());
        }
        
        public bool UpdateWareHouseForPayOrder(int ProductId,decimal quantity)
        {

            decimal sum = 0;
            List<WareHouse> whs;
            (sum , whs) = GetInventorybyProduct(ProductId);
            Product p = productRepository.GetProduct(ProductId);
            if (sum == 0 ) throw new Exception(p.ProductName + " trong kho đã hết hàng");
            if (quantity > sum) throw new Exception(p.ProductName + " trong kho không còn đủ " + quantity + "Kg. Trong kho còn " + sum + "Kg. ");
            foreach(WareHouse i in whs)
            {
                decimal rs = i.Inventory - quantity;
                if(rs >= 0)
                {
                    //trường hợp sl sản phẩm còn nhiều hơn số yêu cầu mua
                    i.Inventory = rs;
                    UpdateInventory(i);
                    return true;
                }
                if(rs < 0)
                {
                    quantity -= -rs; //lây sl còn lại sau khi cập nhật cái sp đã hết để cập nhật sp sau
                    i.Inventory = 0;
                    UpdateInventory(i);

                }
            }
            return false;
           
        }

    }
}
