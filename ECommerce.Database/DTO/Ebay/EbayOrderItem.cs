using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Database.DTO.Interface;

namespace ECommerce.Database.DTO
{
    public class EbayOrderItem : BaseOrderItem, IOrder<string>
    {
        
        public int QuantityPurchased { get; set; }
        public double Price { get; set; }
        public double AmountPaid { get; set; }
        public double OriginalPrice { get; set; }
        public double SellerDiscount { get; set; }
        public double OriginalShippingServiceCost { get; set; }
        public int Condition { get; set; }
        public string? SKU { get; set; }
        public string? ProductID { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        //public long CreatedDate { get; set; }
        public int InventoryId { get; set; }
    }
}
