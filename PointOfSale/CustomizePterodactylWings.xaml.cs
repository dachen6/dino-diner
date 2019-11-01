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
        public CustomizePterodactylWings(PterodactylWings pterodactylWings)
        {
            InitializeComponent();
            this.pterodactylWings = pterodactylWings;
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

    }
}
