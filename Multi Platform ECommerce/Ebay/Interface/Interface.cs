using ECommerce.Database.DTO;
using ECommerce.Database.Query;
using Multi_Platform_ECommerce.DIEDIEDIE;
using Multi_Platform_ECommerce.Ebay.Network;
using Multi_Platform_ECommerce.Ebay.XMLSerialize;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay
{
    public class APIHelper
    {
        private EbayRequest _req;
        private SqlEbayProvider _sql;
        public TopLevel _top;

        public APIHelper(EbayRequest req, SqlEbayProvider sql, TopLevel top)
        {
            _req = req;
            _sql = sql;
            _top = top;
        }

        public APIHelper(SQLiteConnection s)
        {
            _req = new EbayRequest();
            var client = new HttpClient();
            _req.SetHeader(client);
            _sql = new SqlEbayProvider(s);
            var e = new EbayRequest();
            _top = new TopLevel(new XMLGet(e, client), new XMLPost(e, client),
                new XMLSerializer());
        }

        public async Task PostSKU(long itemid, string s)
        {
            await _top.PostSKU(itemid, s);
        }

        public async Task Brand(long itemid)
        {
            await _top.PostBrand(itemid);
        }

        public async Task<List<EbayInv>> GetAllListing()
        {
            List<EbayInv> list = await _top.GetAllEbayInv();
            List<EbayInv> variations = new();
            var varlist = list.Where(x => x.IsVariationListing);
            foreach (var item in varlist)
            {
                var l = await _top.GetItemAsync(item.ProductId.ToString());
                variations.AddRange(l);
            }
            var liss = list.Where(x => x.IsVariationListing == false).ToList();
            liss.AddRange(variations);
            return liss;
        }

        public async Task GetAllListingAndSave()
        {
            List<EbayInv> list = await _top.GetAllEbayInv();
            List<EbayInv> variations = new();

            var varlist = list.Where(x => x.IsVariationListing);

            foreach (var item in varlist)
            {
                var l = await _top.GetItemAsync(item.ProductId.ToString());
                variations.AddRange(l);
            }
            _sql.ClearEbayInv();
            _sql.AddListInv(list.Where(x => x.IsVariationListing == false));
            _sql.AddListInv(variations);
        }

        public async Task GetAllOrderSave(int dayback)
        {
            List<Transformer> f = await _top.FormatNewOrders(dayback, _sql);
            _sql.AddListOrder(f.Select(x => x.Overview));
            _sql.AddListOrderAddress(f.Select(x => x.Address));

            List<EbayOrderStatus> eos = f.Select(x => x.Overview).Select(x => new EbayOrderStatus(x.OrderId, false, false)).ToList();
            _sql.AddListOrderStatus(eos);
            var n = f.SelectMany(x => x.Items);
            _sql.AddListOrderItem(n);
        }
    }
}
