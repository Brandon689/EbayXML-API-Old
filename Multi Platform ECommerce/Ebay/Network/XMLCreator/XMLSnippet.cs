using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public class XMLSnippet
    {
		public static string SnippetBuilder(long itemid, string snippets)
		{
			return $"<Item><ItemID>{itemid}</ItemID>{snippets}</Item>";
		}

		public static string SnippetListItemBuilder(string snippets)
		{
			return $"<Item>{snippets}</Item>";
		}

		public static string ListFixedPricePicture(List<string> epsUrl)
		{
			string pics = string.Empty;
			for (int i = 0; i < epsUrl.Count; i++)
			{
				pics += $"<PictureURL>{epsUrl[i]}</PictureURL>";
			}
			return $"<PictureDetails>{pics}</PictureDetails>";
		}

		public static string ListFixedPrice(decimal price, string description, string catId, int qty, string title, string sku, string shippingID, string paymentID,
			string returnID, bool variation = false, string mpn = "Does Not Apply")
		{
			string fixedpriceresult = $@"<Country>AU</Country><Currency>AUD</Currency>
				<Description>{description}</Description>
				<ListingDuration>GTC</ListingDuration>
				<ListingType>FixedPriceItem</ListingType>
				<Location>Sydney</Location>
				<PrimaryCategory>
					<CategoryID>{catId}</CategoryID>
				</PrimaryCategory>
				<ProductListingDetails>
					<BrandMPN>
						<Brand>Unbranded</Brand>
						<MPN>{mpn}</MPN>
					</BrandMPN>
				</ProductListingDetails>
				<Quantity>{qty}</Quantity>
                <Title>{title}</Title>
				<ConditionID>1000</ConditionID>
                <PostalCode>3000</PostalCode>
				<SellerProfiles>
					<SellerShippingProfile>
						<ShippingProfileID>{shippingID}</ShippingProfileID>
					</SellerShippingProfile>
					<SellerReturnProfile>
						<ReturnProfileID>{paymentID}</ReturnProfileID>
					</SellerReturnProfile>
					<SellerPaymentProfile>
						<PaymentProfileID>{returnID}</PaymentProfileID>
					</SellerPaymentProfile>
				</SellerProfiles>";
			if (variation == false)
			{
				fixedpriceresult += $@"<StartPrice currencyID=""AUD"">{price.ToString("0.00")}</StartPrice>
                <SKU>{sku}</SKU>";
			}
			return fixedpriceresult;
		}

		public static string ReviseFixedPriceAttrib()
		{
			return $@"<ItemSpecifics>
					<NameValueList>
						<Name>Brand</Name>
						<Value>Unbranded</Value>
					</NameValueList>
				</ItemSpecifics>";
		}

		public static string ListFixedPriceAttrib(double weight, string theme, string mpn = "Does Not Apply")
		{
			if (weight == 0)
            {
				return $@"<ItemSpecifics>
					<NameValueList>
						<Name>Brand</Name>
						<Value>Unbranded</Value>
					</NameValueList>
					<NameValueList>
						<Name>MPN</Name>
						<Value>{mpn}</Value>
					</NameValueList>
					<NameValueList>
						<Name>Theme</Name>
						<Value>{theme}</Value>
					</NameValueList>
				</ItemSpecifics>";
			}
			else
            {
				return $@"<ItemSpecifics>
					<NameValueList>
						<Name>Brand</Name>
						<Value>Unbranded</Value>
					</NameValueList>
					<NameValueList>
						<Name>Weight</Name>
						<Value>{weight.ToString("0.00")}g</Value>
					</NameValueList>
					<NameValueList>
						<Name>MPN</Name>
						<Value>{mpn}</Value>
					</NameValueList>
					<NameValueList>
						<Name>Theme</Name>
						<Value>{theme}</Value>
					</NameValueList>
				</ItemSpecifics>";
			}
	
		}

		public static string RevisePrice(string startPrice)
		{
			return $"<Currency>AUD</Currency><StartPrice>{startPrice}</StartPrice>";
		}

		public static string ReviseStoreCategory(string categoryId)
		{
			return $"<Storefront><StoreCategoryID>{categoryId}</StoreCategoryID></Storefront>";
		}

		public static string ReviseShippingProfile(string policyId)
		{
			return $"<SellerProfiles><SellerShippingProfile><ShippingProfileID>{policyId}</ShippingProfileID></SellerShippingProfile></SellerProfiles>";
		}
	}
}
