using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees

{
    /// <summary>
    /// items for DinoNuggets
    /// </summary>
    public class DinoNuggets
    {
        private int count = 6;
        /// <summary>
        /// we can set and get the price and Calories
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        /// <summary>
        /// get what people want for DinoNuggets
        /// </summary>
        public List<string> Ingredients
        {
           
            get
            {   

                List<string> ingredients = new List<string>() { };
                for(int i = 0; i < count ; i++)
                {
                     ingredients.Add("Chicken Nugget");

                }
                return ingredients;
            }

        }
        /// <summary>
        /// we set price and Calories
        /// </summary
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }
        /// <summary>
        /// for people who want to add more nugget 
        /// we should add price and calories
        /// </summary>
        public void AddNugget()
        {

            count += 1; 
            Ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Calories += 59; 
        }

    }
}
