using ECommerce.Database.DTO;
using Multi_Platform_ECommerce.Ebay.Network;
using Multi_Platform_ECommerce.Ebay.Network.XMLResponse.Xml2CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Multi_Platform_ECommerce.Ebay.XMLSerialize
{
    public class XMLSerializer
    {
        public GetOrdersResponse Order(string getOrderXML)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GetOrdersResponse));
            using StringReader reader = new(getOrderXML);
            GetOrdersResponse response = (GetOrdersResponse)serializer.Deserialize(reader);
            return response;
        }
        public AddFixedPriceItemResponse additem(string xml)
        {
            XmlSerializer serializer = new(typeof(AddFixedPriceItemResponse), new XmlRootAttribute("AddFixedPriceItemResponse"));
            using StringReader reader = new(xml);
            AddFixedPriceItemResponse response = (AddFixedPriceItemResponse)serializer.Deserialize(reader);
            return response;
        }
        public GetItemResponse Item(string getItemXML)
        {
            XmlSerializer serializer = new(typeof(GetItemResponse), new XmlRootAttribute("GetItemResponse"));
            using StringReader reader = new(getItemXML);
            GetItemResponse response = (GetItemResponse)serializer.Deserialize(reader);
            return response;
        }

        public GetMyeBaySellingResponse SellerList(string getSellerListXML)
        {
            XmlSerializer serializer = new(typeof(GetMyeBaySellingResponse), new XmlRootAttribute("GetMyeBaySellingResponse"));
            using StringReader reader = new(getSellerListXML);
            GetMyeBaySellingResponse response = (GetMyeBaySellingResponse)serializer.Deserialize(reader);
            return response;
        }


        public GetSellerListResponse SellerList2(string getSellerListXML)
        {
            XmlSerializer serializer = new(typeof(GetSellerListResponse), new XmlRootAttribute("GetMyeBaySellingResponse"));
            using StringReader reader = new(getSellerListXML);
            GetSellerListResponse response = (GetSellerListResponse)serializer.Deserialize(reader);
            return response;
        }
    }
}
