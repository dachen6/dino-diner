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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {


       
        private Side side;
        private CretaceousCombo combo;
        /// <summary>
        /// begin side page
        /// </summary>    
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// iniciation the side when someone add side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
            MakeSmall.IsEnabled = false;
           MakeMedium.IsEnabled = false;
            MakeLarge.IsEnabled = false;
        }
        /// <summary>
        /// click Fryceritops to add it to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnSelectFeyceritops(object sender, RoutedEventArgs arg)
        {
            if(DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Fryceritops();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new Fryceritops();
                    this.side = combo.Side;
                }
                
            }

        }
        /// <summary>
        /// click Triceritots to add it to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)

            {
                if (combo == null)
                {
                    side = new Triceritots();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new Triceritots();
                    this.side = combo.Side;
                }
            }
        }
        /// <summary>
        /// click MeteorMac And Cheese stick to add it to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnSelectMeteorMacCheese(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)

            {
                if (combo == null)
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new MeteorMacAndCheese();
                    this.side = combo.Side;
                }
            }
        }
        /// <summary>
        /// click Mozzerella stick to add it to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnSelectMozzerellaSticks(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)

            {
                if (combo == null)
                {
                    side = new MezzorellaSticks();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new MezzorellaSticks();
                    this.side = combo.Side;
                }

            }
        }
            /// <summary>
            /// able to change size for side
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="arg"></param>
            private void OnChanegSize(object sender, RoutedEventArgs arg)
            {
                if(sender is FrameworkElement element)
                {
                    if (combo == null)
                    {
                        side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    }
                    else
                    {
                    this.side = combo.Side;
                    this.side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    }
             
                }
            }
        /// <summary>
        /// go to main menu when finish choose side, go to CustomizeCombo when finish combo's side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
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
