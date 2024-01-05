using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public class XMLCreator
    {
        public static string BaseXML(string request, string xmlparameters = "")
        {
            var au = File.ReadAllText(@"C:\Ebay\auth.txt");
            var x = $@"<?xml version='1.0' encoding='utf-8'?>
                <{request}Request xmlns='urn:ebay:apis:eBLBaseComponents'>
                    <RequesterCredentials><eBayAuthToken>{au}</eBayAuthToken></RequesterCredentials>
                    {xmlparameters}
                </{request}Request>";
            return x;
        }

        public static string GetSellerList(DateTime from, DateTime to, int entriesPerPage = 100, int pageNum = 1)
        {
            string f = from.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffZ");
            string t = to.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffZ");
            var sellxml = $"<EndTimeFrom>{f}</EndTimeFrom><EndTimeTo>{t}</EndTimeTo>" +
                $"<Pagination><EntriesPerPage>{entriesPerPage}</EntriesPerPage><PageNumber>{pageNum}</PageNumber></Pagination>" +
                "<DetailLevel>ReturnAll</DetailLevel>";
            return sellxml;
        }

        public static string GetSellerListAuto(int entriesPerPage = 100, int pageNum = 1)
        {
            return GetSellerList(DateTime.UtcNow, DateTime.UtcNow.AddDays(120));
        }

        public static string RevisePrice(string itemid, string startPrice)
        {
            return $"<Item><ItemID>{itemid}</ItemID><Currency>AUD</Currency><StartPrice>{startPrice}</StartPrice></Item>";
        }

        public static string ReviseStoreCategory(string itemid, string categoryId)
        {
            return $"<Item><ItemID>{itemid}</ItemID><Storefront><StoreCategoryID>{categoryId}</StoreCategoryID></Storefront></Item>";
        }

        public static string ReviseShippingProfileID(string itemid, string policyId)
        {
            return $"<Item><ItemID>{itemid}</ItemID><SellerProfiles><SellerShippingProfile><ShippingProfileID>{policyId}</ShippingProfileID></SellerShippingProfile></SellerProfiles></Item>";
        }

        public static string ReviseImage(string itemid, List<string> url)
        {
            string img = "";
            for (int i = 0; i < url.Count; i++)
            {
                img += $"<PictureURL>{url[i]}</PictureURL>";
            }
            var r = $"<Item><ItemID>{itemid}</ItemID>";
            r += $@"
                <PictureDetails>
                <GalleryType>Gallery</GalleryType>
                <PhotoDisplay>SuperSize</PhotoDisplay>
                <PictureSource>EPS</PictureSource>
                {img}
                </PictureDetails>";
            r += "</Item>";
            return r;
        }

        public static string ReviseOptionalAll(string itemid,
            string startPrice = "",
            int qty = 0,
            string itemtype = "",
            string categoryid = "",
            string description = "",
            string title = ""
            )
        {
            var r = $"<Item><ItemID>{itemid}</ItemID>";
            if (startPrice != "")
            {
                r += $"<StartPrice currencyID=\"AUD\">{startPrice}</StartPrice>";
            }
            if (qty != 0)
            {
                r += $"<Quantity>{qty}</Quantity>";
            }
            if (categoryid != "")
            {
                r += $"<PrimaryCategory><CategoryID>{categoryid}</CategoryID></PrimaryCategory>";
            }
            if (description != "")
            {
                r += $"<Description>{description}</Description>";
            }
            if (title != "")
            {
                r += $"<Title>{title}</Title>";
            }
            r += "</Item>";
            return r;
        }
        public static string ReviseSKU(string itemid, string sku)
        {
            return $"<Item><ItemID>{itemid}</ItemID>{XMLSnippet.ReviseFixedPriceAttrib()}<SKU>{sku}</SKU></Item>";
        }
        public static string ReviseBrand(string itemid)
        {
            return $"<Item><ItemID>{itemid}</ItemID>{XMLSnippet.ReviseFixedPriceAttrib()}</Item>";
        }

        public static string ReviseQtyWithSKU(int qty, string sku, long itemid)
        {
            return $"<Item><ItemID>{itemid}</ItemID><Variations><Variation><SKU>{sku}</SKU><Quantity>{qty}</Quantity></Variation></Variations>   </Item>";
        }

        public static string ReviseQty(string itemid, int qty)
        {
            return $"<Item><ItemID>{itemid}</ItemID><Quantity>{qty}</Quantity></Item>";
        }

        public static string GetCategories()
        {
            return @"<DetailLevel>ReturnAll</DetailLevel><ViewAllNodes>true</ViewAllNodes>";
        }

        public static string GetItem(string productId)
        {
            return $"<DetailLevel>ReturnAll</DetailLevel><ItemID>{productId}</ItemID>";
        }

        public static string GetOrders(DateTime CreateFrom, DateTime CreateTo, int pageNum, int entriesPerPage = 200)
        {
            return $@"
            <DetailLevel>ReturnAll</DetailLevel>
			<Version>1131</Version>
			<CreateTimeFrom>{CreateFrom.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffZ")}</CreateTimeFrom>
			<CreateTimeTo>{CreateTo.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffZ")}</CreateTimeTo>
			<OrderRole>Seller</OrderRole>	
			<Pagination>
				<EntriesPerPage>{entriesPerPage}</EntriesPerPage>
				<PageNumber>{pageNum}</PageNumber>
			</Pagination>";
        }

        public static string GetMySelling(int page = 1, int entriesperpage = 200)
        {
            return @$"<ActiveList>
                <Sort>TimeLeft</Sort>
                <Pagination>
                    <EntriesPerPage>{entriesperpage}</EntriesPerPage>
                    <PageNumber>{page}</PageNumber>
                </Pagination>
                </ActiveList>";
        }

        public static string UploadExternalImage(string url, string picName)
        {
            return $"<ExternalPictureURL>{url}</ExternalPictureURL><PictureName>{picName}</PictureName>";
        }

    }
}
