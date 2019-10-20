using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
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
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void shouldBeAbleToetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }
        [Fact]
        public void shouldBeAbleToetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }


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




        [Fact]
        public void sizeChangeShouldNotify()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });

        }

        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        public void ShouldhaveCurrectDescriptionInLargeSize(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;

            Assert.Equal($"{size.ToString()} {flavor.ToString()} Sodasaurus", soda.Description);

        }


        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyPrice(Size size)
        {
            Sodasaurus soda = new Sodasaurus();

            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyCalories(Size size)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyDescriptions(Size size)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = size;
            });
        }
        [Fact]
        public void SpecialShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }


       
        [Fact]
        public void HoldingIceShouldNotifySpecialChange()
        {
            Sodasaurus soda = new Sodasaurus();

            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });
        }


    }
}
