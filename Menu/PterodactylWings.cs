using System.Collections.Generic;

namespace DinoDiner.Menu
{    /// <summary>
     /// items for PterodactylWings using base class entree
     /// </summary>
    public class PterodactylWings:Entree
    {
        /// <summary>
        /// for people who like chicken and wingSause
        /// </summary>
        private bool Chicken = true;
        private bool WingSauce = true;


        /// <summary>
        /// get what people want for PterodactylWings
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// able tp print Pterodactyl Wings
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

    }
}
