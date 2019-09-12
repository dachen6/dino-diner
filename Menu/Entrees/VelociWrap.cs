using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "flour tortilla" ,"chicken breast" };
                if (dressing) ingredients.Add(" Ceasar dressing");
                if (lettuce) ingredients.Add("romaine lettuce");
                if (cheese) ingredients.Add("parmesan cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 728;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }
       public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
