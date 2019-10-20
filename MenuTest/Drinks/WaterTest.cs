using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void shouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.1, w.Price);
        }
        [Fact]
        public void shouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);

        }
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<double>(0.1, w.Price);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.1, w.Price);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories); ;
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void HoldIceShouldRemoveice()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }
        [Fact]
        public void AddLemonShouldAddLemons()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        [Fact]
        public void sizeChangeShouldNotify()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Size", () =>
            {
                w.Size = Size.Large;
            });

        }

        [Fact]
        public void ShouldhaveCurrectDescriptionInMediumSize()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal("Small Water", w.Description);
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInSmallSize()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal("Medium Water", w.Description);
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInLargeSize()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal("Large Water", w.Description);
        }
        [Fact]
        public void SpecialShouldBeCorrect()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void AddLemonAndHoldIceShoukdAddToSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            w.HoldIce();
            Assert.Collection<string>(w.Special,
            item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void HoldingPeanutButterShouldNotifySpecialChange()
        {
            Water w = new Water();

            Assert.PropertyChanged(w, "Special", () =>
            {
                w.AddLemon();
            });
        }
        [Fact]
        public void HoldingJerryShouldNotifySpecialChange()
        {
            Water w = new Water();

            Assert.PropertyChanged(w, "Special", () =>
            {
                w.HoldIce();
            });
        }
        [Fact]
        public void HoldingJerryShouldNotifyIngredientsChange()
        {
            Water w = new Water();

            Assert.PropertyChanged(w, "Ingredients", () =>
            {
                w.AddLemon();
            });
        }

    }
}
