using ECommerce.Database.DTO;
using Multi_Platform_ECommerce.DIEDIEDIE;
using Multi_Platform_ECommerce.Ebay.Network;
using Multi_Platform_ECommerce.Ebay.Services;
using Multi_Platform_ECommerce.Ebay.XMLSerialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay
{
    public class TopLevel
    {
        private readonly XMLGet _getAPI;
        public readonly XMLPost _postAPI;
        private readonly XMLSerializer _serialize;

        public TopLevel(XMLGet getAPI, XMLPost post, XMLSerializer serialize)
        {
            _getAPI = getAPI;
            _serialize = serialize;
            _postAPI = post;
        }
        //public async Task PostQTY(long itemid, string sku)
        //{
        //    await _postAPI.ReviseItemQty(itemid, sku);
        //}
        public async Task PostSKU(long itemid, string sku)
        {
            await _postAPI.ReviseItemSKU(itemid, sku);
        }
        public async Task PostBrand(long itemid)
        {
            await _postAPI.ReviseItemBrand(itemid);
        }
        public async Task PostQtySKU(int qty, string sku, long itemid)
        {
            await _postAPI.ReviseItemQtySKU(qty, sku, itemid);
        }
        public async Task PostQty(int qty, long itemid)
        {
            await _postAPI.ReviseItemQty(itemid, qty);
        }
        public async Task<List<EbayInv>> GetItemAsync(string itemid)
        {
            string item = await _getAPI.GetItem(itemid);
            Console.WriteLine(item);
            File.WriteAllText(@"C:\planB\ok.txt", item);
            GetItemResponse xmlObject = _serialize.Item(item);
            Console.WriteLine(xmlObject.Item.Variations.Variation[0].SKU);
            var vars = EbayUtil.SIntoInvWithVar(xmlObject.Item);
            return vars;
        }

        public async Task<List<Transformer>> FormatNewOrders(int dayspast, ECommerce.Database.Query.SqlEbayProvider _sql)
        {
            var sm = await _getAPI.GetOrders(1, -dayspast);
            GetOrdersResponse xmlObject = _serialize.Order(sm);
            var newness = Converter.OnlyNewOrders(xmlObject.OrderArray.Order, _sql.GetAllOrder());
            List<Transformer> f = new();
            foreach (var item in newness)
            {
                var a = TInterface.TOrder(item);
                f.Add(a);
            }
            return f;
        }

        public async Task<List<EbayInv>> GetAllEbayInv()
        {
            int page = 1;
            string mysellingPage = await _getAPI.GetMySelling(page);
            GetMyeBaySellingResponse xmlObject = _serialize.SellerList(mysellingPage);
            List<EbayInv> invDTOList = Converter.ConvertListings(xmlObject.ActiveList.ItemArray.Item);

            int totalPages = int.Parse(xmlObject.ActiveList.PaginationResult.TotalNumberOfPages);
            Console.WriteLine(totalPages);
            while (page < totalPages)
            {
                ++page;
                mysellingPage = await _getAPI.GetMySelling(page);
                xmlObject = _serialize.SellerList(mysellingPage);
                invDTOList.AddRange(Converter.ConvertListings(xmlObject.ActiveList.ItemArray.Item));
            }
            foreach (var item in invDTOList)
            {
                if (item.SKU is not null)
                {
                    item.IsVariationListing = EbayUtil.IsVariationFromSKU(item.SKU);
                }
            }
            return invDTOList;
        }
    }
}
