using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MezzorellaSticksTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal(0.99, ms.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<uint>(540, ms.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Contains<string>("Breading", ms.Ingredients);
            Assert.Contains<string>("Cheese Product", ms.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ms.Ingredients);
            Assert.Equal<int>(3, ms.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<Size>(Size.Large, ms.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal(1.45, ms.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<uint>(610, ms.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ms.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal(1.95, ms.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<uint>(720, ms.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ms.Size);
        }
        [Fact]
        public void sizeChangeShouldNotify()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Size", () =>
            {
                ms.Size = Size.Large;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyP(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();

            Assert.PropertyChanged(ms, "Price", () =>
            {
                ms.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyPO(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Calories", () =>
            {
                ms.Size = size;
            });
        }

        [Fact]
        public void ShouldhaveCurrectDescriptionInMediumSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Small;
            Assert.Equal("Small Mezzorella Sticks", ms.Description);
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInSmallSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal("Medium Mezzorella Sticks", ms.Description);
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInLargeSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal("Large Mezzorella Sticks", ms.Description);
        }
        [Fact]
        public void SpecialShouldBeCorrect()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Empty(ms.Special);
        }
    }
}
