using System.Collections.Generic;

namespace DinoDiner.Menu
{    /// <summary>
     /// items for VelociWrap using base class entree
     /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// for people want Ceasar Dressing,Romaine Lettuce and Parmesan Cheese
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        ///<summary>
        /// get what people want for VelociWrap
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" ,"Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// we set price and Calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// for people don't want Ceasar Dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// for people don't want Romaine Lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// for people don't want Parmesan Cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
        /// <summary>
        /// able to print Veloci-Wrap
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
