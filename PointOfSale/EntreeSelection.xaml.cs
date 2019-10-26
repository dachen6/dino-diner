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

        private void SteakosaurusBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void TRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Wings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void PrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Brontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void VelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
