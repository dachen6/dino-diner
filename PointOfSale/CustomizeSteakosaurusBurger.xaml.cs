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
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger steakosaurusBurger;
        public CustomizeSteakosaurusBurger(SteakosaurusBurger steakosaurusBurger)
        {
            InitializeComponent();
            this.steakosaurusBurger = steakosaurusBurger;
        }

        private void OnHoldKetchupr(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldKetchup();
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldBun();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldPickle();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldMustard();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
