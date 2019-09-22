using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// using the base class size for MezzorellaSticks
    /// </summary>
    public class MezzorellaSticks: Side
    {
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }

        }
        /// <summary>
        /// determind different price and Calories with size for MezzorellaSticks
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
                            this.Price = 0.99;
                            this.Calories = 540;
                            break;
                        case Size.Medium:
                            this.Price = 1.45;
                            this.Calories = 610;
                            break;
                        case Size.Large:
                            this.Price = 1.95;
                            this.Calories = 720;
                            break;

                    }
                }
                get { return size; }
            }
        /// <summary>
        /// determind the base price and calories
        /// </summary>
        public MezzorellaSticks()
            {
                Price = 0.99;
                Calories = 540;


            }
        }
    }
