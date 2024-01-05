using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO.Entity
{
    public class Entity
    {
        public string? ItemId { get; set; }
        public int ColorId { get; set; }
        public string? ItemType { get; set; }
        public string? Brand { get; set; }
        public int YearReleased { get; set; }
        public int Category { get; set; }
        public double Weight { get; set; }
    }
}
