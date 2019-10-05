using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// in the beigneer, we don't add suger and lemon
        /// </summary>
        public bool Sweet = false;
        public bool Lemon = false;
        /// <summary>
        /// we change the price and calories with size and sweet
        /// </summary>
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
        /// <summary>
        /// show what in the Tyrannotea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (Lemon) ingredients.Add("Lemon");
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (Sweet) ingredients.Add("Cane Sugar");

                return ingredients;
            }

        }
        /// <summary>
        ///add lemon 
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;

        }
        /// <summary>
        /// the base price and calories of Tyrannotea 
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }
        public override string ToString()
        {
            if (Sweet) { return $"{size.ToString()} Sweet Tyrannotea"; }
            else { return $"{size.ToString()} Tyrannotea"; }
        }
    }
}
