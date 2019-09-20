using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    
    public class MezzorellaSticks: Side
    {
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegtable Oil");
                return ingredients;
            }

        }

        private Size size;
            public override Size Size
            {
                set
                {
                    size = value;
                    switch (size)
                    {
                        case Size.Small:
                            Price = 0.99;
                            Calories = 540;
                            break;
                        case Size.Medium:
                            Price = 1.45;
                            Calories = 610;
                            break;
                        case Size.Large:
                            Price = 1.95;
                            Calories = 720;
                            break;

                    }
                }
                get { return Size; }
            }
            public MezzorellaSticks()
            {
                Price = this.Price;
                Calories = this.Calories;
                Ingredients.Add("Cheese Product");

                Ingredients.Add("Breading");
                Ingredients.Add("Vegtable Oil");

            }
        }
    }
