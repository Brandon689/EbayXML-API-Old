using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO
{
    public class EbayInv : BaseInv
    {
        public int VariationId { get; set; }
        public long ProductId { get; set; }
        public decimal SellingPrice { get; set; }
        public int QuantitySold { get; set; }
        public string? ListingTitle { get; set; }

        public string? VariationName { get; set; }
        public string? VariationValue { get; set; }

        public bool IsVariationListing { get; set; }
    }
}
