using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Multi_Platform_ECommerce.Ebay.Network
{
	[XmlRoot(ElementName = "BuyItNowPrice")]
	public class BuyItNowPrice
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string CurrencyID { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "ListingDetails")]
	public class ListingDetails
	{
		[XmlElement(ElementName = "StartTime")]
		public string StartTime { get; set; }
		[XmlElement(ElementName = "ViewItemURL")]
		public string ViewItemURL { get; set; }
		[XmlElement(ElementName = "ViewItemURLForNaturalSearch")]
		public string ViewItemURLForNaturalSearch { get; set; }
	}

	[XmlRoot(ElementName = "CurrentPrice")]
	public class CurrentPrice
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string CurrencyID { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "SellingStatus")]
	public class SellingStatus
	{
		[XmlElement(ElementName = "CurrentPrice")]
		public CurrentPrice CurrentPrice { get; set; }
		[XmlElement(ElementName = "QuantitySold")]
		public string QuantitySold { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceCost")]
	public class ShippingServiceCost
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string CurrencyID { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceOptions")]
	public class ShippingServiceOptions
	{
		[XmlElement(ElementName = "ShippingServiceCost")]
		public ShippingServiceCost ShippingServiceCost { get; set; }
	}

	[XmlRoot(ElementName = "ShippingDetails")]
	public class ShippingDetails
	{
		[XmlElement(ElementName = "ShippingServiceOptions")]
		public ShippingServiceOptions ShippingServiceOptions { get; set; }
		[XmlElement(ElementName = "ShippingType")]
		public string ShippingType { get; set; }
	}

	[XmlRoot(ElementName = "ClassifiedAdPayPerLeadFee")]
	public class ClassifiedAdPayPerLeadFee
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string CurrencyID { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "SellerShippingProfile")]
	public class SellerShippingProfile
	{
		[XmlElement(ElementName = "ShippingProfileID")]
		public string ShippingProfileID { get; set; }
		[XmlElement(ElementName = "ShippingProfileName")]
		public string ShippingProfileName { get; set; }
	}

	[XmlRoot(ElementName = "SellerReturnProfile")]
	public class SellerReturnProfile
	{
		[XmlElement(ElementName = "ReturnProfileID")]
		public string ReturnProfileID { get; set; }
		[XmlElement(ElementName = "ReturnProfileName")]
		public string ReturnProfileName { get; set; }
	}

	[XmlRoot(ElementName = "SellerPaymentProfile")]
	public class SellerPaymentProfile
	{
		[XmlElement(ElementName = "PaymentProfileID")]
		public string PaymentProfileID { get; set; }
		[XmlElement(ElementName = "PaymentProfileName")]
		public string PaymentProfileName { get; set; }
	}

	[XmlRoot(ElementName = "SellerProfiles")]
	public class SellerProfiles
	{
		[XmlElement(ElementName = "SellerShippingProfile")]
		public SellerShippingProfile SellerShippingProfile { get; set; }
		[XmlElement(ElementName = "SellerReturnProfile")]
		public SellerReturnProfile SellerReturnProfile { get; set; }
		[XmlElement(ElementName = "SellerPaymentProfile")]
		public SellerPaymentProfile SellerPaymentProfile { get; set; }
	}

	[XmlRoot(ElementName = "Item")]
	public class Item
	{
		[XmlElement(ElementName = "BuyItNowPrice")]
		public BuyItNowPrice BuyItNowPrice { get; set; }
		[XmlElement(ElementName = "ItemID")]
		public string ItemID { get; set; }
		[XmlElement(ElementName = "ListingDetails")]
		public ListingDetails ListingDetails { get; set; }
		[XmlElement(ElementName = "ListingDuration")]
		public string ListingDuration { get; set; }
		[XmlElement(ElementName = "ListingType")]
		public string ListingType { get; set; }
		[XmlElement(ElementName = "Quantity")]
		public string Quantity { get; set; }
		[XmlElement(ElementName = "SellingStatus")]
		public SellingStatus SellingStatus { get; set; }
		[XmlElement(ElementName = "ShippingDetails")]
		public ShippingDetails ShippingDetails { get; set; }
		[XmlElement(ElementName = "TimeLeft")]
		public string TimeLeft { get; set; }
		[XmlElement(ElementName = "Title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "WatchCount")]
		public string WatchCount { get; set; }
		[XmlElement(ElementName = "QuantityAvailable")]
		public string QuantityAvailable { get; set; }
		[XmlElement(ElementName = "PictureDetails")]
		public string PictureDetails { get; set; }
		[XmlElement(ElementName = "ClassifiedAdPayPerLeadFee")]
		public ClassifiedAdPayPerLeadFee ClassifiedAdPayPerLeadFee { get; set; }
		[XmlElement(ElementName = "SellerProfiles")]
		public SellerProfiles SellerProfiles { get; set; }
		[XmlElement(ElementName = "QuestionCount")]
		public string QuestionCount { get; set; }
		[XmlElement(ElementName = "SKU")]
		public string SKU { get; set; }
		[XmlElement(ElementName = "NewLeadCount")]
		public string NewLeadCount { get; set; }
	}

	[XmlRoot(ElementName = "ItemArray")]
	public class ItemArray
	{
		[XmlElement(ElementName = "Item")]
		public List<Item> Item { get; set; }
	}

	[XmlRoot(ElementName = "PaginationResult")]
	public class PaginationResult
	{
		[XmlElement(ElementName = "TotalNumberOfPages")]
		public string TotalNumberOfPages { get; set; }
		[XmlElement(ElementName = "TotalNumberOfEntries")]
		public string TotalNumberOfEntries { get; set; }
	}

	[XmlRoot(ElementName = "ActiveList")]
	public class ActiveList
	{
		[XmlElement(ElementName = "ItemArray")]
		public ItemArray ItemArray { get; set; }
		[XmlElement(ElementName = "PaginationResult")]
		public PaginationResult PaginationResult { get; set; }
	}

	[XmlRoot(ElementName = "GetMyeBaySellingResponse")]
	public class GetMyeBaySellingResponse
	{
		[XmlElement(ElementName = "Timestamp")]
		public string Timestamp { get; set; }
		[XmlElement(ElementName = "Ack")]
		public string Ack { get; set; }
		[XmlElement(ElementName = "Version")]
		public string Version { get; set; }
		[XmlElement(ElementName = "Build")]
		public string Build { get; set; }
		[XmlElement(ElementName = "ActiveList")]
		public ActiveList ActiveList { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

}
