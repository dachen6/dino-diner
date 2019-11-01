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
                side = new Triceritots();
                order.Add(side);
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
                side = new MeteorMacAndCheese();
                order.Add(side);
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
                side = new MezzorellaSticks();
                order.Add(side);
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
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }


    }
}
