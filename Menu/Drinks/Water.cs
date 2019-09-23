using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 280;
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
                ingredients.Add("Natural Flavors");
                ingredients.Add("Water");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }

        }
        public Water()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }
    }
}