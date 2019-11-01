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
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {

                DinoNuggets entree = new DinoNuggets();
                CretaceousCombo combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeDinoNuggets(entree));
            }
        }

        private void SelectPterdactyl(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pbj = new PterodactylWings();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePterodactylWings(pbj));
            }
        }

        private void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger pbj = new TRexKingBurger();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeT_RexKingBurger(pbj));
            }
        }

        private void SelectBrontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst pbj = new Brontowurst();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeBrontowurst(pbj));
            }
        }

        private void SelectPrehistoric(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        private void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
            }
        }

        private void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap pbj = new VelociWrap();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeVeloci_Wrapr(pbj));
            }
        }
    }
}
