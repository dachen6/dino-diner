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
        private bool sweet = false;
        public bool Sweet { get { return sweet; } set { sweet = value; NotifyOfPropertyChanged("Description"); } }
        private bool lemon = false;
        public bool Lemon{ get { return lemon; } set
            {
                lemon = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            } }
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

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("price");
                NotifyOfPropertyChanged("Description");
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
        public void AddSweet()
        {
            Lemon = true;
            Sweet = true;
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Ingredients");
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
        /// <summary>
        /// new Description for Tyrannotea
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// new Description for Tyrannotea
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
