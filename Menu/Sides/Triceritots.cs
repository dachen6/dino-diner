using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// using the base class size for Triceritots
    /// </summary>
    public class Triceritots: Side
    {
        /// <summary>
        /// add ingredient to MeteorMacAndCheese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }

        }
        /// <summary>
        /// determind different price and Calories with size for Triceritots
        /// </summary>
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
                            Calories = 352;
                            break;
                        case Size.Medium:
                            Price = 1.45;
                            Calories = 410;
                            break;
                        case Size.Large:
                            Price = 1.95;
                            Calories = 590;
                            break;

                    }
                }
                get { return size; }

            }
        /// <summary>
        /// determind the base price and calories
        /// </summary>
        public Triceritots()
            {
                Price = 0.99;
                Calories = 352;


            }
        }
    }

