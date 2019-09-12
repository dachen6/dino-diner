using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;


        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "three steakburger pattie " };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("lettuce");
                if (tomato) ingredients.Add("tomato");
                if (onion) ingredients.Add("onion");
                if (pickle) ingredients.Add("pickle");
                if (ketchup) ingredients.Add("ketchup");
                if (mustard) ingredients.Add("mustard");
                if (mayo) ingredients.Add("mayo");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void Holdlettuce()
        {
            this.lettuce = false;
        }
        public void Holdtomato()
        {
            this.tomato = false;
        }

        public void Holdonion()
        {
            this.onion = false;
        }
        public void Holdpickle()
        {
            this.pickle = false;
        }
        public void Holdketchup()
        {
            this.ketchup = false;
        }
        public void Holdmustard()
        {
            this.mustard = false;
        }
        public void Holdmayo()
        {
            this.mayo = false;
        }


    }
}
