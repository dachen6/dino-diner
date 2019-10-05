using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// given all kind of falvor
        /// </summary>
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor{
            get { return flavor; }
            set { flavor = value; }
    }
        /// <summary>
        /// change price and calories of Sodasauruwith size
        /// </summary>
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
        /// <summary>
        /// show waht in Sodasaurus
        /// </summary>
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
        /// <summary>
        /// set the base price and calories in Sodasaurus
        /// </summary>
        public Sodasaurus(){
            this.Price = 1.50;
            this.Calories = 112;
            
        }
        public override string ToString()
        {
            return $"{size.ToString()} {flavor.ToString()} Sodasaurus";
        
        }
    }
}
