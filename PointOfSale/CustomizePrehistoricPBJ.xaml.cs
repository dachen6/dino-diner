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
    /// Interaction logic for cus.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj;
        /// <summary>
        ///  Initialize PrehistoricPBJ when choose entree
        /// </summary>
        /// <param name="pbj"></param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }
        private CretaceousCombo combo;
        /// <summary>
        ///  Initialize PrehistoricPBJ when choose combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.pbj = combo.Entree as PrehistoricPBJ;
        }
        /// <summary>
        /// clickHoldPeanutButter to Hold Peanut Butter for PrehistoricPBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Onholdpeanutbutter(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldPeanutButter();
        }

        /// <summary>
        /// click HoldJelly to Hold Jelly for PrehistoricPBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnholdHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        /// <summary>
        /// go to CustomizeCombo when finish choosing combo or go to main menu when choose entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDone(object sender, RoutedEventArgs args)
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
