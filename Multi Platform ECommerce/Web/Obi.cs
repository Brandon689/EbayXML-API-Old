using Multi_Platform_ECommerce.Web.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Multi_Platform_ECommerce.Web
{
    public static class Obi
    {
        public static AllProduct One(string json)
        {
            return JsonSerializer.Deserialize<AllProduct>(json);
        }

        public static CreateProduct Create(string json)
        {
            return JsonSerializer.Deserialize<CreateProduct>(json);
        }

        public static UpdateProduct Update(string json)
        {
            return JsonSerializer.Deserialize<UpdateProduct>(json);
        }

        public static List<AllProduct> All(string json)
        {
            return JsonSerializer.Deserialize<List<AllProduct>>(json);
        }
    }
}
