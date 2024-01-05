using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Database.DTO.Interface;

namespace ECommerce.Database.DTO
{
    public class EbayOrder : BaseOrder, IOrder<string>
    {
        public string OrderId { get; set; }
    }
}
