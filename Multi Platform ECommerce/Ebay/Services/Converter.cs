using ECommerce.Database.DTO;
using Multi_Platform_ECommerce.Ebay.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Services
{
    public static class Converter
    {
        public static List<EbayInv> ConvertListings(IEnumerable<Item> f)
        {
            List<EbayInv> rn = new();
            foreach (Item item in f)
            {
                var x = EbayUtil.IntoInv(item);
                rn.Add(x);
            }
            return rn;
        }


        public static List<EbayInv> ConvertListings(IEnumerable<ItemL> f)
        {
            List<EbayInv> rn = new();
            foreach (ItemL item in f)
            {
                var x = EbayUtil.LIntoInv(item);
                rn.Add(x);
            }
            return rn;
        }




        public static List<Order> OnlyNewOrders(List<Order> orderArray, List<EbayOrder> existingOrder)
        {
            List<Order> n = new();
            List<string> neworderids = new();
            for (int i = 0; i < orderArray.Count; i++)
            {
                bool isNew = true;
                Order e = orderArray[i];
                for (int j = 0; j < existingOrder.Count; j++)
                {
                    if (e.OrderID == existingOrder[j].OrderId)
                    {
                        isNew = false;
                        continue;
                    }
                }
                if (isNew)
                {
                    neworderids.Add(e.OrderID);
                    n.Add(e);
                }
            }
            return n;
        }









        public static void NewOrders(List<Order> orderArray, List<EbayOrder> existingOrder)
        //public async Task<List<EbayOrder>> NewOrders()
        {
            List<EbayOrder> newness = new();
            List<string> neworderids = new();
            for (int i = 0; i < orderArray.Count; i++)
            {
                bool isNew = true;
                Order e = orderArray[i];
                for (int j = 0; j < existingOrder.Count; j++)
                {
                    if (e.OrderID == existingOrder[j].OrderId)
                    {
                        isNew = false;
                        continue;
                    }
                }
                if (isNew)
                {
                    neworderids.Add(e.OrderID);
                    newness.Add(EbayUtil.Into(e));
                }
            }
            List<EbayOrderItem> ok = new();
            foreach (var item in orderArray)
            {
                var ze = EbayUtil.IntoItem(item);
                ok.AddRange(ze);
            }

            for (int i = 0; i < ok.Count; i++)
            {
                for (int j = 0; j < neworderids.Count; j++)
                {
                    if (ok[i].OrderId == neworderids[j])
                    {
                        break;
                    }
                }
            }
        }

        public static List<EbayOrderItem> NewOrderItem(List<Order> orderArray, List<EbayOrder> newOrder)
        {
            List<EbayOrderItem> ok = new();
            foreach (var item in orderArray)
            {
                bool accept = false;
                for (int j = 0; j < newOrder.Count; j++)
                {
                    if (item.OrderID == newOrder[j].OrderId)
                    {
                        accept = true;
                    }
                }
                if (accept)
                {
                    var ze = EbayUtil.IntoItem(item);
                    ok.AddRange(ze);
                }
            }

            //for (int i = 0; i < ok.Count; i++)
            //{
            //    bool letsgo = false;
            //    for (int j = 0; j < newOrder.Count; j++)
            //    {
            //        if (ok[i].OrderId == newOrder[j].OrderId)
            //        {
            //            letsgo = true;
            //            break;
            //        }
            //    }
            //    if (letsgo)
            //    {

            //    }
            //}
            return ok;
        }

    }
}
