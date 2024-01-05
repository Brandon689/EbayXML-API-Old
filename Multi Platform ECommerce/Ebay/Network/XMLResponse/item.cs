using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Multi_Platform_ECommerce.Ebay.Network
{
	[XmlRoot(ElementName = "PrimaryCategory")]
	public class PrimaryCategory
	{
		[XmlElement(ElementName = "CategoryID")]
		public string? CategoryID { get; set; }
		[XmlElement(ElementName = "CategoryName")]
		public string? CategoryName { get; set; }
	}

	[XmlRoot(ElementName = "BrandMPN")]
	public class BrandMPN
	{
		[XmlElement(ElementName = "Brand")]
		public string? Brand { get; set; }
		[XmlElement(ElementName = "MPN")]
		public string? MPN { get; set; }
	}

	[XmlRoot(ElementName = "ProductListingDetails")]
	public class ProductListingDetails
	{
		[XmlElement(ElementName = "BrandMPN")]
		public BrandMPN BrandMPN { get; set; }
		[XmlElement(ElementName = "IncludeeBayProductDetails")]
		public string? IncludeeBayProductDetails { get; set; }
	}

	[XmlRoot(ElementName = "ReservePrice")]
	public class ReservePrice
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "ReviseStatus")]
	public class ReviseStatus
	{
		[XmlElement(ElementName = "ItemRevised")]
		public string? ItemRevised { get; set; }
	}

	//[XmlRoot(ElementName = "SellerInfo")]
	//public class SellerInfo
	//{
	//	[XmlElement(ElementName = "AllowPaymentEdit")]
	//	public string? AllowPaymentEdit { get; set; }
	//	[XmlElement(ElementName = "CheckoutEnabled")]
	//	public string? CheckoutEnabled { get; set; }
	//	[XmlElement(ElementName = "CIPBankAccountStored")]
	//	public string? CIPBankAccountStored { get; set; }
	//	[XmlElement(ElementName = "GoodStanding")]
	//	public string? GoodStanding { get; set; }
	//	[XmlElement(ElementName = "LiveAuctionAuthorized")]
	//	public string? LiveAuctionAuthorized { get; set; }
	//	[XmlElement(ElementName = "MerchandizingPref")]
	//	public string? MerchandizingPref { get; set; }
	//	[XmlElement(ElementName = "QualifiesForB2BVAT")]
	//	public string? QualifiesForB2BVAT { get; set; }
	//	[XmlElement(ElementName = "StoreOwner")]
	//	public string? StoreOwner { get; set; }
	//	[XmlElement(ElementName = "StoreURL")]
	//	public string? StoreURL { get; set; }
	//	[XmlElement(ElementName = "SafePaymentExempt")]
	//	public string? SafePaymentExempt { get; set; }
	//	[XmlElement(ElementName = "TopRatedSeller")]
	//	public string? TopRatedSeller { get; set; }
	//}

	//[XmlRoot(ElementName = "Seller")]
	//public class Seller
	//{
	//	[XmlElement(ElementName = "AboutMePage")]
	//	public string? AboutMePage { get; set; }
	//	[XmlElement(ElementName = "Email")]
	//	public string? Email { get; set; }
	//	[XmlElement(ElementName = "FeedbackScore")]
	//	public string? FeedbackScore { get; set; }
	//	[XmlElement(ElementName = "PositiveFeedbackPercent")]
	//	public string? PositiveFeedbackPercent { get; set; }
	//	[XmlElement(ElementName = "FeedbackPrivate")]
	//	public string? FeedbackPrivate { get; set; }
	//	[XmlElement(ElementName = "IDVerified")]
	//	public string? IDVerified { get; set; }
	//	[XmlElement(ElementName = "eBayGoodStanding")]
	//	public string? EBayGoodStanding { get; set; }
	//	[XmlElement(ElementName = "NewUser")]
	//	public string? NewUser { get; set; }
	//	[XmlElement(ElementName = "RegistrationDate")]
	//	public string? RegistrationDate { get; set; }
	//	[XmlElement(ElementName = "Site")]
	//	public string? Site { get; set; }
	//	[XmlElement(ElementName = "Status")]
	//	public string? Status { get; set; }
	//	[XmlElement(ElementName = "UserID")]
	//	public string? UserID { get; set; }
	//	[XmlElement(ElementName = "UserIDChanged")]
	//	public string? UserIDChanged { get; set; }
	//	[XmlElement(ElementName = "UserIDLastChanged")]
	//	public string? UserIDLastChanged { get; set; }
	//	[XmlElement(ElementName = "VATStatus")]
	//	public string? VATStatus { get; set; }
	//	[XmlElement(ElementName = "SellerInfo")]
	//	public SellerInfo SellerInfo { get; set; }
	//	[XmlElement(ElementName = "MotorsDealer")]
	//	public string? MotorsDealer { get; set; }
	//}

	[XmlRoot(ElementName = "BidIncrement")]
	public class BidIncrement
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	//[XmlRoot(ElementName = "ConvertedCurrentPrice")]
	//public class ConvertedCurrentPrice
	//{
	//	[XmlAttribute(AttributeName = "currencyID")]
	//	public string? CurrencyID { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	//[XmlRoot(ElementName = "CurrentPrice")]
	//public class CurrentPrice
	//{
	//	[XmlAttribute(AttributeName = "currencyID")]
	//	public string? CurrencyID { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	//[XmlRoot(ElementName = "MinimumToBid")]
	//public class MinimumToBid
	//{
	//	[XmlAttribute(AttributeName = "currencyID")]
	//	public string? CurrencyID { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	//[XmlRoot(ElementName = "SellingStatus")]
	//public class SellingStatus
	//{
	//	[XmlElement(ElementName = "BidCount")]
	//	public string? BidCount { get; set; }
	//	[XmlElement(ElementName = "BidIncrement")]
	//	public BidIncrement BidIncrement { get; set; }
	//	[XmlElement(ElementName = "ConvertedCurrentPrice")]
	//	public ConvertedCurrentPrice ConvertedCurrentPrice { get; set; }
	//	[XmlElement(ElementName = "CurrentPrice")]
	//	public CurrentPrice CurrentPrice { get; set; }
	//	[XmlElement(ElementName = "LeadCount")]
	//	public string? LeadCount { get; set; }
	//	[XmlElement(ElementName = "MinimumToBid")]
	//	public MinimumToBid MinimumToBid { get; set; }
	//	[XmlElement(ElementName = "QuantitySold")]
	//	public string? QuantitySold { get; set; }
	//	[XmlElement(ElementName = "ReserveMet")]
	//	public string? ReserveMet { get; set; }
	//	[XmlElement(ElementName = "SecondChanceEligible")]
	//	public string? SecondChanceEligible { get; set; }
	//	[XmlElement(ElementName = "ListingStatus")]
	//	public string? ListingStatus { get; set; }
	//	[XmlElement(ElementName = "QuantitySoldByPickupInStore")]
	//	public string? QuantitySoldByPickupInStore { get; set; }
	//}

	//[XmlRoot(ElementName = "WeightMajor")]
	//public class WeightMajor
	//{
	//	[XmlAttribute(AttributeName = "measurementSystem")]
	//	public string? MeasurementSystem { get; set; }
	//	[XmlAttribute(AttributeName = "unit")]
	//	public string? Unit { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	//[XmlRoot(ElementName = "WeightMinor")]
	//public class WeightMinor
	//{
	//	[XmlAttribute(AttributeName = "measurementSystem")]
	//	public string? MeasurementSystem { get; set; }
	//	[XmlAttribute(AttributeName = "unit")]
	//	public string? Unit { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	//[XmlRoot(ElementName = "CalculatedShippingRate")]
	//public class CalculatedShippingRate
	//{
	//	[XmlElement(ElementName = "WeightMajor")]
	//	public WeightMajor WeightMajor { get; set; }
	//	[XmlElement(ElementName = "WeightMinor")]
	//	public WeightMinor WeightMinor { get; set; }
	//}

	//[XmlRoot(ElementName = "SalesTax")]
	//public class SalesTax
	//{
	//	[XmlElement(ElementName = "SalesTaxPercent")]
	//	public string? SalesTaxPercent { get; set; }
	//	[XmlElement(ElementName = "ShippingIncludedInTax")]
	//	public string? ShippingIncludedInTax { get; set; }
	//}

	//[XmlRoot(ElementName = "ShippingServiceCost")]
	//public class ShippingServiceCost
	//{
	//	[XmlAttribute(AttributeName = "currencyID")]
	//	public string? CurrencyID { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	[XmlRoot(ElementName = "ShippingServiceAdditionalCost")]
	public class ShippingServiceAdditionalCost
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	//[XmlRoot(ElementName = "ShippingServiceOptions")]
	//public class ShippingServiceOptions
	//{
	//	[XmlElement(ElementName = "ShippingService")]
	//	public string? ShippingService { get; set; }
	//	[XmlElement(ElementName = "ShippingServiceCost")]
	//	public ShippingServiceCost ShippingServiceCost { get; set; }
	//	[XmlElement(ElementName = "ShippingServiceAdditionalCost")]
	//	public ShippingServiceAdditionalCost ShippingServiceAdditionalCost { get; set; }
	//	[XmlElement(ElementName = "ShippingServicePriority")]
	//	public string? ShippingServicePriority { get; set; }
	//	[XmlElement(ElementName = "ExpeditedService")]
	//	public string? ExpeditedService { get; set; }
	//	[XmlElement(ElementName = "ShippingTimeMin")]
	//	public string? ShippingTimeMin { get; set; }
	//	[XmlElement(ElementName = "ShippingTimeMax")]
	//	public string? ShippingTimeMax { get; set; }
	//	[XmlElement(ElementName = "FreeShipping")]
	//	public string? FreeShipping { get; set; }
	//}

	[XmlRoot(ElementName = "InternationalShippingServiceOption")]
	public class InternationalShippingServiceOption
	{
		[XmlElement(ElementName = "ShippingService")]
		public string? ShippingService { get; set; }
		[XmlElement(ElementName = "ShippingServiceCost")]
		public ShippingServiceCost ShippingServiceCost { get; set; }
		[XmlElement(ElementName = "ShippingServiceAdditionalCost")]
		public ShippingServiceAdditionalCost ShippingServiceAdditionalCost { get; set; }
		[XmlElement(ElementName = "ShippingServicePriority")]
		public string? ShippingServicePriority { get; set; }
		[XmlElement(ElementName = "ShipToLocation")]
		public string? ShipToLocation { get; set; }
	}

	//[XmlRoot(ElementName = "EachAdditionalAmount")]
	//public class EachAdditionalAmount
	//{
	//	[XmlAttribute(AttributeName = "currencyID")]
	//	public string? CurrencyID { get; set; }
	//	[XmlText]
	//	public string? Text { get; set; }
	//}

	[XmlRoot(ElementName = "DiscountProfile")]
	public class DiscountProfile
	{
		[XmlElement(ElementName = "DiscountProfileID")]
		public string? DiscountProfileID { get; set; }
		[XmlElement(ElementName = "EachAdditionalAmount")]
		public EachAdditionalAmount EachAdditionalAmount { get; set; }
	}

	//[XmlRoot(ElementName = "FlatShippingDiscount")]
	//public class FlatShippingDiscount
	//{
	//	[XmlElement(ElementName = "DiscountName")]
	//	public string? DiscountName { get; set; }
	//	[XmlElement(ElementName = "DiscountProfile")]
	//	public DiscountProfile DiscountProfile { get; set; }
	//}

	[XmlRoot(ElementName = "InternationalFlatShippingDiscount")]
	public class InternationalFlatShippingDiscount
	{
		[XmlElement(ElementName = "DiscountName")]
		public string? DiscountName { get; set; }
		[XmlElement(ElementName = "DiscountProfile")]
		public DiscountProfile DiscountProfile { get; set; }
	}

	//[XmlRoot(ElementName = "ShippingDetails")]
	//public class ShippingDetails
	//{
	//	[XmlElement(ElementName = "ApplyShippingDiscount")]
	//	public string? ApplyShippingDiscount { get; set; }
	//	[XmlElement(ElementName = "CalculatedShippingRate")]
	//	public CalculatedShippingRate CalculatedShippingRate { get; set; }
	//	[XmlElement(ElementName = "SalesTax")]
	//	public SalesTax SalesTax { get; set; }
	//	[XmlElement(ElementName = "ShippingServiceOptions")]
	//	public List<ShippingServiceOptions> ShippingServiceOptions { get; set; }
	//	[XmlElement(ElementName = "InternationalShippingServiceOption")]
	//	public InternationalShippingServiceOption InternationalShippingServiceOption { get; set; }
	//	[XmlElement(ElementName = "ShippingType")]
	//	public string? ShippingType { get; set; }
	//	[XmlElement(ElementName = "ThirdPartyCheckout")]
	//	public string? ThirdPartyCheckout { get; set; }
	//	[XmlElement(ElementName = "ShippingDiscountProfileID")]
	//	public string? ShippingDiscountProfileID { get; set; }
	//	[XmlElement(ElementName = "FlatShippingDiscount")]
	//	public FlatShippingDiscount FlatShippingDiscount { get; set; }
	//	[XmlElement(ElementName = "InternationalShippingDiscountProfileID")]
	//	public string? InternationalShippingDiscountProfileID { get; set; }
	//	[XmlElement(ElementName = "InternationalFlatShippingDiscount")]
	//	public InternationalFlatShippingDiscount InternationalFlatShippingDiscount { get; set; }
	//	[XmlElement(ElementName = "ExcludeShipToLocation")]
	//	public List<string?> ExcludeShipToLocation { get; set; }
	//	[XmlElement(ElementName = "SellerExcludeShipToLocationsPreference")]
	//	public string? SellerExcludeShipToLocationsPreference { get; set; }
	//}

	[XmlRoot(ElementName = "StartPrice")]
	public class StartPrice
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

    //[XmlRoot(ElementName = "Storefront")]
    //public class Storefront
    //{
    //	[XmlElement(ElementName = "StoreCategoryID")]
    //	public string? StoreCategoryID { get; set; }
    //	[XmlElement(ElementName = "StoreCategory2ID")]
    //	public string? StoreCategory2ID { get; set; }
    //	[XmlElement(ElementName = "StoreURL")]
    //	public string? StoreURL { get; set; }
    //}

    //[XmlRoot(ElementName = "PictureDetails")]
    //public class PictureDetails
    //{
    //	[XmlElement(ElementName = "GalleryType")]
    //	public string? GalleryType { get; set; }
    //	[XmlElement(ElementName = "PhotoDisplay")]
    //	public string? PhotoDisplay { get; set; }
    //	[XmlElement(ElementName = "PictureURL")]
    //	public List<string?> PictureURL { get; set; }
    //	[XmlElement(ElementName = "PictureSource")]
    //	public string? PictureSource { get; set; }
    //}

    //[XmlRoot(ElementName = "BuyerGuaranteePrice")]
    //public class BuyerGuaranteePrice
    //{
    //	[XmlAttribute(AttributeName = "currencyID")]
    //	public string? CurrencyID { get; set; }
    //	[XmlText]
    //	public string? Text { get; set; }
    //}

    //[XmlRoot(ElementName = "MaximumUnpaidItemStrikesInfo")]
    //public class MaximumUnpaidItemStrikesInfo
    //{
    //	[XmlElement(ElementName = "Count")]
    //	public string? Count { get; set; }
    //	[XmlElement(ElementName = "Period")]
    //	public string? Period { get; set; }
    //}

    //[XmlRoot(ElementName = "BuyerRequirementDetails")]
    //public class BuyerRequirementDetails
    //{
    //	[XmlElement(ElementName = "ShipToRegistrationCountry")]
    //	public string? ShipToRegistrationCountry { get; set; }
    //	[XmlElement(ElementName = "MaximumUnpaidItemStrikesInfo")]
    //	public MaximumUnpaidItemStrikesInfo MaximumUnpaidItemStrikesInfo { get; set; }
    //}

    //[XmlRoot(ElementName = "ReturnPolicy")]
    //public class ReturnPolicy
    //{
    //	[XmlElement(ElementName = "ReturnsWithinOption")]
    //	public string? ReturnsWithinOption { get; set; }
    //	[XmlElement(ElementName = "ReturnsWithin")]
    //	public string? ReturnsWithin { get; set; }
    //	[XmlElement(ElementName = "ReturnsAcceptedOption")]
    //	public string? ReturnsAcceptedOption { get; set; }
    //	[XmlElement(ElementName = "ReturnsAccepted")]
    //	public string? ReturnsAccepted { get; set; }
    //	[XmlElement(ElementName = "ShippingCostPaidByOption")]
    //	public string? ShippingCostPaidByOption { get; set; }
    //	[XmlElement(ElementName = "ShippingCostPaidBy")]
    //	public string? ShippingCostPaidBy { get; set; }
    //}

    //[XmlRoot(ElementName = "NameValueList")]
    //public class NameValueList
    //{
    //	[XmlElement(ElementName = "Name")]
    //	public string? Name { get; set; }
    //	[XmlElement(ElementName = "Value")]
    //	public List<string?> Value { get; set; }
    //}

    //[XmlRoot(ElementName = "VariationSpecifics")]
    //public class VariationSpecifics
    //{
    //	[XmlElement(ElementName = "NameValueList")]
    //	public NameValueList NameValueList { get; set; }
    //}

    [XmlRoot(ElementName = "Variation")]
    public class Variation
    {
		[XmlElement(ElementName = "SKU")]
		public string? SKU { get; set; }
		[XmlElement(ElementName = "StartPrice")]
        public StartPrice StartPrice { get; set; }
        [XmlElement(ElementName = "Quantity")]
        public string? Quantity { get; set; }
        [XmlElement(ElementName = "VariationSpecifics")]
        public VariationSpecifics VariationSpecifics { get; set; }
        [XmlElement(ElementName = "SellingStatus")]
        public SellingStatus SellingStatus { get; set; }
    }

    [XmlRoot(ElementName = "VariationSpecificPictureSet")]
	public class VariationSpecificPictureSet
	{
		[XmlElement(ElementName = "VariationSpecificValue")]
		public string? VariationSpecificValue { get; set; }
		[XmlElement(ElementName = "PictureURL")]
		public string? PictureURL { get; set; }
	}

	[XmlRoot(ElementName = "Pictures")]
	public class Pictures
	{
		[XmlElement(ElementName = "VariationSpecificName")]
		public string? VariationSpecificName { get; set; }
		[XmlElement(ElementName = "VariationSpecificPictureSet")]
		public List<VariationSpecificPictureSet> VariationSpecificPictureSet { get; set; }
	}

	[XmlRoot(ElementName = "VariationSpecificsSet")]
	public class VariationSpecificsSet
	{
		[XmlElement(ElementName = "NameValueList")]
		public NameValueList NameValueList { get; set; }
	}

	[XmlRoot(ElementName = "Variations")]
	public class Variations
	{
		[XmlElement(ElementName = "Variation")]
		public List<Variation> Variation { get; set; }
		[XmlElement(ElementName = "Pictures")]
		public Pictures Pictures { get; set; }
		[XmlElement(ElementName = "VariationSpecificsSet")]
		public VariationSpecificsSet VariationSpecificsSet { get; set; }
	}

	//[XmlRoot(ElementName = "SellerShippingProfile")]
	//public class SellerShippingProfile
	//{
	//	[XmlElement(ElementName = "ShippingProfileID")]
	//	public string? ShippingProfileID { get; set; }
	//	[XmlElement(ElementName = "ShippingProfileName")]
	//	public string? ShippingProfileName { get; set; }
	//}

	//[XmlRoot(ElementName = "SellerReturnProfile")]
	//public class SellerReturnProfile
	//{
	//	[XmlElement(ElementName = "ReturnProfileID")]
	//	public string? ReturnProfileID { get; set; }
	//	[XmlElement(ElementName = "ReturnProfileName")]
	//	public string? ReturnProfileName { get; set; }
	//}

	//[XmlRoot(ElementName = "SellerPaymentProfile")]
	//public class SellerPaymentProfile
	//{
	//	[XmlElement(ElementName = "PaymentProfileID")]
	//	public string? PaymentProfileID { get; set; }
	//	[XmlElement(ElementName = "PaymentProfileName")]
	//	public string? PaymentProfileName { get; set; }
	//}

	//[XmlRoot(ElementName = "SellerProfiles")]
	//public class SellerProfiles
	//{
	//	[XmlElement(ElementName = "SellerShippingProfile")]
	//	public SellerShippingProfile SellerShippingProfile { get; set; }
	//	[XmlElement(ElementName = "SellerReturnProfile")]
	//	public SellerReturnProfile SellerReturnProfile { get; set; }
	//	[XmlElement(ElementName = "SellerPaymentProfile")]
	//	public SellerPaymentProfile SellerPaymentProfile { get; set; }
	//}

	//[XmlRoot(ElementName = "ShippingPackageDetails")]
	//public class ShippingPackageDetails
	//{
	//	[XmlElement(ElementName = "ShippingIrregular")]
	//	public string? ShippingIrregular { get; set; }
	//	[XmlElement(ElementName = "ShippingPackage")]
	//	public string? ShippingPackage { get; set; }
	//	[XmlElement(ElementName = "WeightMajor")]
	//	public WeightMajor WeightMajor { get; set; }
	//	[XmlElement(ElementName = "WeightMinor")]
	//	public WeightMinor WeightMinor { get; set; }
	//}

	[XmlRoot(ElementName = "PickupInStoreDetails")]
	public class PickupInStoreDetails
	{
		[XmlElement(ElementName = "AvailableForPickupInStore")]
		public string? AvailableForPickupInStore { get; set; }
	}

	[XmlRoot(ElementName = "Item")]
	public class ItemS
	{
		[XmlElement(ElementName = "AutoPay")]
		public string? AutoPay { get; set; }
		[XmlElement(ElementName = "BuyerProtection")]
		public string? BuyerProtection { get; set; }
		[XmlElement(ElementName = "BuyItNowPrice")]
		public BuyItNowPrice BuyItNowPrice { get; set; }
		[XmlElement(ElementName = "Country")]
		public string? Country { get; set; }
		[XmlElement(ElementName = "Currency")]
		public string? Currency { get; set; }
		[XmlElement(ElementName = "Description")]
		public string? Description { get; set; }
		[XmlElement(ElementName = "GiftIcon")]
		public string? GiftIcon { get; set; }
		[XmlElement(ElementName = "ItemID")]
		public string? ItemID { get; set; }
		[XmlElement(ElementName = "ListingDetails")]
		public ListingDetails ListingDetails { get; set; }
		[XmlElement(ElementName = "ListingDesigner")]
		public ListingDesigner ListingDesigner { get; set; }
		[XmlElement(ElementName = "ListingDuration")]
		public string? ListingDuration { get; set; }
		[XmlElement(ElementName = "ListingType")]
		public string? ListingType { get; set; }
		[XmlElement(ElementName = "Location")]
		public string? Location { get; set; }
		[XmlElement(ElementName = "PrimaryCategory")]
		public PrimaryCategory PrimaryCategory { get; set; }
		[XmlElement(ElementName = "PrivateListing")]
		public string? PrivateListing { get; set; }
		[XmlElement(ElementName = "ProductListingDetails")]
		public ProductListingDetails ProductListingDetails { get; set; }
		[XmlElement(ElementName = "Quantity")]
		public string? Quantity { get; set; }
		[XmlElement(ElementName = "ReservePrice")]
		public ReservePrice ReservePrice { get; set; }
		[XmlElement(ElementName = "ReviseStatus")]
		public ReviseStatus ReviseStatus { get; set; }
		[XmlElement(ElementName = "Seller")]
		public Seller Seller { get; set; }
		[XmlElement(ElementName = "SellingStatus")]
		public SellingStatus SellingStatus { get; set; }
		[XmlElement(ElementName = "ShippingDetails")]
		public ShippingDetails ShippingDetails { get; set; }
		[XmlElement(ElementName = "ShipToLocations")]
		public string? ShipToLocations { get; set; }
		[XmlElement(ElementName = "Site")]
		public string? Site { get; set; }
		[XmlElement(ElementName = "StartPrice")]
		public StartPrice StartPrice { get; set; }
		[XmlElement(ElementName = "Storefront")]
		public Storefront Storefront { get; set; }
		[XmlElement(ElementName = "TimeLeft")]
		public string? TimeLeft { get; set; }
		[XmlElement(ElementName = "Title")]
		public string? Title { get; set; }
		[XmlElement(ElementName = "GetItFast")]
		public string? GetItFast { get; set; }
		[XmlElement(ElementName = "SKU")]
		public string? SKU { get; set; }
		[XmlElement(ElementName = "PostalCode")]
		public string? PostalCode { get; set; }
		[XmlElement(ElementName = "PictureDetails")]
		public PictureDetails PictureDetails { get; set; }
		[XmlElement(ElementName = "DispatchTimeMax")]
		public string? DispatchTimeMax { get; set; }
		[XmlElement(ElementName = "ProxyItem")]
		public string? ProxyItem { get; set; }
		[XmlElement(ElementName = "BuyerGuaranteePrice")]
		public BuyerGuaranteePrice BuyerGuaranteePrice { get; set; }
		[XmlElement(ElementName = "BuyerRequirementDetails")]
		public BuyerRequirementDetails BuyerRequirementDetails { get; set; }
		[XmlElement(ElementName = "ReturnPolicy")]
		public ReturnPolicy ReturnPolicy { get; set; }
		[XmlElement(ElementName = "Variations")]
		public Variations Variations { get; set; }
		[XmlElement(ElementName = "ConditionID")]
		public string? ConditionID { get; set; }
		[XmlElement(ElementName = "ConditionDisplayName")]
		public string? ConditionDisplayName { get; set; }
		[XmlElement(ElementName = "PostCheckoutExperienceEnabled")]
		public string? PostCheckoutExperienceEnabled { get; set; }
		[XmlElement(ElementName = "SellerProfiles")]
		public SellerProfiles SellerProfiles { get; set; }
		[XmlElement(ElementName = "ShippingPackageDetails")]
		public ShippingPackageDetails ShippingPackageDetails { get; set; }
		[XmlElement(ElementName = "HideFromSearch")]
		public string? HideFromSearch { get; set; }
		[XmlElement(ElementName = "OutOfStockControl")]
		public string? OutOfStockControl { get; set; }
		[XmlElement(ElementName = "PickupInStoreDetails")]
		public PickupInStoreDetails PickupInStoreDetails { get; set; }
		[XmlElement(ElementName = "eBayPlus")]
		public string? EBayPlus { get; set; }
		[XmlElement(ElementName = "eBayPlusEligible")]
		public string? EBayPlusEligible { get; set; }
		[XmlElement(ElementName = "IsSecureDescription")]
		public string? IsSecureDescription { get; set; }
	}

	[XmlRoot(ElementName = "GetItemResponse")]
	public class GetItemResponse
	{
		[XmlElement(ElementName = "Timestamp")]
		public string? Timestamp { get; set; }
		[XmlElement(ElementName = "Ack")]
		public string? Ack { get; set; }
		[XmlElement(ElementName = "Version")]
		public string? Version { get; set; }
		[XmlElement(ElementName = "Build")]
		public string? Build { get; set; }
		[XmlElement(ElementName = "Item")]
		public ItemS Item { get; set; }
	}
}