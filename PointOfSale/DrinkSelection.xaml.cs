using System;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
        }
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Flavor());
        }
        void Soda(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = true;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
        }
        void Tyra(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = true;
            Ice.IsEnabled = false;
            lemon.IsEnabled = true;
        }
        void java(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = true;
            Ice.IsEnabled = true;
            lemon.IsEnabled = false;
        }
        void water(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = true;
        }
    }
}
