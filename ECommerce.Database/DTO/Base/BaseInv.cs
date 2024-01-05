using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO
{
    public class BaseInv : DomainObject
    {
        public int InventoryId { get; set; }
        public string? EntityName { get; set; }
        public int Qty { get; set; }
        public string? SKU { get; set; }
        public bool IsNewItem { get; set; }
        public string? Condition { get; set; }
        public string? Location { get; set; }
    }
}
