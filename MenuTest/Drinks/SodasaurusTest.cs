using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;
namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void shouldBeAbleToetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Cherry;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void shouldBeAbleToetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Orange;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Orange, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Vanilla;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Chocolate;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Chocolate, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.RootBeer;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.RootBeer, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Cola;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Cola, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Drink.SodasaurusFlavor.Lime;
            Assert.Equal<Drink.SodasaurusFlavor>(Drink.SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void shouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        [Fact]
        public void shouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingSamll()
        {
            Sodasaurus soda = new Sodasaurus();
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
        [Fact]
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
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }
        [Fact]
        public void HoldIceShouldRemoveice()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
    }
}
