using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
namespace MenuTest
{
    public class MorkSide : IOrderItem
    {
        

        public double price;

        public double Price{ get; set; }

        public string Description { get; }

        public  string[] Special { get; }

        public MorkSide(double d)
        {
            Price = d;
        }
    }
}
