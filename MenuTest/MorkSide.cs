﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;
namespace MenuTest
{
    public class MorkSide : IOrderItem,INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
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
