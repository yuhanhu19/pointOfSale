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

            return null;
        }
    }
}