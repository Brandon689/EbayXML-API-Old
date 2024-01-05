using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Web.SendJson
{
    public class EditQuantity
    {
        public int stock_quantity { get; set; }

        public EditQuantity() {}

        public EditQuantity(int quantity)
        {
            stock_quantity = quantity;
        }
    }

    public class EditName
    {
        public string name { get; set; }

        public EditName() { }

        public EditName(string nm)
        {
            name = nm;
        }
    }
}
