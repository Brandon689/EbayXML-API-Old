using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO.Interface
{
    public interface IOrderStatus<TID>
    {
        public TID OrderId { get; set; }
        public bool IsShipped { get; set; }
        public bool IsCancelled { get; set; }
    }
}
