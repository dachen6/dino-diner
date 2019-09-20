using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops :Side{

        private Size size;

        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;


        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
            
        }

        public override Size Size
        {
            set
            {
                this.size = value;
                switch (size)
                {
                    
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 220;
                        this.size = Size.Small;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        this.size = Size.Medium;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        this.size = Size.Large;
                        break;

                }
            }
            get { return size;}
        }

    }
    
}

