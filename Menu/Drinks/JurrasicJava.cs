using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// we dont add ice RoomForCream decaf in JurrasicJava
        /// </summary>
        public bool Ice = false;

        public bool RoomForCream = false;

        public bool Decaf = false;

        /// <summary>
        /// change price and calories of JurrasicJava with size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.59;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        this.Price = 0.99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;

                }
            }
            get { return size; }

        }
        /// <summary>
        /// show what in JurrasicJava
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }

        }
        /// <summary>
        /// set the base price and calories for JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;

        }
        /// <summary>
        /// add lemon
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// add ice
        /// </summary>
        public  void AddIce()
        {
            Ice = true;
        }
    }
}
