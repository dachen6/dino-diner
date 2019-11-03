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
        private CretaceousCombo combo;
        /// <summary>
        /// begin flavor page
        /// </summary>
        public Flavor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// inicition falvor page
        /// </summary>
        /// <param name="sd"></param>
        public Flavor(Sodasaurus sd)
        {
            InitializeComponent();
            this.drink = sd;
        }
        public Flavor(Sodasaurus sd, CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.drink = sd;
        }
        /// <summary>
        /// able to change the falvor when click soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnChanegFlavor(object sender, RoutedEventArgs arg)
        {
            if (sender is FrameworkElement element)
            {
                drink.Flavor = (DDfalvor)Enum.Parse(typeof(DDfalvor), element.Tag.ToString());
            }
            if (this.combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(this.combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection());
            }
            
        }
    }
}
