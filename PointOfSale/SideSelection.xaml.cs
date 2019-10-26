﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {


       
        private Side side;
        /// <summary>
        /// begin side page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        private void OnSelectFeyceritops(object sender, RoutedEventArgs arg)
        {
            if(DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
        }
        private void OnSelectTriceritots(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(side);
            }
        }
        private void OnSelectMeteorMacCheese(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
            }
        }
        private void OnSelectMozzerellaSticks(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
            }
        }

        private void OnChanegSize(object sender, RoutedEventArgs arg)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }


    }
}
