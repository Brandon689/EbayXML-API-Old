using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public partial class XMLPost
    {
        private readonly EbayRequest _request;
        private readonly HttpClient _client;

        public XMLPost(EbayRequest request, HttpClient client)
        {
            _request = request;
            _client = client;
        }

        public async Task<string> ReviseItemNewPromo(long itemid, double price,
            string shipprofileid, string storecat)
        {
            string req = "ReviseFixedPriceItem";

            string snip = XMLSnippet.RevisePrice(price.ToString());
            snip += XMLSnippet.ReviseShippingProfile(shipprofileid);
            snip += XMLSnippet.ReviseStoreCategory(storecat);

            string basis = XMLCreator.BaseXML(req,
                XMLSnippet.SnippetBuilder(itemid, snip));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }
        public async Task<string> ReviseItemSKU(long itemid, string sku)
        {
            string req = "ReviseFixedPriceItem";

            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseSKU(itemid.ToString(), sku));
            Console.WriteLine(basis);
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }
        public async Task<string> ReviseItemBrand(long itemid)
        {
            string req = "ReviseFixedPriceItem";

            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseBrand(itemid.ToString()));
            Console.WriteLine(basis);
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }
        public async Task<string> ReviseItemQty(long itemid, int qty)
        {
            string req = "ReviseFixedPriceItem";

            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseQty(itemid.ToString(), qty));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            Console.WriteLine(resu);
            return resu;
        }

        public async Task<string> ReviseItemQtySKU(int qty, string sku, long itemid)
        {
            string req = "ReviseFixedPriceItem";

            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseQtyWithSKU(qty, sku, itemid));
            Console.WriteLine(basis);
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            Console.WriteLine(resu);
            return resu;
        }


        public async Task<string> ReviseItemPrice(long itemid, decimal price)
        {
            string req = "ReviseFixedPriceItem";

            string basis = XMLCreator.BaseXML(req,
                XMLCreator.RevisePrice(itemid.ToString(), price.ToString()));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> ListFixed(decimal price,
            string description, string catid, int qty, string title, string sku, List<string>? pics,
            double weight, string theme)
        {
            string req = "AddFixedPriceItem";

            string snip = SnippetXML.ListFixedPriceOne((double)price, description, catid, qty, title, sku);
            snip += XMLSnippet.ListFixedPricePicture(pics);
            snip += XMLSnippet.ListFixedPriceAttrib(weight, theme);

            string basis = XMLCreator.BaseXML(req,
                XMLSnippet.SnippetListItemBuilder(snip));

            Console.WriteLine(req);

            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            resu = XMLPrepare.Value(resu);

            return resu;
        }

        public async Task<string> ListFixedVaration(decimal price,
            string description, string catid, int qty, string title, string sku, List<string> pics,
            double weight, string theme)
        {
            string req = "AddFixedPriceItem";

            string snip = SnippetXML.ListFixedPriceOne((double)price, description, catid, qty, title, sku, true);
            snip += XMLSnippet.ListFixedPricePicture(pics);
            snip += XMLSnippet.ListFixedPriceAttrib(weight, theme);

            List<VariationItem> v = new();
            VariationItem u = new();
            u.VarName = "Char";
            u.SKU = "one1";
            u.StartPrice = 10;
            u.Name = u.VarName;
            u.Value = "one";
            u.Qty = 0;
            u.Url = "https://i.ebayimg.com/images/g/vRcAAOSw9gVjaX4c/s-l1600.jpg";
            v.Add(u);
            u = new();
            u.VarName = "Char";
            u.SKU = "one2";
            u.StartPrice = 12;
            u.Name = u.VarName;
            u.Value = "two";
            u.Qty = 0;
            u.Url = "https://i.ebayimg.com/images/g/wSgAAOSwDMljaX4d/s-l1600.jpg";
            v.Add(u);
            u = new();
            u.VarName = "Harm";
            u.SKU = "one3";
            u.StartPrice = 12;
            u.Name = u.VarName;
            u.Value = "bbhds";
            u.Qty = 0;
            u.Url = "https://i.ebayimg.com/images/g/wSgAAOSwDMljaX4d/s-l1600.jpg";
            v.Add(u);
            snip += SnippetBuild.Variations(v);

            var param = XMLSnippet.SnippetListItemBuilder(snip);
            var basis = XMLCreator.BaseXML(req, param);
            Console.WriteLine(basis);
            var resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            resu = XMLPrepare.Value(resu);

            return resu;
        }
    }
}
