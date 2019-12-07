using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// base class for all menu
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// the base price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the base Calories
        /// </summary>
        uint Calories { get;  }
        /// <summary>
        /// the base Ingredients
        /// </summary>
        List<string> Ingredients { get; }

        Size Size { get; set; }
        
    }

}
