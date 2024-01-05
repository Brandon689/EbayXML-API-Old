using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Database.DTO.Interface;

namespace Multi_Platform_ECommerce
{
    public class ID
    {


        public bool ExistsInCollection<TID>(IEnumerable<IOrder<string>> collection, string OrderID)
        {
            foreach (IOrder<string> item in collection)
            {
                if (item.OrderId == OrderID)
                    return true;
            }
            return false;
        }

        public bool ExistsInCollection<TID>(IEnumerable<IOrder<long>> collection, long OrderID)
        {
            foreach (IOrder<long> item in collection)
            {
                if (item.OrderId == OrderID)
                    return true;
            }
            return false;
        }

        public bool Matches<TID>(IOrder<string> a, IOrder<string> b)
        {
            return a == b;
        }

        public bool Matches<TID>(IOrder<long> a, IOrder<long> b)
        {
            return a == b;
        }



    }
}
