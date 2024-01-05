using ECommerce.Database.DTO;
using Multi_Platform_ECommerce.Ebay.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Multi_Platform_ECommerce.Ebay.Services
{
    public class EbayGetService
    {
        //private readonly HttpClient cli;
        private readonly XMLGet _getAPI;

        public EbayGetService()
        {
            var s = new EbayRequest();
            var cli = new HttpClient();
            s.SetHeader(cli);

            _getAPI = new(s, cli);
        }

        public async Task Jas(string productid)
        {
            var stringxml = await _getAPI.GetItem(productid);

            //XmlSerializer serializer = new XmlSerializer(typeof(GetOrdersResponse));
            //using StringReader reader = new(stringxml);
            //GetOrdersResponse response = (GetOrdersResponse)serializer.Deserialize(reader);

        }
        public async Task<List<Order>> GetOrderResponSE()
        {
            var sm = await _getAPI.GetOrders(1);
            XmlSerializer serializer = new XmlSerializer(typeof(GetOrdersResponse));
            using StringReader reader = new(sm);
            GetOrdersResponse response = (GetOrdersResponse)serializer.Deserialize(reader);
            List<EbayOrder> newness = new();
            List<string> neworderids = new();
            return response.OrderArray.Order;
        }

        //EbayTransaction.DeleteTest();
        //var ex = EbayTransaction.GetOrder();
        //var result = test.OrderArray.Order.Where(p => !ex.Any(p2 => p2.OrderId == p.OrderID)).ToList();
        //if (result.Count == 0)
        //{
        //    return;
        //}
        //List<EbayOrderItem> et = new();
        //List<EbayBuyerAddress> eb = new();
        //List<EbayOrder> ob = new();
        //for (int i = 0; i < result.Count; i++)
        //{
        //    ob.Add(OrderConvert.Into(result[i]));
        //    eb.Add(AddressConvert.Into(result[i]));
        //    et.AddRange(OrderItemConvert.Into(result[i]));
        //}
        //EbayTransaction.SaveAddress(eb);
        //EbayTransaction.SaveOrders(ob);
        //EbayTransaction.SaveOrderItems(et);
    }
}
