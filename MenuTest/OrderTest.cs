using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ItShouldHveRightPrice()
        {
            MorkDrink md = new MorkDrink(5);
            MorkSide ms = new MorkSide(3);
            MorkEntree me = new MorkEntree(2);
            Order o = new Order();
            o.item.Add(md);
            o.item.Add(ms);
            o.item.Add(me);
            Assert.Equal<double>(10, o.SubtotalCost);
        }
        [Fact]
        public void CanNotBeNegative()
        {
            MorkDrink md = new MorkDrink(-85);
            MorkSide ms = new MorkSide(3);
            MorkEntree me = new MorkEntree(2);
            Order o = new Order();
            o.item.Add(md);
            o.item.Add(ms);
            o.item.Add(me);
            Assert.Equal<double>(0, o.SubtotalCost);
        }
    }
}
