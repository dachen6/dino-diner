using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
                            this.Price = 0.99;
                            this.Calories = 352;
                            break;
                        case Size.Medium:
                            this.Price = 1.45;
                            this.Calories = 410;
                            break;
                        case Size.Large:
                            this.Price = 1.95;
                            this.Calories = 590;
                            break;

                    }
                }
                get { 
                NotifyOfPropertyChanged("price");
                NotifyOfPropertyChanged("Description");
                return size;
            }

            }
        /// <summary>
        /// determind the base price and calories
        /// </summary>
        public Triceritots()
            {
                this.Price = 0.99;
                this.Calories = 352;


            }
        /// <summary>
        /// able to print Triceritots and it's size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} Triceritots";
        }
        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }
    }
    }

