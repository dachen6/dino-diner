using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        private bool Chicken = true;
        private bool WingSauce = true;


        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                if (Chicken) ingredients.Add("Chicken");
                if (WingSauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }


    }
}
