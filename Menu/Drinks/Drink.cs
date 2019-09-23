using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size
        {
            Small,
            Medium,
            Large
        }



        public abstract class Drink
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

        protected Size size ;

        /// <summary>
        /// Gets or sets the size
        /// </summary>

        public virtual Size Size { get { return size; } set { size = value; } }
            
            
            public bool ice = true;

            public void HoldIce()
            {
                ice = false;
            }
        public enum SodasaurusFlavor
        {
            Cola, Orange, Vanilla, Chocolate, RootBeer, Cherry, Lime
        }
        }
    }

