using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void shouldHaveCorrectDefaultPrice()
        {

            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }
        [Fact]
        public void shouldHaveCorrectDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);

        }
        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingSamll()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);
        }
        [Fact]
        public void ShouldHaveCurrectPriceAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingSamll()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }
        [Fact]
        public void HoldIceShouldAddice()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }
        [Fact]
        public void LeaveSpaceForCreamShouldAddSpaceForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }





        [Fact]
        public void sizeChangeShouldNotify()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Size", () =>
            {
                jj.Size = Size.Large;
            });

        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInSmallSize()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            if (jj.Decaf)
            {
                Assert.Equal("Decaf Small Jurassic Java", jj.Description);
            }
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInMediumSize()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            if (jj.Decaf)
            {
                Assert.Equal("Decaf Medium Jurassic Java", jj.Description);
            }
        }
        [Fact]
        public void ShouldhaveCurrectDescriptionInLargeSize()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            if (jj.Decaf)
            {
                Assert.Equal("Decaf Large Jurassic Java", jj.Description);
            }
        }

        [Fact]
        public void ShouldhaveCurrectNotDescriptionInSmallSize()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            if (!jj.Decaf)
            {
                Assert.Equal("Small Jurassic Java", jj.Description);
            }
        }
        [Fact]
        public void ShouldhaveCurrectNotDescriptionInMediumSize()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            if (!jj.Decaf)
            {
                Assert.Equal("Medium Jurassic Java", jj.Description);
            }
        }
        [Fact]
        public void ShouldhaveCurrectNotDescriptionInLargeSize()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            if (!jj.Decaf)
            {
                Assert.Equal("Large Jurassic Java", jj.Description);
            }
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyPrice(Size size)
        {
            JurassicJava jj = new JurassicJava();

            Assert.PropertyChanged(jj, "Price", () =>
            {
                jj.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyCalories(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Calories", () =>
            {
                jj.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void sizeChangeShouldNotifyDescription(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Size = size;
            });
        }
        [Fact]
        public void SpecialShouldBeCorrect()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Room For Cream", item);
            });
        }
        [Fact]
        public void LeaveRoomForCreamAndHoldIceShouldAddRoomForCreamAndAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            },
            item =>
            {
                Assert.Equal("Add Room For Cream", item);
            }) ;
        }

        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurassicJava jj = new JurassicJava();

            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.AddIce();
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava jj = new JurassicJava();

            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.LeaveRoomForCream();
            });
        }
    }
}
