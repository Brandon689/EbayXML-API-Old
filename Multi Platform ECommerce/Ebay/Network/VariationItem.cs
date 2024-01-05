using System.Collections.Generic;
using System.Linq;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public class VariationItem
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? SKU { get; set; }
        public string? Url { get; set; }
        public double StartPrice { get; set; }
        public int Qty { get; set; }
        public string? VarName { get; set; }
    }
    public static class SnippetBuild
    {
        public static string Variations(List<VariationItem> v)
        {
            string result = string.Empty;
            result += SnippetXML.VariationSpecificSet(v);
            result += SnippetXML.Variations(v);
            result += SnippetXML.VariationPictures(v);
            return $"<Variations>{result}</Variations>";
        }
    }
    public static class SnippetXML
    {
        public static string SnippetBuilder(long itemid, string snippets)
        {
            return $"<Item><ItemID>{itemid.ToString()}</ItemID>{snippets}</Item>";
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

        public static string VariationPictures(List<VariationItem> v)
        {
            string pics = $"<Pictures><VariationSpecificName>{v[0].VarName}</VariationSpecificName>";
            for (int i = 0; i < v.Count - 1; i++)
            {
                pics += $@"<VariationSpecificPictureSet>
							<VariationSpecificValue>{v[i].Value}</VariationSpecificValue>
							<PictureURL>{v[i].Url}</PictureURL>
						</VariationSpecificPictureSet>";
            }
            return $"<PictureDetails>{pics}</Pictures></PictureDetails>";
        }

        public static string Variations(List<VariationItem> v)
        {
            string pics = string.Empty;
            for (int i = 0; i < v.Count - 1; i++)
            {
                pics += $@"<Variation>
							<SKU>yaoi{i}</SKU>
							<StartPrice currencyID=""AUD"">{v[i].StartPrice}</StartPrice>
							<Quantity>{v[i].Qty}</Quantity>
							<VariationSpecifics>
								<NameValueList>
									<Name>{v[i].Name}</Name>
									<Value>{v[i].Value}</Value>
								</NameValueList>
    <NameValueList>
      <Name>Harm</Name>
      <Value>bbhds</Value>
    </NameValueList>
							</VariationSpecifics>
							<VariationTitle>no{v[i].Value}</VariationTitle>
						</Variation>";
            }
            return pics;
            //return $"<Variations>{pics}</Variations>";
        }
      //  public static string Variations(List<VariationItem> v)
      //  {
      //      string pics = string.Empty;
      //      for (int i = 0; i < v.Count; i++)
      //      {
      //          pics += $@"<Variation>
						//	<SKU>yaoi</SKU>
						//	<StartPrice currencyID=""AUD"">{v[i].StartPrice}</StartPrice>
						//	<Quantity>{v[i].Qty}</Quantity>
						//	<VariationSpecifics>
						//		<NameValueList>
						//			<Name>{v[i].Name}</Name>
						//			<Value>{v[i].Value}</Value>
						//		</NameValueList>
						//	</VariationSpecifics>
						//	<VariationTitle>no{v[i].Value}</VariationTitle>
						//</Variation>";
      //      }
      //      return pics;
      //      //return $"<Variations>{pics}</Variations>";
      //  }

        public static string VariationSpecificSet(List<VariationItem> v)
        {
            string bebe = v[0].VarName;
            bool futari = false;
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i].VarName != bebe)
                    futari = true;
            }
            if (futari)
            {
                var c1 = v.Where(x => x.VarName == bebe).ToList();
                var c2 = v.Where(x => x.VarName != bebe).ToList();

                string vrs = string.Empty;
                vrs += $"<Name>{c1[0].Name}</Name>";

                for (int i = 0; i < c1.Count; i++)
                {
                    vrs += $"<Value>{c1[i].Value}</Value>";
                }
                var x = $@"<NameValueList>
							{vrs}
						</NameValueList>";

                vrs = $"<Name>{c2[0].Name}</Name>";
                for (int i = 0; i < c2.Count; i++)
                {
                    vrs += $"<Value>{c2[i].Value}</Value>";
                }
                var z = $@"<VariationSpecificsSet>
                        {x}
						<NameValueList>
							{vrs}
						</NameValueList>
					</VariationSpecificsSet>"; 

                return z;
            }
            else
            {

                string vrs = string.Empty;
                vrs += $"<Name>{v[0].Name}</Name>";

                for (int i = 0; i < v.Count; i++)
                {
                    vrs += $"<Value>{v[i].Value}</Value>";
                }
                return $@"<VariationSpecificsSet>
						<NameValueList>
							{vrs}
						</NameValueList>
					</VariationSpecificsSet>";
            }
        }
     //   public static string VariationSpecificSet(VariationItem v)
     //   {
     //       string vrs = string.Empty;

     //       vrs += $"<Name>{v.Name}</Value>";
     //       for (int i = 0; i < v.; i++)
     //       {
     //           vrs += $"<Value>{v[i].Name}</Value>";
     //       }

     //       return $@"<VariationSpecificsSet>
					//	<NameValueList>
					//		{vrs}
					//	</NameValueList>
					//</VariationSpecificsSet>";
     //   }

        public static string ListFixedPriceOne(double price, string description, string catId, int qty, string title, string sku, bool variation = false, string mpn = "Does Not Apply")
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
						<Brand></Brand>
						<MPN>{mpn}</MPN>
					</BrandMPN>
				</ProductListingDetails>
				<Quantity>{qty}</Quantity>
                <Title>{title}</Title>
				<ConditionID>1000</ConditionID>
                <PostalCode></PostalCode>
				<SellerProfiles>
					<SellerShippingProfile>
						<ShippingProfileID>203469122013</ShippingProfileID>
					</SellerShippingProfile>
					<SellerReturnProfile>
						<ReturnProfileID>196245392013</ReturnProfileID>
					</SellerReturnProfile>
					<SellerPaymentProfile>
						<PaymentProfileID>159897346013</PaymentProfileID>
					</SellerPaymentProfile>
				</SellerProfiles>";
            if (variation == false)
            {
                fixedpriceresult += $@"<StartPrice currencyID=""AUD"">{price.ToString("0.00")}</StartPrice>
                <SKU>{sku}</SKU>";
            }
            return fixedpriceresult;
        }

        public static string ListFixedPriceAttrib(double weight, string theme, string mpn = "Does Not Apply")
        {
            return $@"<ItemSpecifics>
					<NameValueList>
						<Name>Brand</Name>
						<Value></Value>
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