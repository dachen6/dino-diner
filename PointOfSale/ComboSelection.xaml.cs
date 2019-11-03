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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;
        private Entree entree;
        /// <summary>
        /// begin Combo page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Initialize ComboSelection
        /// </summary>
        /// <param name="combo"></param>
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        /// <summary>
        /// go to CustomizeVeloci_Wrapr and add CustomizeVeloci_Wrapr into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {

                CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeDinoNuggets(combo));
            }
        }
        /// <summary>
        /// go to PterodactylWings and add PterodactylWings into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectPterdactyl(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new CustomizePterodactylWings(combo));
            }
        }
        /// <summary>
        /// go to T_RexKingBurger and add T_RexKingBurger into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeT_RexKingBurger(combo));
            }
        }
        /// <summary>
        /// go to Brontowurst and add Brontowurst into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBrontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeBrontowurst(combo));
            }
        }
        /// <summary>
        /// go to PrehistoricPBJ and add PrehistoricPBJ into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectPrehistoric(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
            }
        }
        /// <summary>
        /// go to SteakosaurusBurger and add SteakosaurusBurger into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
            }
        }
        /// <summary>
        /// go to CustomizeVeloci_Wrapr and add CustomizeVeloci_Wrapr into combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeVeloci_Wrapr(combo));
            }
        }
    }
}
