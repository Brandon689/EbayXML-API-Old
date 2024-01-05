using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public static class XMLPrepare
    {
        public static string Value(string xmlResponse)
        {
            xmlResponse = xmlResponse.Replace(" xmlns=\"urn:ebay:apis:eBLBaseComponents\"", "");
            return xmlResponse;
        }
    }
}
