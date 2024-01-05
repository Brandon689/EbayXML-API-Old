using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO
{
    public class BaseOrder : DomainObject
    {
        public bool IsPaid { get; set; }
        public bool IsShipped { get; set; }
        public decimal TotalPaid { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
