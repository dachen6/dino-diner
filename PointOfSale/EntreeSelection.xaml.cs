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
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
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
                entree = new DinoNuggets();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
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
                entree = new TRexKingBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
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
                entree = new PterodactylWings();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
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
                entree = new Brontowurst();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
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
                entree = new VelociWrap();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
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
