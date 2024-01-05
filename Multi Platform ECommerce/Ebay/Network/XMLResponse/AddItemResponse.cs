using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network.XMLResponse
{
	/* 
	 Licensed under the Apache License, Version 2.0

	 http://www.apache.org/licenses/LICENSE-2.0
	 */
	using System;
	using System.Xml.Serialization;
	using System.Collections.Generic;

	namespace Xml2CSharp
	{
		[XmlRoot(ElementName = "AddFixedPriceItemResponse")]
		public class AddFixedPriceItemResponse
		{
			[XmlElement(ElementName = "Ack")]
			public string Ack { get; set; }
			[XmlElement(ElementName = "Build")]
			public string Build { get; set; }
			[XmlElement(ElementName = "DiscountReason")]
			public string DiscountReason { get; set; }
			[XmlElement(ElementName = "EndTime")]
			public string EndTime { get; set; }
			[XmlElement(ElementName = "Errors")]
			public List<Errors> Errors { get; set; }
			[XmlElement(ElementName = "Fees")]
			public Fees Fees { get; set; }
			[XmlElement(ElementName = "ItemID")]
			public string ItemID { get; set; }
			[XmlElement(ElementName = "StartTime")]
			public string StartTime { get; set; }
			[XmlElement(ElementName = "Timestamp")]
			public string Timestamp { get; set; }
			[XmlElement(ElementName = "Version")]
			public string Version { get; set; }
			[XmlAttribute(AttributeName = "xmlns")]
			public string Xmlns { get; set; }
		}

		[XmlRoot(ElementName = "ErrorParameters")]
		public class ErrorParameters
		{
			[XmlAttribute(AttributeName = "ParamID")]
			public string ParamID { get; set; }
			[XmlElement(ElementName = "Value")]
			public string Value { get; set; }
		}

		[XmlRoot(ElementName = "Errors")]
		public class Errors
		{
			[XmlElement(ElementName = "ErrorClassification")]
			public string ErrorClassification { get; set; }
			[XmlElement(ElementName = "ErrorCode")]
			public string ErrorCode { get; set; }
			[XmlElement(ElementName = "ErrorParameters")]
			public ErrorParameters ErrorParameters { get; set; }
			[XmlElement(ElementName = "LongMessage")]
			public string LongMessage { get; set; }
			[XmlElement(ElementName = "SeverityCode")]
			public string SeverityCode { get; set; }
			[XmlElement(ElementName = "ShortMessage")]
			public string ShortMessage { get; set; }
		}

		[XmlRoot(ElementName = "Fee")]
		public class Feez
		{
			[XmlAttribute(AttributeName = "currencyID")]
			public string CurrencyID { get; set; }
			[XmlElement(ElementName = "Fee")]
			public Feez Fee { get; set; }
			[XmlElement(ElementName = "Name")]
			public string Name { get; set; }
			[XmlElement(ElementName = "PromotionalDiscount")]
			public PromotionalDiscount PromotionalDiscount { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "Fees")]
		public class Fees
		{
			[XmlElement(ElementName = "Fee")]
			public List<Feez> Fee { get; set; }
		}

		[XmlRoot(ElementName = "PromotionalDiscount")]
		public class PromotionalDiscount
		{
			[XmlAttribute(AttributeName = "currencyID")]
			public string CurrencyID { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

	}

}
