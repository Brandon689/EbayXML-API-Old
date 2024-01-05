using System.Xml.Serialization;
using System.Collections.Generic;

namespace Multi_Platform_ECommerce.Ebay.Network
{
	[XmlRoot(ElementName = "AdjustmentAmount")]
	public class AdjustmentAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "AmountPaid")]
	public class AmountPaid
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "AmountSaved")]
	public class AmountSaved
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Buyer")]
	public class Buyer
	{
		[XmlElement(ElementName = "Email")]
		public string? Email { get; set; }
		[XmlElement(ElementName = "StaticAlias")]
		public string? StaticAlias { get; set; }
		[XmlElement(ElementName = "UserFirstName")]
		public string? UserFirstName { get; set; }
		[XmlElement(ElementName = "UserLastName")]
		public string? UserLastName { get; set; }
		[XmlElement(ElementName = "VATStatus")]
		public string? VATStatus { get; set; }
	}

	[XmlRoot(ElementName = "CheckoutStatus")]
	public class CheckoutStatus
	{
		[XmlElement(ElementName = "eBayPaymentStatus")]
		public string? EBayPaymentStatus { get; set; }
		[XmlElement(ElementName = "IntegratedMerchantCreditCardEnabled")]
		public string? IntegratedMerchantCreditCardEnabled { get; set; }
		[XmlElement(ElementName = "LastModifiedTime")]
		public string? LastModifiedTime { get; set; }
		[XmlElement(ElementName = "PaymentInstrument")]
		public string? PaymentInstrument { get; set; }
		[XmlElement(ElementName = "PaymentMethod")]
		public string? PaymentMethod { get; set; }
		[XmlElement(ElementName = "Status")]
		public string? Status { get; set; }
	}

	[XmlRoot(ElementName = "ExternalTransaction")]
	public class ExternalTransaction
	{
		[XmlElement(ElementName = "ExternalTransactionID")]
		public string? ExternalTransactionID { get; set; }
		[XmlElement(ElementName = "ExternalTransactionStatus")]
		public string? ExternalTransactionStatus { get; set; }
		[XmlElement(ElementName = "ExternalTransactionTime")]
		public string? ExternalTransactionTime { get; set; }
		[XmlElement(ElementName = "FeeOrCreditAmount")]
		public FeeOrCreditAmount FeeOrCreditAmount { get; set; }
		[XmlElement(ElementName = "PaymentOrRefundAmount")]
		public PaymentOrRefundAmount PaymentOrRefundAmount { get; set; }
	}

	[XmlRoot(ElementName = "FeeOrCreditAmount")]
	public class FeeOrCreditAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "GetOrdersResponse")]
	public class GetOrdersResponse
	{
		[XmlElement(ElementName = "Ack")]
		public string? Ack { get; set; }
		[XmlElement(ElementName = "Build")]
		public string? Build { get; set; }
		[XmlElement(ElementName = "HasMoreOrders")]
		public string? HasMoreOrders { get; set; }
		[XmlElement(ElementName = "OrderArray")]
		public OrderArray OrderArray { get; set; }
		[XmlElement(ElementName = "OrdersPerPage")]
		public string? OrdersPerPage { get; set; }
		[XmlElement(ElementName = "PageNumber")]
		public string? PageNumber { get; set; }
		[XmlElement(ElementName = "PaginationResult")]
		public PaginationResult PaginationResult { get; set; }
		[XmlElement(ElementName = "ReturnedOrderCountActual")]
		public string? ReturnedOrderCountActual { get; set; }
		[XmlElement(ElementName = "Timestamp")]
		public string? Timestamp { get; set; }
		[XmlElement(ElementName = "Version")]
		public string? Version { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string? Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "Item")]
	public class ItemO
	{
		[XmlElement(ElementName = "ConditionDisplayName")]
		public string? ConditionDisplayName { get; set; }
		[XmlElement(ElementName = "ConditionID")]
		public string? ConditionID { get; set; }
		[XmlElement(ElementName = "ItemID")]
		public string? ItemID { get; set; }
		[XmlElement(ElementName = "Site")]
		public string? Site { get; set; }
		[XmlElement(ElementName = "SKU")]
		public string? SKU { get; set; }
		[XmlElement(ElementName = "Title")]
		public string? Title { get; set; }
	}

	[XmlRoot(ElementName = "ItemDiscountAmount")]
	public class ItemDiscountAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "MonetaryDetails")]
	public class MonetaryDetails
	{
		[XmlElement(ElementName = "Payments")]
		public Payments Payments { get; set; }
		[XmlElement(ElementName = "Refunds")]
		public Refunds Refunds { get; set; }
	}

	[XmlRoot(ElementName = "NameValueList")]
	public class NameValueList
	{
		[XmlElement(ElementName = "Name")]
		public string? Name { get; set; }
		[XmlElement(ElementName = "Value")]
		public string? Value { get; set; }
	}

	[XmlRoot(ElementName = "Order")]
	public class Order
	{
		[XmlElement(ElementName = "AdjustmentAmount")]
		public AdjustmentAmount AdjustmentAmount { get; set; }
		[XmlElement(ElementName = "AmountPaid")]
		public AmountPaid AmountPaid { get; set; }
		[XmlElement(ElementName = "AmountSaved")]
		public AmountSaved AmountSaved { get; set; }
		[XmlElement(ElementName = "BundlePurchase")]
		public string? BundlePurchase { get; set; }
		[XmlElement(ElementName = "BuyerCheckoutMessage")]
		public string? BuyerCheckoutMessage { get; set; }
		[XmlElement(ElementName = "BuyerUserID")]
		public string? BuyerUserID { get; set; }
		[XmlElement(ElementName = "CancelStatus")]
		public string? CancelStatus { get; set; }
		[XmlElement(ElementName = "CheckoutStatus")]
		public CheckoutStatus CheckoutStatus { get; set; }
		[XmlElement(ElementName = "ContainseBayPlusTransaction")]
		public string? ContainseBayPlusTransaction { get; set; }
		[XmlElement(ElementName = "CreatedTime")]
		public string? CreatedTime { get; set; }
		[XmlElement(ElementName = "CreatingUserRole")]
		public string? CreatingUserRole { get; set; }
		[XmlElement(ElementName = "eBayCollectAndRemitTax")]
		public string? EBayCollectAndRemitTax { get; set; }
		[XmlElement(ElementName = "EIASToken")]
		public string? EIASToken { get; set; }
		[XmlElement(ElementName = "ExtendedOrderID")]
		public string? ExtendedOrderID { get; set; }
		[XmlElement(ElementName = "ExternalTransaction")]
		public List<ExternalTransaction> ExternalTransaction { get; set; }
		[XmlElement(ElementName = "IntegratedMerchantCreditCardEnabled")]
		public string? IntegratedMerchantCreditCardEnabled { get; set; }
		[XmlElement(ElementName = "IsMultiLegShipping")]
		public string? IsMultiLegShipping { get; set; }
		[XmlElement(ElementName = "MonetaryDetails")]
		public MonetaryDetails MonetaryDetails { get; set; }
		[XmlElement(ElementName = "OrderID")]
		public string? OrderID { get; set; }
		[XmlElement(ElementName = "OrderStatus")]
		public string? OrderStatus { get; set; }
		[XmlElement(ElementName = "PaidTime")]
		public string? PaidTime { get; set; }
		[XmlElement(ElementName = "PaymentHoldStatus")]
		public string? PaymentHoldStatus { get; set; }
		[XmlElement(ElementName = "SellerEIASToken")]
		public string? SellerEIASToken { get; set; }
		[XmlElement(ElementName = "SellerEmail")]
		public string? SellerEmail { get; set; }
		[XmlElement(ElementName = "SellerUserID")]
		public string? SellerUserID { get; set; }
		[XmlElement(ElementName = "ShippedTime")]
		public string? ShippedTime { get; set; }
		[XmlElement(ElementName = "ShippingAddress")]
		public ShippingAddress ShippingAddress { get; set; }
		[XmlElement(ElementName = "ShippingDetails")]
		public ShippingDetailsO ShippingDetails { get; set; }
		[XmlElement(ElementName = "ShippingServiceSelected")]
		public ShippingServiceSelected ShippingServiceSelected { get; set; }
		[XmlElement(ElementName = "Subtotal")]
		public Subtotal Subtotal { get; set; }
		[XmlElement(ElementName = "Total")]
		public Total Total { get; set; }
		[XmlElement(ElementName = "TransactionArray")]
		public TransactionArray TransactionArray { get; set; }
	}

	[XmlRoot(ElementName = "OrderArray")]
	public class OrderArray
	{
		[XmlElement(ElementName = "Order")]
		public List<Order> Order { get; set; }
	}

	[XmlRoot(ElementName = "OriginalItemPrice")]
	public class OriginalItemPrice
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "OriginalItemShippingCost")]
	public class OriginalItemShippingCost
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Payee")]
	public class Payee
	{
		[XmlText]
		public string? Text { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string? Type { get; set; }
	}

	[XmlRoot(ElementName = "Payer")]
	public class Payer
	{
		[XmlText]
		public string? Text { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string? Type { get; set; }
	}

	[XmlRoot(ElementName = "Payment")]
	public class Payment
	{
		[XmlElement(ElementName = "FeeOrCreditAmount")]
		public FeeOrCreditAmount FeeOrCreditAmount { get; set; }
		[XmlElement(ElementName = "Payee")]
		public Payee Payee { get; set; }
		[XmlElement(ElementName = "Payer")]
		public Payer Payer { get; set; }
		[XmlElement(ElementName = "PaymentAmount")]
		public PaymentAmount PaymentAmount { get; set; }
		[XmlElement(ElementName = "PaymentStatus")]
		public string? PaymentStatus { get; set; }
		[XmlElement(ElementName = "PaymentTime")]
		public string? PaymentTime { get; set; }
		[XmlElement(ElementName = "ReferenceID")]
		public ReferenceID ReferenceID { get; set; }
	}

	[XmlRoot(ElementName = "PaymentAmount")]
	public class PaymentAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "PaymentOrRefundAmount")]
	public class PaymentOrRefundAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Payments")]
	public class Payments
	{
		[XmlElement(ElementName = "Payment")]
		public Payment Payment { get; set; }
	}

	[XmlRoot(ElementName = "ReferenceID")]
	public class ReferenceID
	{
		[XmlText]
		public string? Text { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string? Type { get; set; }
	}

	[XmlRoot(ElementName = "Refund")]
	public class Refund
	{
		[XmlElement(ElementName = "FeeOrCreditAmount")]
		public FeeOrCreditAmount FeeOrCreditAmount { get; set; }
		[XmlElement(ElementName = "ReferenceID")]
		public ReferenceID ReferenceID { get; set; }
		[XmlElement(ElementName = "RefundAmount")]
		public RefundAmount RefundAmount { get; set; }
		[XmlElement(ElementName = "RefundStatus")]
		public string? RefundStatus { get; set; }
		[XmlElement(ElementName = "RefundTime")]
		public string? RefundTime { get; set; }
		[XmlElement(ElementName = "RefundTo")]
		public RefundTo RefundTo { get; set; }
		[XmlElement(ElementName = "RefundType")]
		public string? RefundType { get; set; }
	}

	[XmlRoot(ElementName = "RefundAmount")]
	public class RefundAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Refunds")]
	public class Refunds
	{
		[XmlElement(ElementName = "Refund")]
		public Refund Refund { get; set; }
	}

	[XmlRoot(ElementName = "RefundTo")]
	public class RefundTo
	{
		[XmlText]
		public string? Text { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string? Type { get; set; }
	}

	[XmlRoot(ElementName = "SalesTax")]
	public class SalesTaxO
	{
		[XmlElement(ElementName = "SalesTaxAmount")]
		public SalesTaxAmount SalesTaxAmount { get; set; }
		[XmlElement(ElementName = "SalesTaxPercent")]
		public string? SalesTaxPercent { get; set; }
		[XmlElement(ElementName = "SalesTaxState")]
		public string? SalesTaxState { get; set; }
		[XmlElement(ElementName = "ShippingIncludedInTax")]
		public string? ShippingIncludedInTax { get; set; }
	}

	[XmlRoot(ElementName = "SalesTaxAmount")]
	public class SalesTaxAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "SellerDiscount")]
	public class SellerDiscount
	{
		[XmlElement(ElementName = "CampaignDisplayName")]
		public string? CampaignDisplayName { get; set; }
		[XmlElement(ElementName = "CampaignID")]
		public string? CampaignID { get; set; }
		[XmlElement(ElementName = "ItemDiscountAmount")]
		public ItemDiscountAmount ItemDiscountAmount { get; set; }
	}

	[XmlRoot(ElementName = "SellerDiscounts")]
	public class SellerDiscounts
	{
		[XmlElement(ElementName = "OriginalItemPrice")]
		public OriginalItemPrice OriginalItemPrice { get; set; }
		[XmlElement(ElementName = "OriginalItemShippingCost")]
		public OriginalItemShippingCost OriginalItemShippingCost { get; set; }
		[XmlElement(ElementName = "OriginalShippingService")]
		public string? OriginalShippingService { get; set; }
		[XmlElement(ElementName = "SellerDiscount")]
		public SellerDiscount SellerDiscount { get; set; }
	}

	[XmlRoot(ElementName = "ShippingAddress")]
	public class ShippingAddress
	{
		[XmlElement(ElementName = "AddressID")]
		public string? AddressID { get; set; }
		[XmlElement(ElementName = "AddressOwner")]
		public string? AddressOwner { get; set; }
		[XmlElement(ElementName = "CityName")]
		public string? CityName { get; set; }
		[XmlElement(ElementName = "Country")]
		public string? Country { get; set; }
		[XmlElement(ElementName = "CountryName")]
		public string? CountryName { get; set; }
		[XmlElement(ElementName = "ExternalAddressID")]
		public string? ExternalAddressID { get; set; }
		[XmlElement(ElementName = "Name")]
		public string? Name { get; set; }
		[XmlElement(ElementName = "Phone")]
		public string? Phone { get; set; }
		[XmlElement(ElementName = "PostalCode")]
		public string? PostalCode { get; set; }
		[XmlElement(ElementName = "StateOrProvince")]
		public string? StateOrProvince { get; set; }
		[XmlElement(ElementName = "Street1")]
		public string? Street1 { get; set; }
		[XmlElement(ElementName = "Street2")]
		public string? Street2 { get; set; }
	}

	[XmlRoot(ElementName = "ShippingDetails")]
	public class ShippingDetailsO
	{
		[XmlElement(ElementName = "GetItFast")]
		public string? GetItFast { get; set; }
		[XmlElement(ElementName = "SalesTax")]
		public SalesTaxO SalesTax { get; set; }
		[XmlElement(ElementName = "SellingManagerSalesRecordNumber")]
		public string? SellingManagerSalesRecordNumber { get; set; }
		[XmlElement(ElementName = "ShippingServiceOptions")]
		public List<ShippingServiceOptionsO> ShippingServiceOptions { get; set; }
	}

	[XmlRoot(ElementName = "ShippingPackageInfo")]
	public class ShippingPackageInfo
	{
		[XmlElement(ElementName = "EstimatedDeliveryTimeMax")]
		public string? EstimatedDeliveryTimeMax { get; set; }
		[XmlElement(ElementName = "EstimatedDeliveryTimeMin")]
		public string? EstimatedDeliveryTimeMin { get; set; }
		[XmlElement(ElementName = "HandleByTime")]
		public string? HandleByTime { get; set; }
		[XmlElement(ElementName = "MaxNativeEstimatedDeliveryTime")]
		public string? MaxNativeEstimatedDeliveryTime { get; set; }
		[XmlElement(ElementName = "MinNativeEstimatedDeliveryTime")]
		public string? MinNativeEstimatedDeliveryTime { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceOptions")]
	public class ShippingServiceOptionsO
	{
		[XmlElement(ElementName = "ExpeditedService")]
		public string? ExpeditedService { get; set; }
		[XmlElement(ElementName = "ShippingService")]
		public string? ShippingService { get; set; }
		[XmlElement(ElementName = "ShippingServiceCost")]
		public ShippingServiceCost ShippingServiceCost { get; set; }
		[XmlElement(ElementName = "ShippingServicePriority")]
		public string? ShippingServicePriority { get; set; }
		[XmlElement(ElementName = "ShippingTimeMax")]
		public string? ShippingTimeMax { get; set; }
		[XmlElement(ElementName = "ShippingTimeMin")]
		public string? ShippingTimeMin { get; set; }
	}

	[XmlRoot(ElementName = "ShippingServiceSelected")]
	public class ShippingServiceSelected
	{
		[XmlElement(ElementName = "ShippingPackageInfo")]
		public ShippingPackageInfo ShippingPackageInfo { get; set; }
		[XmlElement(ElementName = "ShippingService")]
		public string? ShippingService { get; set; }
		[XmlElement(ElementName = "ShippingServiceCost")]
		public ShippingServiceCost ShippingServiceCost { get; set; }
	}

	[XmlRoot(ElementName = "Status")]
	public class Status
	{
		[XmlElement(ElementName = "InquiryStatus")]
		public string? InquiryStatus { get; set; }
		[XmlElement(ElementName = "PaymentHoldStatus")]
		public string? PaymentHoldStatus { get; set; }
		[XmlElement(ElementName = "ReturnStatus")]
		public string? ReturnStatus { get; set; }
	}

	[XmlRoot(ElementName = "Subtotal")]
	public class Subtotal
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "TaxAmount")]
	public class TaxAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "TaxDetails")]
	public class TaxDetails
	{
		[XmlElement(ElementName = "Imposition")]
		public string? Imposition { get; set; }
		[XmlElement(ElementName = "TaxAmount")]
		public TaxAmount TaxAmount { get; set; }
		[XmlElement(ElementName = "TaxDescription")]
		public string? TaxDescription { get; set; }
		[XmlElement(ElementName = "TaxOnHandlingAmount")]
		public TaxOnHandlingAmount TaxOnHandlingAmount { get; set; }
		[XmlElement(ElementName = "TaxOnShippingAmount")]
		public TaxOnShippingAmount TaxOnShippingAmount { get; set; }
		[XmlElement(ElementName = "TaxOnSubtotalAmount")]
		public TaxOnSubtotalAmount TaxOnSubtotalAmount { get; set; }
	}

	[XmlRoot(ElementName = "Taxes")]
	public class Taxes
	{
		[XmlElement(ElementName = "TaxDetails")]
		public TaxDetails TaxDetails { get; set; }
		[XmlElement(ElementName = "TotalTaxAmount")]
		public TotalTaxAmount TotalTaxAmount { get; set; }
	}

	[XmlRoot(ElementName = "TaxOnHandlingAmount")]
	public class TaxOnHandlingAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "TaxOnShippingAmount")]
	public class TaxOnShippingAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "TaxOnSubtotalAmount")]
	public class TaxOnSubtotalAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Total")]
	public class Total
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "TotalTaxAmount")]
	public class TotalTaxAmount
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Transaction")]
	public class Transaction
	{
		[XmlElement(ElementName = "BundlePurchase")]
		public string? BundlePurchase { get; set; }
		[XmlElement(ElementName = "Buyer")]
		public Buyer Buyer { get; set; }
		[XmlElement(ElementName = "CreatedDate")]
		public string? CreatedDate { get; set; }
		[XmlElement(ElementName = "eBayCollectAndRemitTax")]
		public string? EBayCollectAndRemitTax { get; set; }
		[XmlElement(ElementName = "eBayPlusTransaction")]
		public string? EBayPlusTransaction { get; set; }
		[XmlElement(ElementName = "ExtendedOrderID")]
		public string? ExtendedOrderID { get; set; }
		[XmlElement(ElementName = "GuaranteedDelivery")]
		public string? GuaranteedDelivery { get; set; }
		[XmlElement(ElementName = "GuaranteedShipping")]
		public string? GuaranteedShipping { get; set; }
		[XmlElement(ElementName = "Item")]
		public ItemO Item { get; set; }
		[XmlElement(ElementName = "OrderLineItemID")]
		public string? OrderLineItemID { get; set; }
		[XmlElement(ElementName = "Platform")]
		public string? Platform { get; set; }
		[XmlElement(ElementName = "QuantityPurchased")]
		public string? QuantityPurchased { get; set; }
		[XmlElement(ElementName = "SellerDiscounts")]
		public SellerDiscounts SellerDiscounts { get; set; }
		[XmlElement(ElementName = "ShippedTime")]
		public string? ShippedTime { get; set; }
		[XmlElement(ElementName = "ShippingDetails")]
		public ShippingDetails ShippingDetails { get; set; }
		[XmlElement(ElementName = "ShippingServiceSelected")]
		public ShippingServiceSelected ShippingServiceSelected { get; set; }
		[XmlElement(ElementName = "Status")]
		public Status Status { get; set; }
		[XmlElement(ElementName = "Taxes")]
		public Taxes Taxes { get; set; }
		[XmlElement(ElementName = "TransactionID")]
		public string? TransactionID { get; set; }
		[XmlElement(ElementName = "TransactionPrice")]
		public TransactionPrice TransactionPrice { get; set; }
		[XmlElement(ElementName = "TransactionSiteID")]
		public string? TransactionSiteID { get; set; }
		[XmlElement(ElementName = "Variation")]
		public VariationB Variation { get; set; }
	}

	[XmlRoot(ElementName = "TransactionArray")]
	public class TransactionArray
	{
		[XmlElement(ElementName = "Transaction")]
		public List<Transaction> Transaction { get; set; }
	}

	[XmlRoot(ElementName = "TransactionPrice")]
	public class TransactionPrice
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string? CurrencyID { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Variation")]
	public class VariationB
	{
		[XmlElement(ElementName = "VariationSpecifics")]
		public VariationSpecifics VariationSpecifics { get; set; }
		[XmlElement(ElementName = "VariationTitle")]
		public string? VariationTitle { get; set; }
		[XmlElement(ElementName = "VariationViewItemURL")]
		public string? VariationViewItemURL { get; set; }
	}

	[XmlRoot(ElementName = "VariationSpecifics")]
	public class VariationSpecifics
	{
		[XmlElement(ElementName = "NameValueList")]
		public NameValueList NameValueList { get; set; }
	}

}
