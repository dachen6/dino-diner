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
        /// <summary>
        /// begin drink page disable falvor ice and lemon buttun until user choose a drink
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();          
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
            t = 0;
        }
        /// <summary>
        /// check if user choose soda
        /// </summary>
        public int t = 0;
        /// <summary>
        /// go to falvor page if user choose soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (t == 1)
            {
                NavigationService.Navigate(new Flavor());
               
            }
        }
        /// <summary>
        /// click soda button to continue choose flavor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Soda(object sender, RoutedEventArgs args)
        {
            
            flavor.IsEnabled = true;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
            t = 1;
        }
        /// <summary>
        /// click Tyrannotea to continue choose lemon and sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Tyra(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = true;
            Ice.IsEnabled = false;
            lemon.IsEnabled = true;
            t = 0;
        }
        /// <summary>
        /// click JurrasicJava to continue choose lemon and ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void java(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = true;
            Ice.IsEnabled = true;
            lemon.IsEnabled = false;
            t = 0;
        }
        /// <summary>
        /// click water to continue choose lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void water(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = true;
            t = 0;
        }
    }
}
