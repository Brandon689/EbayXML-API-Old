using ECommerce.Database.DTO;
using Multi_Platform_ECommerce.Ebay.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Multi_Platform_ECommerce.Ebay
{
    public class EbayUtil
    {
        public static bool ValidImgSize(string img)
        {
            using (var imageStream = File.OpenRead(img))
            {
                BitmapDecoder decoder = BitmapDecoder.Create(imageStream, BitmapCreateOptions.IgnoreColorProfile,
                    BitmapCacheOption.Default);

                if (decoder.Frames[0].PixelHeight >= 500 && decoder.Frames[0].PixelWidth >= 500)
                    return true;
            }
            return false;
        }

        public static EbayOrder Into(Order o)
        {
            EbayOrder order = new();
            order.OrderId = o.OrderID;
            //order.ShippingServiceCost = Convert.ToDouble(o.ShippingDetails.ShippingServiceOptions[0].ShippingServiceCost.Text);
            //order.OrderStatus = o.OrderStatus;
            //order.SubTotal = Convert.ToDouble(o.Subtotal.Text);
            order.TotalPaid = Convert.ToDecimal(o.Total.Text);
            order.OrderDate = DateTime.Parse(o.CreatedTime);
            //order.BuyerUserId = o.BuyerUserID;
            //order.PaidTime = Utilities.DateToUnix(o.PaidTime);
            //order.ShippingService = o.ShippingServiceSelected.ShippingService;
            //order.AmountSaved = Convert.ToDouble(o.AmountSaved.Text);
            //order.PaymentMethod = o.CheckoutStatus.PaymentMethod;
            //order.ShippingTimeMin = int.Parse(o.ShippingDetails.ShippingServiceOptions[0].ShippingTimeMin);
            //order.ShippingTimeMax = int.Parse(o.ShippingDetails.ShippingServiceOptions[0].ShippingTimeMax);
            return order;
        }

        public static EbayAddress IntoAddress(Order o)
        {
            if (o.ShippingAddress == null)
            {
                return null; // RAISE ERORR PLS
            }    
            EbayAddress ea = new()
            {
                Name = o.ShippingAddress.Name,
                OrderId = o.OrderID,
                Street1 = o.ShippingAddress.Street1,
                Street2 = o.ShippingAddress.Street2,
                CityName = o.ShippingAddress.CityName,
                StateOrProvince = o.ShippingAddress.StateOrProvince,
                PostalCode = o.ShippingAddress.PostalCode,
                CountryName = o.ShippingAddress.CountryName,
                County = o.ShippingAddress.Country
            };
            return ea;
        }

        public static bool IsVariationFromSKU(string sku)
        {
            var spl = sku.Split('|');
            foreach (var ig in spl)
            {
                if (ig == "VAR")
                {
                    return true;
                }
            }
            return false;
        }

        public static List<EbayOrderItem> IntoItem(Order o)
        {
            List<EbayOrderItem> list = new List<EbayOrderItem>();
            for (int i = 0; i < o.TransactionArray.Transaction.Count; i++)
            {
                var t = o.TransactionArray.Transaction[i];

                EbayOrderItem order = new EbayOrderItem();
                order.OrderId = o.OrderID;
                order.Title = t.Item.Title;
                order.SKU = t.Item.SKU;
                order.QuantityPurchased = int.Parse(t.QuantityPurchased);
                order.Condition = 0;
                order.AmountPaid = Convert.ToDouble(t.TransactionPrice.Text);
                if (t.SellerDiscounts != null)
                {
                    order.OriginalPrice = Convert.ToDouble(t.SellerDiscounts.OriginalItemPrice.Text);
                    order.SellerDiscount = Convert.ToDouble(t.SellerDiscounts.SellerDiscount.ItemDiscountAmount.Text);
                }
                else
                {
                    order.OriginalPrice = order.AmountPaid;
                }

                if (t.Item.ConditionID != "1000")
                    order.Condition = 1;
                order.ProductID = t.Item.ItemID;
                //if (string.IsNullOrEmpty(order.SKU) == false)
                //{
                //    order.InventoryId = EbayUtil.SKUToInvId(order.SKU);
                //}
                order.Price = Convert.ToDouble(t.TransactionPrice.Text);
                order.CreatedDate = DateTime.Parse(t.CreatedDate); //Utilities.DateToUnix(t.CreatedDate);
                list.Add(order);
            }
            return list;
        }

        // iteml is from getmyselling
        public static EbayInv LIntoInv(ItemL l)
        {
            EbayInv s = new();
            s.ProductId = (long)l.ItemID; //long.Parse(l.ItemID);
            s.SKU = l.SKU;
            s.Qty = l.Quantity;
            s.SellingPrice = Convert.ToDecimal(l.BuyItNowPrice.Text);
            s.ListingTitle = l.Title;
            //s.QuantitySold = int.Parse(l.Quantity);
            return s;
        }

        //getitem
        public static EbayInv SIntoInvNoVar(ItemS l)
        {
            EbayInv s = new();
            s.ProductId = long.Parse(l.ItemID);
            s.SKU = l.SKU;
            s.Qty = int.Parse(l.Quantity);
            s.SellingPrice = Convert.ToDecimal(l.BuyItNowPrice.Text);
            s.ListingTitle = l.Title;
            
            //s.QuantitySold = int.Parse(l.Quantity);
            return s;
        }

        public static List<EbayInv> SIntoInvWithVar(ItemS l)
        {
            List<EbayInv> s = new();

            for (int i = 0; i < l.Variations.Variation.Count; i++)
            {
                EbayInv si = new();
                si.ProductId = long.Parse(l.ItemID);
                si.SKU = l.Variations.Variation[i].SKU;
                si.Qty = int.Parse(l.Quantity);
                si.SellingPrice = Convert.ToDecimal(l.Variations.Variation[i].StartPrice.Text);
                si.ListingTitle = l.Title;
                si.VariationValue = l.Variations.Variation[i].VariationSpecifics.NameValueList.Value;
                si.VariationName = l.Variations.Variation[i].VariationSpecifics.NameValueList.Name;
                si.VariationId = 1 + i;
                si.IsVariationListing = true;
                s.Add(si);
            }
            //s.QuantitySold = int.Parse(l.Quantity);
            return s;
        }

        //item is from getsellerlist
        public static EbayInv IntoInv(Item l)
        {
            EbayInv s = new();
            s.ProductId = long.Parse(l.ItemID);
            s.SKU = l.SKU;
            s.Qty = int.Parse(l.QuantityAvailable);
            s.SellingPrice = Convert.ToDecimal(l.BuyItNowPrice.Text);
            s.ListingTitle = l.Title;
            if (l.Quantity != null)
            {
                s.QuantitySold = int.Parse(l.Quantity);
            }
            return s;
        }
    }
}
