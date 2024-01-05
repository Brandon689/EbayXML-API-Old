using ECommerce.Database.DTO;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.Query
{
    public class SqlEbayProvider : SqlBase
    {
        public SqlEbayProvider(SQLiteConnection db) : base(db)
        {
        }

        public List<EbayInv> GetAllInv()
        {
            return db.Table<EbayInv>().ToList();
        }
        public EbayInv GetInv(int inventoryId)
        {
            return db.Table<EbayInv>().Where(x => x.InventoryId == inventoryId).FirstOrDefault();
        }
  
        public void AddInv(EbayInv c)
        {
            db.Insert(c);
        }
        public void UpdateListInv(IEnumerable<EbayInv> c)
        {
            db.UpdateAll(c);
        }
        public void AddListInv(IEnumerable<EbayInv> c)
        {
            db.InsertAll(c);
        }
        public void AddListOrderStatus(IEnumerable<EbayOrderStatus> c)
        {
            db.InsertAll(c);
        }
        public void Create()
        {
            db.CreateTable<EbayInv>();
            db.CreateTable<EbayOrder>();
            db.CreateTable<EbayOrderItem>();
            //db.CreateTable<EbayAddress>();
            db.CreateTable<EbayOrderStatus>();
        }
        // order
        public List<EbayOrder> GetAllOrder()
        {
            return db.Table<EbayOrder>().ToList();
        }
        public List<EbayAddress> GetAllAddress()
        {
            return db.Table<EbayAddress>().ToList();
        }
        public EbayOrder GetOrder(string orderId)
        {
            return db.Table<EbayOrder>().Where(x => x.OrderId == orderId).FirstOrDefault();
        }
        public void AddOrder(EbayOrder c)
        {
            db.Insert(c);
        }
        public void AddOrderStatus(EbayOrderStatus c)
        {
            db.Insert(c);
        }
        public void UpdateOrderStatus(EbayOrderStatus c)
        {
            db.Update(c);
        }
        public EbayOrderStatus GetOrderStatus(string orderId)
        {
            return db.Table<EbayOrderStatus>().Where(x => x.OrderId == orderId).FirstOrDefault();
        }
        public List<EbayOrderStatus> GetAllOrderStatus()
        {
            return db.Table<EbayOrderStatus>().ToList();
        }
        public void UpdateListOrder(IEnumerable<EbayOrder> c)
        {
            db.UpdateAll(c);
        }
        public void AddListOrder(IEnumerable<EbayOrder> c)
        {
            db.InsertAll(c);
        }
        public void AddListOrderItem(IEnumerable<EbayOrderItem> c)
        {
            db.InsertAll(c);
        }
        public void AddListOrderAddress(IEnumerable<EbayAddress> c)
        {
            db.InsertAll(c);
        }
        public void AddOrderItem(EbayOrderItem c)
        {
            db.Insert(c);
        }
        public void clear()
        {
            db.DeleteAll<EbayOrder>();
        }
        public void ClearEbayInv()
        {
            db.DeleteAll<EbayInv>();
        }
        public List<EbayOrderItem> GetAllOrderItem()
        {
            return db.Table<EbayOrderItem>().ToList();
        }
        public void clearItem()
        {
            db.DeleteAll<EbayOrderItem>();
        }
    }
}
