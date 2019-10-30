using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;
namespace MenuTest
{
    public class MorkEntree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double Price { get; set; }

        public string Description { get;}

        public string[] Special { get; }

        public MorkEntree(double d)
        {
            Price = d;
        }
    }
}
