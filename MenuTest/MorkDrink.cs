using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;
namespace MenuTest
{
    public class MorkDrink : IOrderItem, INotifyPropertyChanged
    {
        //public override List<string> Ingredients { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        public double price;
        public double Price { get; set; }

        public string Description => throw new NotImplementedException();

        public string[] Special => throw new NotImplementedException();

        //public override string Description { get; }

        //public override string[] Special { get; }

        public MorkDrink(double d)
        {
            Price = d;
        }
    }
}