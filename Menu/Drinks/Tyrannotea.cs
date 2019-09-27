using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Sweet = false;
        public bool Lemon = false;

        public override Size Size
        {
            set
            {
                size = value;
                if (Sweet)
                {
                    switch (size)
                    {
                        case Size.Small:
                            Price = 0.99;
                            Calories = 16;
                            break;
                        case Size.Medium:
                            Price = 1.49;
                            Calories = 32;
                            break;
                        case Size.Large:
                            Price = 1.99;
                            Calories = 64;
                            break;

                    }
                }
                else
                {
                    switch (size)
                    {
                        case Size.Small:
                            Price = 0.99;
                            Calories = 8;
                            break;
                        case Size.Medium:
                            Price = 1.49;
                            Calories = 16;
                            break;
                        case Size.Large:
                            Price = 1.99;
                            Calories = 32;
                            break;

                    }
                }
            }
            get { return size; }

        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (Lemon) ingredients.Add("Lemon");
                ingredients.Add("Water");
                if (Sweet) ingredients.Add("Cane Sugar");

                return ingredients;
            }

        }
        public void AddLemon()
        {
            Lemon = true;

        }

    }
}
