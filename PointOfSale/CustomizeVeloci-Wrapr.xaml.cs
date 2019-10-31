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
    /// Interaction logic for CustomizeVeloci_Wrapr.xaml
    /// </summary>
    public partial class CustomizeVeloci_Wrapr : Page
    {
        private VelociWrap velociWrap;
        public CustomizeVeloci_Wrapr(VelociWrap velociWrap)
        {
            InitializeComponent();
            this.velociWrap = velociWrap;
        }

        private void Onholddressing(object sender, RoutedEventArgs e)
        {
            this.velociWrap.HoldDressing();
        }

        private void OnholdHoldlettuce(object sender, RoutedEventArgs e)
        {
            this.velociWrap.HoldLettuce();
        }

        private void OnholdHoldcheese(object sender, RoutedEventArgs e)
        {
            this.velociWrap.HoldCheese();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
