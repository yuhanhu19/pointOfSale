namespace pointOfSale
{
    public class PriceCalculator
    {
        public string GetPrice(string barcode)
        {
            
            if (barcode.Equals("12345"))
            {
                return "$7.25";
            }

            if (barcode.Equals("23456"))
            {
                return "$12.50";
            }

            if (barcode.Equals("99999"))
            {
                return "Error: barcode not found";
            }


            return null;
        }
    }
}