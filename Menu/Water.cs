﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// Drink water 
    /// </summary>
    public class Water : Drink
    {

        /// <summary>
        /// set we don't add lemon in the begineer
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// Change size can't change the price and calories
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.10;
                        this.Calories = 0;
                        break;
                    case Size.Medium:
                        this.Price = 0.10;
                        this.Calories = 0;
                        break;
                    case Size.Large:
                        this.Price = 0.10;
                        this.Calories = 0;
                        break;

                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
            get { return size; }

        }

        /// <summary>
        /// write the type of drink for costome
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (Lemon) ingredients.Add("Lemon");
                ingredients.Add("Water");
                return ingredients;
            }

        }
        /// <summary>
        /// Add lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// set water price and calories
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }
        /// <summary>
        /// able to print water and its size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} Water";
        }
        /// <summary>
        /// new Description for Water
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// new Special for Water
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
