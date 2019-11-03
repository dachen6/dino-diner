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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {

        private DinoNuggets dinoNuggets;

        /// <summary>
        ///  Initialize DinoNuggets page when chose entree
        /// </summary>
        /// <param name="dinoNuggets"></param>
        public CustomizeDinoNuggets(DinoNuggets dinoNuggets)
        {
            InitializeComponent();
            this.dinoNuggets = dinoNuggets;

        }
        private CretaceousCombo combo;
        /// <summary>
        /// Initialize DinoNuggets page when chose combi
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.dinoNuggets = combo.Entree as DinoNuggets;
        }
        /// <summary>
        /// click AddNugget to Add Nugget for dinoNuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            
            this.dinoNuggets.AddNugget();
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
