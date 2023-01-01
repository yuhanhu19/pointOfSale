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
        public void ShouldReturnEmptyCodeMessageGivenEmptyBarcode()
        {
            var priceCalculator = new PriceCalculator();
            var ex = Assert.Throws<Exception>(()=>priceCalculator.GetPrice(""));
            Assert.Equal("Error: empty barcode", ex.Message);
        }
        
        [Fact]
        public void ShouldThrowExceptionGivenAllOtherBarcodes()
        {
            var priceCalculator = new PriceCalculator();
            var ex1 = Assert.Throws<Exception>(()=>priceCalculator.GetPrice("99999"));
            var ex2 = Assert.Throws<Exception>(()=>priceCalculator.GetPrice("456456"));
            Assert.Equal("Error: barcode not found", ex1.Message);
            Assert.Equal("Error: barcode not found", ex2.Message);
        }
    }
}