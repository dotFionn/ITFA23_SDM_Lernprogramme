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
        
        // calculated Values
        public double DiscountAmount { get => ListPrice * Discount;  }
        public double PriceTargetPurchase { get => ListPrice - DiscountAmount; }
        public double EarlyPayDiscountAmount { get => PriceTargetPurchase * EarlyPayDiscount; }
        public double PriceEarlyPayDiscount { get => PriceTargetPurchase - EarlyPayDiscountAmount; }
        public double PriceDelivered { get => PriceTargetPurchase + DeliveryFee; }
    }
}
