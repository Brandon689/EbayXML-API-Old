using ECommerce.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.DIEDIEDIE
{
    public class Transformer
    {
        public readonly EbayOrder? Overview;
        public readonly EbayOrderStatus? Status;
        public readonly EbayAddress Address;
        public readonly IEnumerable<EbayOrderItem> Items;

        public Transformer()
        {
            Overview = new();
            Address = new();
            Items = new List<EbayOrderItem>();
        }

        public Transformer(EbayOrder a, EbayAddress b, IEnumerable<EbayOrderItem> c)
        {
            Overview = a;
            Address = b;
            Items = c;
        }

        public Transformer(EbayOrder a, EbayAddress b, IEnumerable<EbayOrderItem> c, EbayOrderStatus d)
        {
            Overview = a;
            Address = b;
            Items = c;
            Status = d;
        }

        public bool OrderStatusShipped()
        {
            return Status != null ? Status.IsShipped : false;
        }

        public bool OrderStatusCancelled()
        {
            return Status != null ? Status.IsCancelled : false;
        }
    }
}
