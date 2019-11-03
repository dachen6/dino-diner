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
using DDSize = DinoDiner.Menu.Size;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        CretaceousCombo combo;
        /// <summary>
        /// begin Customize page
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initialize CustomizeCombo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        /// <summary>
        /// click side buton to go to side page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Selectsize(object sender, RoutedEventArgs args)
        {
        NavigationService.Navigate(new SideSelection(this.combo));
        }
        /// <summary>
        /// click drink buton to go to drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(this.combo));
        }
        /// <summary>
        /// change combe's size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnChanegSize(object sender, RoutedEventArgs arg)
        {
            if (sender is FrameworkElement element)
            {
                combo.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
    
}
