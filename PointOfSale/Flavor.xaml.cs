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
using DinoDiner.Menu;
using DDfalvor = DinoDiner.Menu.SodasaurusFlavor;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Flavor.xaml
    /// </summary>
    public partial class Flavor : Page
    {
        private Sodasaurus drink;
        /// <summary>
        /// begin flavor page
        /// </summary>
        public Flavor()
        {
            InitializeComponent();
        }

        public Flavor(Sodasaurus sd)
        {
            InitializeComponent();
            this.drink = sd;
        }
        private void OnChanegFlavor(object sender, RoutedEventArgs arg)
        {
            if (sender is FrameworkElement element)
            {
                drink.Flavor = (DDfalvor)Enum.Parse(typeof(DDfalvor), element.Tag.ToString());
            }
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
