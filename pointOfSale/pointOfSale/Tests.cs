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
        
        [Fact]
        public void ShouldReturnPriceGivenBarcode23456()
        {
            var priceCalculator = new PriceCalculator();
            var priceResult = priceCalculator.GetPrice("23456");
            Assert.Equal("$12.50", priceResult);
        }
        
        [Fact]
        public void ShouldReturnNotFoundMessageGivenBarcode99999()
        {
            var priceCalculator = new PriceCalculator();
            var priceResult = priceCalculator.GetPrice("99999");
            Assert.Equal("Error: barcode not found", priceResult);
        }
        
        [Fact]
        public void ShouldReturnEmptyCodeMessageGivenEmptyBarcode()
        {
            var priceCalculator = new PriceCalculator();
            var priceResult = priceCalculator.GetPrice("");
            Assert.Equal("Error: empty barcode", priceResult);
        }
    }
}