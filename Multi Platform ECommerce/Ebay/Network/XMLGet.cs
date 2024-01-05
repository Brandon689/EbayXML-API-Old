using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public class XMLGet
    {
        private readonly EbayRequest _request;
        private readonly HttpClient _client;

        public XMLGet(EbayRequest request, HttpClient client)
        {
            _request = request;
            _client = client;
        }

        public async Task<string> UploadExternalPic()
        {
            string req = "UploadSiteHostedPictures";
            string basis = XMLCreator.BaseXML(req, 
                XMLCreator.UploadExternalImage("externalurl", "sample"));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> GetTime()
        {
            string req = "GeteBayOfficialTime";
            string basis = XMLCreator.BaseXML(req);
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }

        public async Task<string> GetItem(string productId)
        {
            string req = "GetItem";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.GetItem(productId));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }

        public async Task<string> ReviseItemPrice(string itemid, string price)
        {
            string req = "ReviseFixedPriceItem";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.RevisePrice(itemid, price));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> ReviseItemShippingProfile(string itemid, string policyId)
        {
            string req = "ReviseFixedPriceItem";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseShippingProfileID(itemid, policyId));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> ReviseItemStoreCategory(string itemid, string categoryId)
        {
            string req = "ReviseFixedPriceItem";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseStoreCategory(itemid, categoryId));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> ReviseItemImage(string itemid, List<string> url)
        {
            string req = "ReviseFixedPriceItem";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseImage(itemid, url));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> ReviseItemAny(string itemid,
            string startPrice = "",
            int qty = 0,
            string itemtype = "",
            string categoryid = "",
            string description = "",
            string title = "")
        {
            string req = "ReviseFixedPriceItem";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.ReviseOptionalAll(itemid, startPrice, qty, itemtype, categoryid, description, title));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Post, _client);
            return resu;
        }

        public async Task<string> GetSellerListAuto() // slow method
        {
            string req = "GetSellerList";
            var param = XMLCreator.GetSellerListAuto();
            string basis = XMLCreator.BaseXML(req, param);
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }

        public async Task<string> GetSellerList(DateTime from, DateTime to, 
            int entriesPerPage = 100, int pageNum = 1) // slow method
        {
            string req = "GetSellerList";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.GetSellerList(from, to, entriesPerPage, pageNum));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }






        public async Task<string> GetMySellingAll(int pg) // fast method, gets variations as well - sellerlist does not
        {
            string req = "GetMyeBaySelling";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.GetMySelling(pg));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }


















        public async Task<string> GetMySelling(int pg) // fast method, gets variations as well - sellerlist does not
        {
            string req = "GetMyeBaySelling";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.GetMySelling(pg));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }

        public async Task<string> GetOrders(int page, int daysCreationFrom = -3, int daysToMinus = 0)
        {
            DateTime da;
            if (daysToMinus == 0)
            {
                da = DateTime.UtcNow.AddHours(12);
            }
            else
            {
                da = DateTime.UtcNow.AddDays(daysToMinus);
            }
            string req = "GetOrders";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.GetOrders(DateTime.UtcNow.AddDays(daysCreationFrom), da, page, 100));
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }

        public async Task<string> GetCategories()
        {
            string req = "GetCategories";
            string basis = XMLCreator.BaseXML(req,
                XMLCreator.GetCategories());
            string resu = await _request.SendHttpRequest(req, basis, HttpMethod.Get, _client);
            resu = XMLPrepare.Value(resu);
            return resu;
        }
    }
}
