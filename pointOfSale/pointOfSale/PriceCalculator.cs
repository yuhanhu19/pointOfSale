using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace pointOfSale
{
    public class PriceCalculator
    {
        public string GetPrice(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                throw new Exception("Error: empty barcode");
            }

            switch (barcode)
            {
                case "12345":
                    return "$7.25";
                case "23456":
                    return "$12.50";
                default:
                    throw new Exception("Error: barcode not found");
            }
        }

        public float Total(string barcodes)
        {
            var priceList = barcodes.Split(',').Select(barcode => GetPrice(barcode.Trim())).ToList();
            return priceList.Select(price => float.Parse(price.TrimStart('$'))).ToList().Sum();
        }
    }
}