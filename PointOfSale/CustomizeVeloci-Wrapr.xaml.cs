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
        /// <summary>
        ///  Initialize velociWrap when chosoe entree
        /// </summary>
        /// <param name="velociWrap"></param>
        public CustomizeVeloci_Wrapr(VelociWrap velociWrap)
        {
            InitializeComponent();
            this.velociWrap = velociWrap;
        }
        private CretaceousCombo combo;
        /// <summary>
        /// Initialize velociWrap when chosoe combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeVeloci_Wrapr(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.velociWrap = combo.Entree as VelociWrap;
        }
        /// <summary>
        /// click HoldDressing to Hold Dressing for velociWrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Onholddressing(object sender, RoutedEventArgs e)
        {
            this.velociWrap.HoldDressing();
        }
        /// <summary>
        /// click HoldLettuce to Hold Lettuce for velociWrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnholdHoldlettuce(object sender, RoutedEventArgs e)
        {
            this.velociWrap.HoldLettuce();
        }
        /// <summary>
        /// click HoldCheese to HoldCheese for velociWrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnholdHoldcheese(object sender, RoutedEventArgs e)
        {
            this.velociWrap.HoldCheese();
        }
        /// <summary>
        /// go to CustomizeCombo when finish choosing combo or go to main menu when choose entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (this.combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(this.combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
