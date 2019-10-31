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
        /// <summary>
        /// begin Combo page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// move to Customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectCutomize(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }

        private void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {

        }

        private void SelectPterdactyl(object sender, RoutedEventArgs e)
        {

        }

        private void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {

        }

        private void SelectBrontowurst(object sender, RoutedEventArgs e)
        {

        }

        private void SelectPrehistoric(object sender, RoutedEventArgs e)
        {

        }

        private void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger pbj = new SteakosaurusBurger();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(pbj));
            }
        }

        private void SelectVelociWrap(object sender, RoutedEventArgs e)
        {

        }
    }
}
