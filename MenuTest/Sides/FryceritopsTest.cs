﻿using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Large, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }
        [Fact]
        public void sizeChangeShouldNotify()
        {
            Fryceritops ft = new Fryceritops();        
            Assert.PropertyChanged(ft, "Size", () =>
              {
                  ft.Size = Size.Large;
              });

        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyP(Size size)
        {
            Fryceritops ft = new Fryceritops();

            Assert.PropertyChanged(ft, "Price", () =>
            {
                ft.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyPO(Size size)
        {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, "Calories", () =>
            {
                ft.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyDescription(Size size)
        {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, "Description", () =>
            {
                ft.Size = size;
            });
        }

        [Fact]
        public void ShouldhaveCurrectDescriptionInMediumSize()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Small;
            Assert.Equal("Small Fryceritops", ft.Description);
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInSmallSize()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal("Medium Fryceritops", ft.Description);
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInLargeSize()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal("Large Fryceritops", ft.Description);
        }
        [Fact]
        public void SpecialShouldBeCorrect()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Empty(ft.Special);
        }

    }
}
