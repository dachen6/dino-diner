using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
namespace MenuTest
{
    public class MorkEntree : IOrderItem
    {
    

        public double Price { get; set; }

        public string Description { get;}

        public string[] Special { get; }

        public MorkEntree(double d)
        {
            Price = d;
        }
    }
}
