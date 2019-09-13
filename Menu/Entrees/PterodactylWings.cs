using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{    /// <summary>
     /// items for PterodactylWings
     /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// for people who like chicken and wingSause
        /// </summary>
        private bool Chicken = true;
        private bool WingSauce = true;

        /// <summary>
        /// we can set and get the price and Calories
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        /// <summary>
        /// get what people want for PterodactylWings
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (Chicken) ingredients.Add("Chicken");
                if (WingSauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }
        /// <summary>
        /// we set price and Calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }


    }
}
