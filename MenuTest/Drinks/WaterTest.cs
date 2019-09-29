using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
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
        public void ShouldHaveCorrectIngedients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Equal<int>(1, w.Ingredients.Count);
        }
        public void AddLemonShouldAddLomen()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Lemon", w.Ingredients);
        }
    }
}
