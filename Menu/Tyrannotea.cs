using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// items for tyrannotea using base class drink
    /// </summary>
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
                if (Sweet) ingredients.Add("Cane Sugar");
                ingredients.Add("Water");
                ingredients.Add("Tea");
                

                return ingredients;
            }

        }
        /// <summary>
        ///add lemon 
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// the base price and calories of Tyrannotea 
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }
        /// <summary>
        /// able to print Sweet Tyrannotea if it's sweet and Tyrannotea if it's not sweet and its size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet) { return $"{size.ToString()} Sweet Tyrannotea"; }
            else { return $"{size.ToString()} Tyrannotea"; }
        }
        public override string Description
        {
            get { return this.ToString(); }
        }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Lemon");
                return special.ToArray();
            }
        }
    }
}
