using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;
namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //The ability to set each possible flavor
        [Fact]
        public void shouldBeAbleToetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Cherry;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Cherry, soda.Flavor);

        }
        //The correct default price, calories, ice, and size
        [Fact]
        public void shouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingSamll()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }    
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }
        public void ShouldHaveCurrectcaloriesAfterSettingSamll()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
    }
}
