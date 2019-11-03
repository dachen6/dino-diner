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
    /// Interaction logic for CustomizePterodactylWings.xaml
    /// </summary>
    public partial class CustomizePterodactylWings : Page
    {
        private PterodactylWings pterodactylWings;
        /// <summary>
        /// Initialize PterodactylWings when choose entree
        /// </summary>
        /// <param name="pterodactylWings"></param>
        public CustomizePterodactylWings(PterodactylWings pterodactylWings)
        {
            InitializeComponent();
            this.pterodactylWings = pterodactylWings;
        }
        private CretaceousCombo combo;
        /// <summary>
        ///  Initialize PterodactylWings when choose combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizePterodactylWings(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.pterodactylWings = combo.Entree as PterodactylWings;
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
