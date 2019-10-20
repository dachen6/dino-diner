using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// we use the base class 'size' for Fryceritops
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// call the size
        /// </summary>
        private Size size;



        /// <summary>
        /// determind the base price and calories
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            

        }
        /// <summary>
        /// add ingredients for Fryceritops
        /// </summary>
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
        /// <summary>
        /// determind the different price and claories with different size
        /// </summary>
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
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;

                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("price");
                NotifyOfPropertyChanged("Description");
            }
            get
            {

                return size;
            }
        }
        /// <summary>
        /// able yo print Friceritops with size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} Fryceritops";
        }
		public override string Description
		{
			get { return this.ToString(); }
		}
		public override string[] Special
		{
			get { return new string[0]; }
		}
	}
    
}

