using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantitativerAngebotsvergleich
{
    public class Offer
    {
        public string Label { get; set; } = "";

        public int offerId { get; set; } = -1;

        // given Values
        public double ListPrice { get; set; }
        public double Discount { get; set; }
        public double EarlyPayDiscount { get; set; }
        public double DeliveryFee { get; set; }
        public DeliveryOption DeliveryOption { get; set; }

        // calculated Values
        public double DiscountAmount { get => Math.Round(ListPrice * Discount, 2); }
        public double PriceTargetPurchase { get => Math.Round(ListPrice - DiscountAmount, 2); }
        public double EarlyPayDiscountAmount { get => Math.Round(PriceTargetPurchase * EarlyPayDiscount, 2); }
        public double PriceEarlyPayDiscount { get => Math.Round(PriceTargetPurchase - EarlyPayDiscountAmount, 2); }
        private double PriceDeliveredPreDiscount { get => Math.Round(PriceEarlyPayDiscount + DeliveryFee, 2); }
        private double DiscountFromDeliveryOption { get => DeliveryOptionUtils.GetDiscountFromDeliveryOption(DeliveryOption); }
        public double DiscountAmountFromDeliveryOption { get => Math.Round(PriceDeliveredPreDiscount * DiscountFromDeliveryOption); }
        public double PriceDelivered { get => Math.Round(PriceDeliveredPreDiscount - DiscountAmountFromDeliveryOption); }
    }
}
