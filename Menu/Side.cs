using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// the base side of all side item
    /// </summary>
    public abstract class Side
	{
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
        /// Gets or sets the size
        /// </summary>
        /// public Size size ;
        public Size size;
        /// <summary>
        /// crate a value of size
        /// </summary>
        public virtual Size Size { get { return size; } set { size = value; } }


	}
}
