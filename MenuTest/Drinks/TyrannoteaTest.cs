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
        public void shouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tn = new Tyrannotea();
            Assert.Equal<double>(0.99, tn.Price);
        }


    }
}