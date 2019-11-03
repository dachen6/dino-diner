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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst brontowurst;
        /// <summary>
        /// Initialize brontowurst when choose entree
        /// </summary>
        /// <param name="brontowurst"></param>
        public CustomizeBrontowurst(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
        }
        private CretaceousCombo combo;
        /// <summary>
        ///  Initialize brontowurst when choose combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.brontowurst = combo.Entree as Brontowurst;
        }
        /// <summary>
        /// click HoldBUn to Hold Bun brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.brontowurst.HoldBun();
        }
        /// <summary>
        /// click HoldOnion to Hold Onion forbrontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            this.brontowurst.HoldOnion();
        }
        /// <summary>
        /// click HoldPeppers to Hold Peppers for brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            this.brontowurst.HoldPeppers();
        }
        /// <summary>
        /// go to CustomizeCombo when finish choosing combo or go to main menu when choose entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (this.combo != null)
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
