﻿using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// items for Brontowurst using base class entree
    /// </summary>
    public class Brontowurst:Entree
    {
        /// <summary>
        /// for people who like bun, peppersand onions
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// get what people want for Brontowurst
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (onions) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }
        /// <summary>
        /// we set price and Calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// for people don't want bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// for people don't want peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// for people don't want Onion
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
        /// <summary>
        /// able to print Brontowurst
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
