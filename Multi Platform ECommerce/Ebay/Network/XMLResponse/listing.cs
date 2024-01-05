using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Multi_Platform_ECommerce.Ebay.Network
{
	[XmlRoot(ElementName = "PaginationResult")]
	public class PaginationResultL
	{
		[XmlElement(ElementName = "TotalNumberOfPages")]
		public int TotalNumberOfPages { get; set; }

		[XmlElement(ElementName = "TotalNumberOfEntries")]
		public int TotalNumberOfEntries { get; set; }
	}

	[XmlRoot(ElementName = "BuyItNowPrice")]
	public class BuyItNowPriceL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ConvertedBuyItNowPrice")]
	public class ConvertedBuyItNowPrice
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ConvertedStartPrice")]
	public class ConvertedStartPrice
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ConvertedReservePrice")]
	public class ConvertedReservePrice
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ListingDetails")]
	public class ListingDetailsL
	{

		[XmlElement(ElementName = "Adult")]
		public bool Adult { get; set; }

		[XmlElement(ElementName = "BindingAuction")]
		public bool BindingAuction { get; set; }

		[XmlElement(ElementName = "CheckoutEnabled")]
		public bool CheckoutEnabled { get; set; }

		[XmlElement(ElementName = "ConvertedBuyItNowPrice")]
		public ConvertedBuyItNowPrice? ConvertedBuyItNowPrice { get; set; }

		[XmlElement(ElementName = "ConvertedStartPrice")]
		public ConvertedStartPrice? ConvertedStartPrice { get; set; }

		[XmlElement(ElementName = "ConvertedReservePrice")]
		public ConvertedReservePrice? ConvertedReservePrice { get; set; }

		[XmlElement(ElementName = "HasReservePrice")]
		public bool HasReservePrice { get; set; }

		[XmlElement(ElementName = "StartTime")]
		public DateTime StartTime { get; set; }

		[XmlElement(ElementName = "EndTime")]
		public DateTime EndTime { get; set; }

		[XmlElement(ElementName = "ViewItemURL")]
		public string? ViewItemURL { get; set; }

		[XmlElement(ElementName = "HasUnansweredQuestions")]
		public bool HasUnansweredQuestions { get; set; }

		[XmlElement(ElementName = "HasPublicMessages")]
		public bool HasPublicMessages { get; set; }

		[XmlElement(ElementName = "ViewItemURLForNaturalSearch")]
		public string? ViewItemURLForNaturalSearch { get; set; }
	}

	[XmlRoot(ElementName = "ListingDesigner")]
	public class ListingDesigner
	{

		[XmlElement(ElementName = "LayoutID")]
		public int LayoutID { get; set; }

		[XmlElement(ElementName = "ThemeID")]
		public int ThemeID { get; set; }
	}

	[XmlRoot(ElementName = "PrimaryCategory")]
	public class PrimaryCategoryL
	{

		[XmlElement(ElementName = "CategoryID")]
		public long CategoryID { get; set; }

		[XmlElement(ElementName = "CategoryName")]
		public string? CategoryName { get; set; }
	}

	[XmlRoot(ElementName = "ReservePrice")]
	public class ReservePriceL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ReviseStatus")]
	public class ReviseStatusL
	{

		[XmlElement(ElementName = "ItemRevised")]
		public bool ItemRevised { get; set; }
	}

	[XmlRoot(ElementName = "BidIncrement")]
	public class BidIncrementL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ConvertedCurrentPrice")]
	public class ConvertedCurrentPrice
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "CurrentPrice")]
	public class CurrentPriceL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "MinimumToBid")]
	public class MinimumToBid
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "SellingStatus")]
	public class SellingStatusL
	{

		[XmlElement(ElementName = "BidCount")]
		public int BidCount { get; set; }

		[XmlElement(ElementName = "BidIncrement")]
		public BidIncrementL? BidIncrement { get; set; }

		[XmlElement(ElementName = "ConvertedCurrentPrice")]
		public ConvertedCurrentPrice? ConvertedCurrentPrice { get; set; }

		[XmlElement(ElementName = "CurrentPrice")]
		public CurrentPriceL? CurrentPrice { get; set; }

		[XmlElement(ElementName = "LeadCount")]
		public int LeadCount { get; set; }

		[XmlElement(ElementName = "MinimumToBid")]
		public MinimumToBid? MinimumToBid { get; set; }

		[XmlElement(ElementName = "QuantitySold")]
		public int QuantitySold { get; set; }

		[XmlElement(ElementName = "ReserveMet")]
		public bool ReserveMet { get; set; }

		[XmlElement(ElementName = "SecondChanceEligible")]
		public bool SecondChanceEligible { get; set; }

		[XmlElement(ElementName = "ListingStatus")]
		public string? ListingStatus { get; set; }
	}

	[XmlRoot(ElementName = "WeightMajor")]
	public class WeightMajor
	{

		[XmlAttribute(AttributeName = "measurementSystem")]
		public string? MeasurementSystem { get; set; }

		[XmlAttribute(AttributeName = "unit")]
		public string? Unit { get; set; }

		[XmlText]
		public int Text { get; set; }
	}

	[XmlRoot(ElementName = "WeightMinor")]
	public class WeightMinor
	{

		[XmlAttribute(AttributeName = "measurementSystem")]
		public string? MeasurementSystem { get; set; }

		[XmlAttribute(AttributeName = "unit")]
		public string? Unit { get; set; }

		[XmlText]
		public int Text { get; set; }
	}

	[XmlRoot(ElementName = "CalculatedShippingRate")]
	public class CalculatedShippingRate
	{

		[XmlElement(ElementName = "WeightMajor")]
		public WeightMajor? WeightMajor { get; set; }

		[XmlElement(ElementName = "WeightMinor")]
		public WeightMinor? WeightMinor { get; set; }
	}

	[XmlRoot(ElementName = "SalesTax")]
	public class SalesTax
	{

		[XmlElement(ElementName = "SalesTaxPercent")]
		public double SalesTaxPercent { get; set; }

		[XmlElement(ElementName = "ShippingIncludedInTax")]
		public bool ShippingIncludedInTax { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceCost")]
	public class ShippingServiceCostL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceAdditionalCost")]
	public class ShippingServiceAdditionalCostL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceOptions")]
	public class ShippingServiceOptionsL
	{

		[XmlElement(ElementName = "ShippingService")]
		public string? ShippingService { get; set; }

		[XmlElement(ElementName = "ShippingServiceCost")]
		public ShippingServiceCostL? ShippingServiceCost { get; set; }

		[XmlElement(ElementName = "ShippingServiceAdditionalCost")]
		public ShippingServiceAdditionalCostL? ShippingServiceAdditionalCost { get; set; }

		[XmlElement(ElementName = "ShippingServicePriority")]
		public int ShippingServicePriority { get; set; }

		[XmlElement(ElementName = "ExpeditedService")]
		public bool ExpeditedService { get; set; }

		[XmlElement(ElementName = "ShippingTimeMin")]
		public int ShippingTimeMin { get; set; }

		[XmlElement(ElementName = "ShippingTimeMax")]
		public int ShippingTimeMax { get; set; }

		[XmlElement(ElementName = "FreeShipping")]
		public bool FreeShipping { get; set; }
	}

	[XmlRoot(ElementName = "EachAdditionalAmount")]
	public class EachAdditionalAmount
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "DiscountProfile")]
	public class DiscountProfileL
	{

		[XmlElement(ElementName = "DiscountProfileID")]
		public long DiscountProfileID { get; set; }

		[XmlElement(ElementName = "EachAdditionalAmount")]
		public EachAdditionalAmount? EachAdditionalAmount { get; set; }
	}

	[XmlRoot(ElementName = "FlatShippingDiscount")]
	public class FlatShippingDiscount
	{

		[XmlElement(ElementName = "DiscountName")]
		public string? DiscountName { get; set; }

		[XmlElement(ElementName = "DiscountProfile")]
		public DiscountProfileL? DiscountProfile { get; set; }
	}

	[XmlRoot(ElementName = "ShippingDetails")]
	public class ShippingDetailsL
	{

		[XmlElement(ElementName = "ShippingServiceOptions")]
		public List<ShippingServiceOptionsL>? ShippingServiceOptions { get; set; }

		[XmlElement(ElementName = "ShippingType")]
		public string? ShippingType { get; set; }

		[XmlElement(ElementName = "ThirdPartyCheckout")]
		public bool ThirdPartyCheckout { get; set; }

		[XmlElement(ElementName = "ShippingDiscountProfileID")]
		public long ShippingDiscountProfileID { get; set; }

		[XmlElement(ElementName = "FlatShippingDiscount")]
		public FlatShippingDiscount? FlatShippingDiscount { get; set; }

		[XmlElement(ElementName = "InternationalShippingDiscountProfileID")]
		public long InternationalShippingDiscountProfileID { get; set; }

		[XmlElement(ElementName = "ExcludeShipToLocation")]
		public List<string>? ExcludeShipToLocation { get; set; }

		[XmlElement(ElementName = "SellerExcludeShipToLocationsPreference")]
		public bool SellerExcludeShipToLocationsPreference { get; set; }
	}

	[XmlRoot(ElementName = "StartPrice")]
	public class StartPriceL
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "Storefront")]
	public class Storefront
	{

		[XmlElement(ElementName = "StoreCategoryID")]
		public long StoreCategoryID { get; set; }

		[XmlElement(ElementName = "StoreCategory2ID")]
		public long StoreCategory2ID { get; set; }

		[XmlElement(ElementName = "StoreURL")]
		public string? StoreURL { get; set; }
	}

	[XmlRoot(ElementName = "PictureDetails")]
	public class PictureDetails
	{
		[XmlElement(ElementName = "GalleryType")]
		public string? GalleryType { get; set; }

		[XmlElement(ElementName = "PhotoDisplay")]
		public string? PhotoDisplay { get; set; }

		[XmlElement(ElementName = "PictureURL")]
		public List<string>? PictureURL { get; set; }
	}

	[XmlRoot(ElementName = "BuyerGuaranteePrice")]
	public class BuyerGuaranteePrice
	{

		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }

		[XmlText]
		public double Text { get; set; }
	}

	[XmlRoot(ElementName = "MaximumUnpaidItemStrikesInfo")]
	public class MaximumUnpaidItemStrikesInfo
	{

		[XmlElement(ElementName = "Count")]
		public int Count { get; set; }

		[XmlElement(ElementName = "Period")]
		public string? Period { get; set; }
	}

	[XmlRoot(ElementName = "BuyerRequirementDetails")]
	public class BuyerRequirementDetails
	{

		[XmlElement(ElementName = "ShipToRegistrationCountry")]
		public bool ShipToRegistrationCountry { get; set; }

		[XmlElement(ElementName = "MaximumUnpaidItemStrikesInfo")]
		public MaximumUnpaidItemStrikesInfo? MaximumUnpaidItemStrikesInfo { get; set; }
	}

	[XmlRoot(ElementName = "ReturnPolicy")]
	public class ReturnPolicy
	{
		[XmlElement(ElementName = "ReturnsWithinOption")]
		public string? ReturnsWithinOption { get; set; }

		[XmlElement(ElementName = "ReturnsWithin")]
		public string? ReturnsWithin { get; set; }

		[XmlElement(ElementName = "ReturnsAcceptedOption")]
		public string? ReturnsAcceptedOption { get; set; }

		[XmlElement(ElementName = "ReturnsAccepted")]
		public string? ReturnsAccepted { get; set; }

		[XmlElement(ElementName = "ShippingCostPaidByOption")]
		public string? ShippingCostPaidByOption { get; set; }

		[XmlElement(ElementName = "ShippingCostPaidBy")]
		public string? ShippingCostPaidBy { get; set; }
	}

	[XmlRoot(ElementName = "SellerShippingProfile")]
	public class SellerShippingProfileL
	{

		[XmlElement(ElementName = "ShippingProfileID")]
		public double ShippingProfileID { get; set; }

		[XmlElement(ElementName = "ShippingProfileName")]
		public string? ShippingProfileName { get; set; }
	}

	[XmlRoot(ElementName = "SellerReturnProfile")]
	public class SellerReturnProfileL
	{

		[XmlElement(ElementName = "ReturnProfileID")]
		public double ReturnProfileID { get; set; }

		[XmlElement(ElementName = "ReturnProfileName")]
		public string? ReturnProfileName { get; set; }
	}

	[XmlRoot(ElementName = "SellerPaymentProfile")]
	public class SellerPaymentProfileL
	{

		[XmlElement(ElementName = "PaymentProfileID")]
		public double PaymentProfileID { get; set; }

		[XmlElement(ElementName = "PaymentProfileName")]
		public string? PaymentProfileName { get; set; }
	}

	[XmlRoot(ElementName = "SellerProfiles")]
	public class SellerProfilesL
	{

		[XmlElement(ElementName = "SellerShippingProfile")]
		public SellerShippingProfileL? SellerShippingProfile { get; set; }

		[XmlElement(ElementName = "SellerReturnProfile")]
		public SellerReturnProfileL? SellerReturnProfile { get; set; }

		[XmlElement(ElementName = "SellerPaymentProfile")]
		public SellerPaymentProfileL? SellerPaymentProfile { get; set; }
	}

	[XmlRoot(ElementName = "ShippingPackageDetails")]
	public class ShippingPackageDetails
	{

		[XmlElement(ElementName = "ShippingIrregular")]
		public bool ShippingIrregular { get; set; }

		[XmlElement(ElementName = "ShippingPackage")]
		public string? ShippingPackage { get; set; }

		[XmlElement(ElementName = "WeightMajor")]
		public WeightMajor WeightMajor { get; set; }

		[XmlElement(ElementName = "WeightMinor")]
		public WeightMinor WeightMinor { get; set; }
	}

	[XmlRoot(ElementName = "Item")]
	public class ItemL
	{
		[XmlElement(ElementName = "AutoPay")]
		public bool AutoPay { get; set; }

		[XmlElement(ElementName = "BuyerProtection")]
		public string? BuyerProtection { get; set; }

		[XmlElement(ElementName = "BuyItNowPrice")]
		public BuyItNowPriceL BuyItNowPrice { get; set; }

		[XmlElement(ElementName = "Country")]
		public string? Country { get; set; }

		[XmlElement(ElementName = "Currency")]
		public string? Currency { get; set; }

		[XmlElement(ElementName = "Description")]
		public string? Description { get; set; }

		[XmlElement(ElementName = "HitCounter")]
		public string? HitCounter { get; set; }

		[XmlElement(ElementName = "ItemID")]
		public double ItemID { get; set; }

		[XmlElement(ElementName = "ListingDetails")]
		public ListingDetailsL ListingDetails { get; set; }

		[XmlElement(ElementName = "ListingDesigner")]
		public ListingDesigner ListingDesigner { get; set; }

		[XmlElement(ElementName = "ListingDuration")]
		public string? ListingDuration { get; set; }

		[XmlElement(ElementName = "ListingType")]
		public string? ListingType { get; set; }

		[XmlElement(ElementName = "Location")]
		public string? Location { get; set; }

		[XmlElement(ElementName = "PrimaryCategory")]
		public PrimaryCategoryL PrimaryCategory { get; set; }

		[XmlElement(ElementName = "PrivateListing")]
		public bool PrivateListing { get; set; }

		[XmlElement(ElementName = "Quantity")]
		public int Quantity { get; set; }

		[XmlElement(ElementName = "ReservePrice")]
		public ReservePriceL ReservePrice { get; set; }

		[XmlElement(ElementName = "ReviseStatus")]
		public ReviseStatusL ReviseStatus { get; set; }

		[XmlElement(ElementName = "SellingStatus")]
		public SellingStatusL SellingStatus { get; set; }

		[XmlElement(ElementName = "ShippingDetails")]
		public ShippingDetailsL? ShippingDetails { get; set; }

		[XmlElement(ElementName = "ShipToLocations")]
		public string? ShipToLocations { get; set; }

		[XmlElement(ElementName = "Site")]
		public string? Site { get; set; }

		[XmlElement(ElementName = "StartPrice")]
		public StartPriceL? StartPrice { get; set; }

		[XmlElement(ElementName = "Storefront")]
		public Storefront? Storefront { get; set; }

		[XmlElement(ElementName = "TimeLeft")]
		public string? TimeLeft { get; set; }

		[XmlElement(ElementName = "Title")]
		public string? Title { get; set; }

		[XmlElement(ElementName = "GetItFast")]
		public bool GetItFast { get; set; }

		[XmlElement(ElementName = "SKU")]
		public string? SKU { get; set; }

		[XmlElement(ElementName = "PostalCode")]
		public int PostalCode { get; set; }

		[XmlElement(ElementName = "PictureDetails")]
		public PictureDetails? PictureDetails { get; set; }

		[XmlElement(ElementName = "DispatchTimeMax")]
		public int DispatchTimeMax { get; set; }

		[XmlElement(ElementName = "ProxyItem")]
		public bool ProxyItem { get; set; }

		[XmlElement(ElementName = "BuyerGuaranteePrice")]
		public BuyerGuaranteePrice? BuyerGuaranteePrice { get; set; }

		[XmlElement(ElementName = "BuyerRequirementDetails")]
		public BuyerRequirementDetails? BuyerRequirementDetails { get; set; }

		[XmlElement(ElementName = "ReturnPolicy")]
		public ReturnPolicy? ReturnPolicy { get; set; }

		[XmlElement(ElementName = "ConditionID")]
		public int ConditionID { get; set; }

		[XmlElement(ElementName = "ConditionDisplayName")]
		public string? ConditionDisplayName { get; set; }

		[XmlElement(ElementName = "PostCheckoutExperienceEnabled")]
		public bool PostCheckoutExperienceEnabled { get; set; }

		[XmlElement(ElementName = "SellerProfiles")]
		public SellerProfilesL? SellerProfiles { get; set; }

		[XmlElement(ElementName = "ShippingPackageDetails")]
		public ShippingPackageDetails? ShippingPackageDetails { get; set; }

		[XmlElement(ElementName = "HideFromSearch")]
		public bool HideFromSearch { get; set; }

		[XmlElement(ElementName = "eBayPlus")]
		public bool EBayPlus { get; set; }

		[XmlElement(ElementName = "eBayPlusEligible")]
		public bool EBayPlusEligible { get; set; }

		[XmlElement(ElementName = "IsSecureDescription")]
		public bool IsSecureDescription { get; set; }
	}

	[XmlRoot(ElementName = "ItemArray")]
	public class ItemArrayL
	{

		[XmlElement(ElementName = "Item")]
		public List<ItemL>? Item { get; set; }
	}

	[XmlRoot(ElementName = "SellerInfo")]
	public class SellerInfo
	{

		[XmlElement(ElementName = "AllowPaymentEdit")]
		public bool AllowPaymentEdit { get; set; }

		[XmlElement(ElementName = "CheckoutEnabled")]
		public bool CheckoutEnabled { get; set; }

		[XmlElement(ElementName = "CIPBankAccountStored")]
		public bool CIPBankAccountStored { get; set; }

		[XmlElement(ElementName = "GoodStanding")]
		public bool GoodStanding { get; set; }

		[XmlElement(ElementName = "LiveAuctionAuthorized")]
		public bool LiveAuctionAuthorized { get; set; }

		[XmlElement(ElementName = "MerchandizingPref")]
		public string? MerchandizingPref { get; set; }

		[XmlElement(ElementName = "QualifiesForB2BVAT")]
		public bool QualifiesForB2BVAT { get; set; }

		[XmlElement(ElementName = "StoreOwner")]
		public bool StoreOwner { get; set; }

		[XmlElement(ElementName = "StoreURL")]
		public string? StoreURL { get; set; }

		[XmlElement(ElementName = "SafePaymentExempt")]
		public bool SafePaymentExempt { get; set; }

		[XmlElement(ElementName = "TopRatedSeller")]
		public bool TopRatedSeller { get; set; }
	}

	[XmlRoot(ElementName = "Seller")]
	public class Seller
	{

		[XmlElement(ElementName = "AboutMePage")]
		public bool AboutMePage { get; set; }

		[XmlElement(ElementName = "Email")]
		public string? Email { get; set; }

		[XmlElement(ElementName = "FeedbackScore")]
		public int FeedbackScore { get; set; }

		[XmlElement(ElementName = "PositiveFeedbackPercent")]
		public double PositiveFeedbackPercent { get; set; }

		[XmlElement(ElementName = "FeedbackPrivate")]
		public bool FeedbackPrivate { get; set; }

		[XmlElement(ElementName = "IDVerified")]
		public bool IDVerified { get; set; }

		[XmlElement(ElementName = "eBayGoodStanding")]
		public bool EBayGoodStanding { get; set; }

		[XmlElement(ElementName = "NewUser")]
		public bool NewUser { get; set; }

		[XmlElement(ElementName = "RegistrationDate")]
		public DateTime RegistrationDate { get; set; }

		[XmlElement(ElementName = "Site")]
		public string? Site { get; set; }

		[XmlElement(ElementName = "Status")]
		public string? Status { get; set; }

		[XmlElement(ElementName = "UserID")]
		public string? UserID { get; set; }

		[XmlElement(ElementName = "UserIDChanged")]
		public bool UserIDChanged { get; set; }

		[XmlElement(ElementName = "UserIDLastChanged")]
		public DateTime UserIDLastChanged { get; set; }

		[XmlElement(ElementName = "VATStatus")]
		public string? VATStatus { get; set; }

		[XmlElement(ElementName = "SellerInfo")]
		public SellerInfo? SellerInfo { get; set; }

		[XmlElement(ElementName = "MotorsDealer")]
		public bool MotorsDealer { get; set; }
	}

	[XmlRoot(ElementName = "GetSellerListResponse")]
	//[XmlRoot(ElementName = "GetSellerListResponse")]
	public class GetSellerListResponse
	{
		[XmlElement(ElementName = "Timestamp")]
		public DateTime Timestamp { get; set; }

		[XmlElement(ElementName = "Ack")]
		public string? Ack { get; set; }

		[XmlElement(ElementName = "Version")]
		public int Version { get; set; }

		[XmlElement(ElementName = "Build")]
		public string? Build { get; set; }

		[XmlElement(ElementName = "PaginationResult")]
		public PaginationResultL PaginationResult { get; set; }

		[XmlElement(ElementName = "HasMoreItems")]
		public bool HasMoreItems { get; set; }

		[XmlElement(ElementName = "ItemArray")]
		public ItemArrayL? ItemArray { get; set; }

		[XmlElement(ElementName = "ItemsPerPage")]
		public int ItemsPerPage { get; set; }

		[XmlElement(ElementName = "PageNumber")]
		public int PageNumber { get; set; }

		[XmlElement(ElementName = "ReturnedItemCountActual")]
		public int ReturnedItemCountActual { get; set; }

		[XmlElement(ElementName = "Seller")]
		public Seller? Seller { get; set; }

		[XmlAttribute(AttributeName = "xmlns")]
		public string? Xmlns { get; set; }

		[XmlText]
		public string? Text { get; set; }
	}
}
