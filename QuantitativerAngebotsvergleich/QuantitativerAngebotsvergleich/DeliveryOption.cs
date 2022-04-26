using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantitativerAngebotsvergleich
{
    public class DeliveryOptionUtils
    {
        public static double GetDiscountFromDeliveryOption(DeliveryOption deliveryOption)
        {
            switch (deliveryOption)
            {
                case DeliveryOption.DHL:
                    {
                        return 0;
                    }
                case DeliveryOption.Hermes:
                    {
                        return 0.01;
                    }
                case DeliveryOption.DPD:
                    {
                        return 0.02;
                    }
                case DeliveryOption.PickUp:
                    {
                        return 0.05;
                    }
            }

            return 0;
        }

        public static List<DeliveryOption> GetPossibleDeliveryOptions()
        {
            DeliveryOption[] deliveryOptions = (DeliveryOption[])Enum.GetValues(typeof(DeliveryOption));
            List<DeliveryOption> possibleDeliveryOptions = new List<DeliveryOption>(deliveryOptions);

            return possibleDeliveryOptions;
        }

        public static List<DeliveryOptionDetails> GetPossibleDeliveryOptionDetails()
        {
            List<DeliveryOption> options = GetPossibleDeliveryOptions();
            List<DeliveryOptionDetails> possibleDeliveryOptionsDetails = new List<DeliveryOptionDetails>();

            foreach(DeliveryOption option in options)
            {
                possibleDeliveryOptionsDetails.Add(new() { DeliveryOption = option, Discount = GetDiscountFromDeliveryOption(option) });
            }

            return possibleDeliveryOptionsDetails;
        }
    }

    public class DeliveryOptionDetails {
        public DeliveryOption DeliveryOption { get; set; }
        public double Discount { get; set; }
        public string Label { get => $"{DeliveryOption} ({Discount * 100}%)"; }
    }

    public enum DeliveryOption
    {
        DHL,
        Hermes,
        DPD,
        PickUp
    }
}
