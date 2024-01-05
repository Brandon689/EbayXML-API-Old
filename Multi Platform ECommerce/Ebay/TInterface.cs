using ECommerce.Database.DTO;
using Multi_Platform_ECommerce.DIEDIEDIE;
using Multi_Platform_ECommerce.Ebay.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay
{
    public static class TInterface
    {
        public static Transformer TOrder(Order o)
        {
            EbayOrder a = new();
            EbayAddress b = new();
            List<EbayOrderItem> c = new();

            a = EbayUtil.Into(o);
            b = EbayUtil.IntoAddress(o);
            c = EbayUtil.IntoItem(o);

            return new Transformer(a, b, c);
        }

        public static List<Transformer> TLOrder(IEnumerable<EbayOrder>a, IEnumerable<EbayAddress>b, IEnumerable<EbayOrderItem>c)
        {
            List<Transformer> list = new();
            foreach (EbayOrder order in a)
            {
                var z = b.FirstOrDefault(x => x.OrderId == order.OrderId);
                var y = c.Where(x => x.OrderId == order.OrderId);
                list.Add(new Transformer(order, z, y));
            }
            return list;
        }

        public static List<Transformer> TLSOrder(IEnumerable<EbayOrder> a, IEnumerable<EbayAddress> b, IEnumerable<EbayOrderItem> c,
            IEnumerable<EbayOrderStatus> d)
        {
            List<Transformer> list = new();
            foreach (EbayOrder order in a)
            {
                var z = b.FirstOrDefault(x => x.OrderId == order.OrderId);
                var y = c.Where(x => x.OrderId == order.OrderId);
                var x = d.FirstOrDefault(x => x.OrderId == order.OrderId);
                list.Add(new Transformer(order, z, y, x));
            }
            return list;
        }
    }
}
