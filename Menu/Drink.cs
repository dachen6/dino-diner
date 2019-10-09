﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{/// <summary>
/// the bse classs of all drink item
/// </summary>
    public abstract class Drink: IMenuItem
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
        /// creat a size for class to use
        /// </summary>
        protected Size size ;

        /// <summary>
        /// Gets or sets the size
        /// </summary>

        public virtual Size Size { get { return size; } set { size = value; } }
            
            
           public bool Ice = true;
        /// <summary>
        /// add ice in the drink
        /// </summary>
            public void HoldIce()
            {
                Ice = false;
            }
          
        }
    }
