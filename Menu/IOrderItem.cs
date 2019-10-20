using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// all the price for oeder thing
        /// </summary>
        double Price { get; }
        /// <summary>
        /// description for all you order
        /// </summary>
        string Description { get; }
        /// <summary>
        /// specal for all the order
        /// </summary>
        string[] Special { get; }
    }
}
