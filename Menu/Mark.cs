using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Mark : IOrderItem
    {
        public double Price { get; set; }

        public string Description => throw new NotImplementedException();

        public string[] Special => throw new NotImplementedException();

        public Mark(double d)
        {
            Price = d;
            
        }

}
}
