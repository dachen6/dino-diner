using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public bool ice = false;

        public bool RoomForCream = false;

        public bool Decaf = false;


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
                        this.Price = 1.45;
                        this.Calories = 8;
                        break;

                }
            }
            get { return size; }

        }
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
        public JurrasicJava()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public  void AddIce()
        {
            ice = true;
        }
    }
}
