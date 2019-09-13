using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// items for Brontowurst
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// for people who like bun, peppersand onions
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        /// <summary>
        /// we can set and get the price and Calories
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        /// <summary>
        /// get what people want for Brontowurst
        /// </summary>
        public List<string> Ingredients
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
    }
}
