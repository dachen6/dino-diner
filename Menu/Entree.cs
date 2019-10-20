using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// the base calss for all the entree
    /// </summary>
    public abstract class Entree:IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// get and set price
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
        /// new Description for all entree
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// new special for all the entree
        /// </summary>
        public abstract string[] Special { get; }
    }
}
