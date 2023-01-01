using System;
using Xunit;

namespace pointOfSale
{
    public class Tests
    {
        [Fact]
        public void ShouldReturnPriceGivenBarcode12345()
        {
            var priceCalculator = new PriceCalculator();
            var priceResult = priceCalculator.GetPrice("12345");
            Assert.Equal("$7.25", priceResult);
        }
    }
}