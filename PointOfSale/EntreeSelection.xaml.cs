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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        /// <summary>
        /// begin entree page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// begin the entree page when and add page
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }
        /// <summary>
        /// add SteakosaurusBurger to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosaurusBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger pbj = new SteakosaurusBurger();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(pbj));
            }
        }
        /// <summary>
        /// add DinoNuggets to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets pbj = new DinoNuggets();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeDinoNuggets(pbj));
            }
        }
        /// <summary>
        /// add TRexKingBurger to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger pbj = new TRexKingBurger();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeT_RexKingBurger(pbj));
            }
        }
        /// <summary>
        /// add Wings to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pbj = new PterodactylWings();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePterodactylWings(pbj));
            }
        }

        /*private void PrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }*/
        /// <summary>
        /// add Brontowurst to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Brontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst pbj = new Brontowurst();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeBrontowurst(pbj));
            }
        }
        /// <summary>
        /// add VelociWrap to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap vel = new VelociWrap();
                order.Add(vel);
                NavigationService.Navigate(new CustomizeVeloci_Wrapr(vel));
            }
        }
        /// <summary>
        /// add SteakosaurusBurger to order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPrehistoricPBJ(object  sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }
    }
}
