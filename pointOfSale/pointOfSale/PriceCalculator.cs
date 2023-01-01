using System;

namespace pointOfSale
{
    public class PriceCalculator
    {
        public string GetPrice(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                return "Error: empty barcode";
            }
            if (barcode.Equals("12345"))
            {
                return "$7.25";
            }

            if (barcode.Equals("23456"))
            {
                return "$12.50";
            }
            
            throw new Exception("Error: barcode not found");
        }
        
        
    }
}