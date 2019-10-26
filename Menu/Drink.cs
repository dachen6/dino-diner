using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;
namespace DinoDiner.Menu
{/// <summary>
/// the bse classs of all drink item
/// </summary>
    public abstract class Drink: IMenuItem,INotifyPropertyChanged, IOrderItem
    {



        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

            /// <summary>
            /// Gets and sets the calories
            /// </summary>
            public uint Calories { get; set; }

            /// <summary>
            /// Gets the ingredients list
            /// </summary>
            public abstract List<string> Ingredients { get; }
        /// <summary>
        /// creat a size for class to use
        /// </summary>
        protected Size size ;

        /// <summary>
        /// Gets or sets the size
        /// </summary>

        public virtual Size Size { get { return size; } set { size = value; } }
        /// <summary>
        /// new Description for all kind of drink
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// new Special for all kind of drink
        /// </summary>
        public abstract string[] Special { get; }

        public bool Ice = true;
        /// <summary>
        /// add ice in the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
          
        }
    }

