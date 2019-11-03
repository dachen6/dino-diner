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
        /// <summary>
        ///  Initializ tRexKingBurger when choose entree
        /// </summary>
        /// <param name="tRexKingBurger"></param>
        public CustomizeT_RexKingBurger(TRexKingBurger tRexKingBurger)
        {
            InitializeComponent();
            this.tRexKingBurger = tRexKingBurger;
        }
        private CretaceousCombo combo;
        /// <summary>
        /// Initializ tRexKingBurger when choose combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeT_RexKingBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.tRexKingBurger = combo.Entree as TRexKingBurger;
        }
        /// <summary>
        /// click HoldPickle to HoldPickle or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldMayo();
        }
        /// <summary>
        /// click Hold Tomato to Hold Tomato or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldTomato();
        }
        /// <summary>
        /// click HoldKetchup to Hold Ketchup or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldKetchup();
        }
        /// <summary>
        /// click HoldBun to Hold Bun or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldBun();
        }
        /// <summary>
        /// click HoldOnion to HoldOnion or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnion(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldOnion();
        }
        /// <summary>
        /// click HoldMustard to HoldMustard or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldMustard();
        }
        /// <summary>
        /// click HoldLettuce to HoldLettuce or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldLettuce();
        }
        /// <summary>
        /// click HoldPickle to HoldPickle or tRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.tRexKingBurger.HoldPickle();
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
