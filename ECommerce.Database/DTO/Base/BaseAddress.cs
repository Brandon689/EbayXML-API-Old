using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO
{
    public class BaseAddress : DomainObject
    {
        public string? Name { get; set; }
        public int Country { get; set; }
        public string? StateOrProvince { get; set; }
        public string? PostalCode { get; set; }
    }
}
