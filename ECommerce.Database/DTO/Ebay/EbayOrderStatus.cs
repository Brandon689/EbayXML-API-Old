using ECommerce.Database.DTO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO
{
    public class EbayOrderStatus : DomainObject, IOrderStatus<string>
    {
        public EbayOrderStatus(string orderId, bool isShipped, bool isCancelled)
        {
            OrderId = orderId;
            IsShipped = isShipped;
            IsCancelled = isCancelled;
        }
        public EbayOrderStatus() {}
        public string OrderId { get; set; }
        public bool IsShipped { get; set; }
        public bool IsCancelled { get; set; }
    }
}
