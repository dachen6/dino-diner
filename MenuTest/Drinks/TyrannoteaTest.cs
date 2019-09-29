using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
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
            Assert.Equal<uint>(8, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingMedium()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Medium;
            Assert.Equal<uint>(16, tn.Calories);
        }
        [Fact]
        public void ShouldHaveCurrectcaloriesAfterSettingLarge()
        {
            Tyrannotea tn = new Tyrannotea();
            tn.Size = Size.Large;
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
    }
}