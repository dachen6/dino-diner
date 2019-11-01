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
    /// Interaction logic for CustomizeT_RexKingBurger.xaml
    /// </summary>
    public partial class CustomizeT_RexKingBurger : Page
    {
        private TRexKingBurger tRexKingBurger;
        public CustomizeT_RexKingBurger(TRexKingBurger tRexKingBurger)
        {
            InitializeComponent();
            this.tRexKingBurger = tRexKingBurger;
        }

        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldMayo();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldTomato();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldKetchup();
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldBun();
        }

        private void HoldOnion(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldOnion();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldMustard();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldLettuce();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldPickle();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        { 
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
