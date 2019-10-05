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
    }
}
