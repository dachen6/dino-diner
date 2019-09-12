using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "brautwurst" };
                if (bun) ingredients.Add("whole-wheat bun");
                if (onions) ingredients.Add("onions");
                if (peppers) ingredients.Add("peppers");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void Holdbun()
        {
            this.bun = false;
        }

        public void Holdpeppers()
        {
            this.peppers = false;
        }
        public void Holdonions()
        {
            this.onions = false;
        }
    }
}
