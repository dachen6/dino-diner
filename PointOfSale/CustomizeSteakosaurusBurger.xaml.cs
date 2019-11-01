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
        private CretaceousCombo combo;

        public CustomizeSteakosaurusBurger(SteakosaurusBurger steakosaurusBurger)
        {
            InitializeComponent();
            this.steakosaurusBurger = steakosaurusBurger;
        }
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.steakosaurusBurger = combo.Entree as SteakosaurusBurger;
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
            if(this.combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(this.combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
