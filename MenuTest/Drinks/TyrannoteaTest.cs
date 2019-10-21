using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu;
using Xunit;
namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, size, lemon, and sweet properties.


        [Fact]
        public void shouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.Equal<double>(0.99, tn.Price);
        }
        [Fact]
        public void shouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.Equal<uint>(8, tn.Calories);
        }
       
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.True(tn.Ice);
        }
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.False(tn.Lemon);
        }
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.False(tn.Sweet);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingSmall()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Small;
            Assert.Equal<double>(0.99, tn.Price);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingMedium()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Medium;
            Assert.Equal<double>(1.49, tn.Price);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingLarge()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Large;
            Assert.Equal<double>(1.99, tn.Price);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingSmall()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Small;
            tn.Sweet = false;
            Assert.Equal<uint>(8, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMedium()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Medium;
            tn.Sweet = false;
            Assert.Equal<uint>(16, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLarge()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Large;
            tn.Sweet = false;
            Assert.Equal<uint>(32, tn.Calories);
        }
        [Fact]
        public void HoldIceShouldRemoveice()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.HoldIce();
            Assert.False(tn.Ice);
        }

        [Fact]
        public void AddLemonShouldAddLemons()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.AddLemon();
            Assert.True(tn.Lemon);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingSmallAndAddSweet()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            tn.Size = Size.Small;
            Assert.Equal<uint>(16, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMediumAndAddSweet()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            tn.Size = Size.Medium;
            Assert.Equal<uint>(32, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLargeAndAddSweet()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            tn.Size = Size.Large;
            Assert.Equal<uint>(64, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingSmallAndSweetIsFalse()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            tn.Sweet = false;
            tn.Size = Size.Small;
            Assert.Equal<uint>(8, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMediumAndIsFalset()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            tn.Sweet = false;
            tn.Size = Size.Medium;
            Assert.Equal<uint>(16, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLargeAndIsFalse()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            tn.Sweet = false;
            tn.Size = Size.Large;
            Assert.Equal<uint>(32, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.Contains<string>("Water", tn.Ingredients);
            Assert.Contains<string>("Tea", tn.Ingredients);
            Assert.Equal<int>(2, tn.Ingredients.Count);
        }
        [Fact]
        public void AddLemonShouldAddLomen()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.AddLemon();
            Assert.Contains<string>("Lemon", tn.Ingredients);
        }
        [Fact]
        public void AddSweet()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tn.Ingredients);
        }



        [Fact]
        public void sizeChangeShouldNotify()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.PropertyChanged(tn, "Size", () =>
            {
                tn.Size = Size.Large;
            });

        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInSmallSize()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Small;
            if (tn.Sweet)
            {
                Assert.Equal("Sweet Small Tyrannotea", tn.Description);
            }
            else
            {
                Assert.Equal("Small Tyrannotea", tn.Description);
            }
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInMediumSize()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Medium;
            if (tn.Sweet)
            {
                Assert.Equal("Sweet Medium Tyrannotea", tn.Description);
            }
            else
            {
                Assert.Equal("Medium Tyrannotea", tn.Description);
            }
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInLargeSize()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Large;
            if (tn.Sweet)
            {
                Assert.Equal("Sweet Large Tyrannotea", tn.Description);
            }
            else
            {
                Assert.Equal("Large Tyrannotea", tn.Description);
            }
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyPrice(Size size)
        {
            Tyrannotea tn = new Tyrannotea();

            Assert.PropertyChanged(tn, "Price", () =>
            {
                tn.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifySize(Size size)
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.PropertyChanged(tn, "Size", () =>
            {
                tn.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyDescription(Size size)
        {
            Tyrannotea tn = new Tyrannotea();

            Assert.PropertyChanged(tn, "Description", () =>
            {
                tn.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyCalories(Size size)
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.PropertyChanged(tn, "Calories", () =>
            {
                tn.Size = size;
            });
        }
        [Fact]
        public void SpecialShouldBeCorrect()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.Empty(tn.Special);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.HoldIce();
            Assert.Collection<string>(tn.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.AddLemon();
            Assert.Collection<string>(tn.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void AddLemonAndHoldIceShoukdAddToSpecial()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.AddLemon();
            tn.HoldIce();
            Assert.Collection<string>(tn.Special,
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
            Tyrannotea tn = new Tyrannotea();

            Assert.PropertyChanged(tn, "Special", () =>
            {
                tn.AddLemon();
            });
        }
        [Fact]
        public void HoldingJerryShouldNotifySpecialChange()
        {
            Tyrannotea tn = new Tyrannotea();

            Assert.PropertyChanged(tn, "Special", () =>
            {
                tn.HoldIce();
            });
        }
        [Fact]
        public void HoldingJerryShouldNotifyIngredientsChange()
        {
            Tyrannotea tn = new Tyrannotea();

            Assert.PropertyChanged(tn, "Ingredients", () =>
            {
                tn.AddLemon();
            });
        }
        


    }
}