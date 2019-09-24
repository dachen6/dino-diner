using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon = true;
        
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
        public void AddLemon()
        {
            this.Lemon = false;
        }
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }
    }
}
