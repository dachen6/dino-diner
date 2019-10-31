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
        public CustomizeDinoNuggets(DinoNuggets dinoNuggets)
        {
            InitializeComponent();
            this.dinoNuggets = dinoNuggets;

        }

        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            
            this.dinoNuggets.AddNugget();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if(Order is )
            NavigationService.GoBack();
        }
    }
}
