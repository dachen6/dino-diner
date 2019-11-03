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
        /// <summary>
        /// Initialize steakosaurusBurger when click entree
        /// </summary>
        /// <param name="steakosaurusBurger"></param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger steakosaurusBurger)
        {
            InitializeComponent();
            this.steakosaurusBurger = steakosaurusBurger;
        }
        /// <summary>
        /// Initialize steakosaurusBurger when click combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.steakosaurusBurger = combo.Entree as SteakosaurusBurger;
        }
        /// <summary>
        /// click Hold Ketchup to Hold Ketchup for steakosaurusBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchupr(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldKetchup();
        }
        /// <summary>
        /// click Hold Bun to Hold Bun for steakosaurusBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldBun();
        }
        /// <summary>
        /// click HoldPickle to Hold Pickle for steakosaurusBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldPickle();
        }

        /// <summary>
        /// click HoldMustard to Hold Mustard for steakosaurusBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.steakosaurusBurger.HoldMustard();
        }
        /// <summary>
        /// go to CustomizeCombo when finish choosing combo or go to main menu when choose entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
