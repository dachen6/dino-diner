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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// begin drink page disable falvor ice and lemon buttun until user choose a drink
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();          
            t = 0;
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
        }
        private Drink drink;
        private CretaceousCombo combo;
        /// <summary>
        /// Initialize when choose drink
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
            small.IsEnabled = true;
            Medium.IsEnabled = true;
            Large.IsEnabled = true;
            if (drink is Sodasaurus)
            {
                flavor.IsEnabled = true;
                Ice.IsEnabled = true;
                lemon.IsEnabled = false;
            }
            if (drink is Water)
            {
                flavor.IsEnabled = false;
                Ice.IsEnabled = false;
                lemon.IsEnabled = true;
            }
            if (drink is Tyrannotea)
            {
                flavor.IsEnabled = true;
                Ice.IsEnabled = false;
                lemon.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {

                flavor.IsEnabled = true;
                Ice.IsEnabled = true;
                lemon.IsEnabled = false;
            }


        }
        /// <summary>
        /// Initialize when choose combo drink
        /// </summary>
        /// <param name="combo"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.drink = combo.Drink;
            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = false;
            small.IsEnabled = false;
            Medium.IsEnabled = false;
            Large.IsEnabled = false;
            if (drink is Sodasaurus)
            {
                flavor.IsEnabled = true;
                Ice.IsEnabled = true;
                lemon.IsEnabled = false;
            }
            if (drink is Water)
            {
                flavor.IsEnabled = false;
                Ice.IsEnabled = false;
                lemon.IsEnabled = true;
            }
            if (drink is Tyrannotea)
            {
                flavor.IsEnabled = true;
                Ice.IsEnabled = false;
                lemon.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {

                flavor.IsEnabled = true;
                Ice.IsEnabled = true;
                lemon.IsEnabled = false;
            }
        }
        /// <summary>
        /// check if user choose soda
        /// </summary>
        public int t = 0;
        /// <summary>
        /// go to falvor page if user choose soda and add sweet if choose Tyrannotea or decaf if choose JurassicJava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (drink is Sodasaurus sd)
            {
                if (combo == null)
                {
                    NavigationService.Navigate(new Flavor(sd));
                }
                else
                {
                    NavigationService.Navigate(new Flavor(sd,combo));
                }
                //NavigationService.Navigate(new Flavor(sd));

            }
            else if (drink is Tyrannotea ty)
            {
                
                ty.AddSweet();
             
            }
            else if (drink is JurassicJava jj)
            {
                jj.AddDecaf();

            }
        }
        /// <summary>
        /// click soda button to continue choose flavor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Soda(object sender, RoutedEventArgs args)
        {
            flavor.IsEnabled = true;
            Ice.IsEnabled = true;
            lemon.IsEnabled = false;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new Sodasaurus();
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = new Sodasaurus();
                    this.drink = combo.Drink;
                }
            }



        }
        /// <summary>
        /// click Tyrannotea to continue choose lemon and sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Tyra(object sender, RoutedEventArgs args)
        {

            flavor.IsEnabled = true;
            Ice.IsEnabled = false;
            lemon.IsEnabled = true;
            t = 2;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new Tyrannotea();
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = new Tyrannotea();
                    this.drink = combo.Drink;
                }
            }
        }
        /// <summary>
        /// click JurrasicJava to continue choose lemon and ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void java(object sender, RoutedEventArgs args)
        {

            flavor.IsEnabled = true;
            Ice.IsEnabled = true;
            lemon.IsEnabled = false;
            t = 3;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new JurassicJava();
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = new JurassicJava();
                    this.drink = combo.Drink;
                }
            }
        }
        /// <summary>
        /// click water to continue choose lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void water(object sender, RoutedEventArgs args)
        {

            flavor.IsEnabled = false;
            Ice.IsEnabled = false;
            lemon.IsEnabled = true;
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    drink = new Water();
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = new Water();
                    this.drink = combo.Drink;
                }
            }
            t = 0;
        }
        /// <summary>
        /// able to change size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OnChanegSize(object sender, RoutedEventArgs arg)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        /// <summary>
        /// add ice to drink except for java we remove ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Click(object sender, RoutedEventArgs e)
        {
            if (drink is JurassicJava ja)
            {
                ja.AddIce();
            }
            else
            {
                drink.HoldIce();
            }
        }
        /// <summary>
        /// add lemon to the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lemon_Click(object sender, RoutedEventArgs e)
        {
           if(drink is Water w)
            {
                w.AddLemon();
            }
            if (drink is Tyrannotea t)
            {
                t.AddLemon();
            }
        }
        /// <summary>
        /// go back to main menu
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
