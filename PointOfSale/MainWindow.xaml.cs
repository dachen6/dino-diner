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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            if (order != null)
            {
                OrderControl.NavigationService = OrderUI.NavigationService;
            }
        }
        /// <summary>
        /// Add oederUI to the page
        /// </summary>
        private void PassDataContantToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }
        /// <summary>
        /// On Load Completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContantToPage();
        }
        /// <summary>
        /// able to notity data change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChange(object sender,DependencyPropertyChangedEventArgs args)
        {
            PassDataContantToPage();
        }
        /// <summary>
        /// able to return to main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
             OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
