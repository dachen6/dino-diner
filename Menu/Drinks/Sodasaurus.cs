using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor{
            get { return flavor; }
            set { flavor = value; }
    }
    public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;

                }
            }
            get { return size; }

        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Natural Flavors");
                ingredients.Add("Water");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }

        }
        public Sodasaurus(){
            this.Price = 1.50;
            this.Calories = 112;
            
    }
    }
}
