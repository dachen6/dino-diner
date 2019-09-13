using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// items for TRexKingBurger
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// for people who like bun, Lettuce,Tomato,Onion,Pickle,Ketchup,Mustard and Mayo
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// we can set and get the price and Calories
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        /// <summary>
        /// get what people want for TRexKingBurger
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// we set price and Calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// for people don't want Whole Wheat Bu
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// for people don't want lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// for people don't want tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// for people don't want onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// for people don't want pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// for people don't want ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// for people don't want mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// for people don't want Mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }


    }
}
