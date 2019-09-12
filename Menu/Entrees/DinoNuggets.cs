using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private bool Nugget = true;
        uint x = 6;
        uint nuggetCount;
        public double Price { get; set; }
        public uint Calories { get; set; }
        
        public List<string> Ingredients
        {
           
            get
            {   

                List<string> ingredients = new List<string>() { "" };
                for(int i = 0; i < 6; i++)
                {
                     ingredients.Add("Chicken Nugget");

                    nuggetCount++;
                }
                return ingredients;
            }

        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
        }

        public void AddNugget()
        {
            this.nuggetCount++;
            Ingredients.Add("Peanut Butter");
            this.Price += 0.25;
            this.Calories = 59 * nuggetCount; 
        }

    }
}
