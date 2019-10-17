using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// using the base class size for MeteorMacAndCheese
    /// </summary>
    public class MeteorMacAndCheese: Side ,INotifyPropertyChanged, IOrderItem
	{

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyOfPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		/// <summary>
		/// add ingredient to MeteorMacAndCheese
		/// </summary>
		public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }

        }
        /// <summary>
        /// determind different price and Calories with size for MeteorMacAndCheese
        /// </summary>
        private Size size;
            public override Size Size
            {
                set
                {
                    this.size = value;
                    switch (size)
                    {
                        case Size.Small:
                            this.Price = 0.99;
                            this.Calories = 420;
                            break;
                        case Size.Medium:
                            this.Price = 1.45;
                            this.Calories = 490;
                        break;
                        case Size.Large:
                            this.Price = 1.95;
                            this.Calories = 520;
                        break;

                    }
                }
                get { return this.size; }
            }
        /// <summary>
        /// determind the base price and calories
        /// </summary>
            public MeteorMacAndCheese()
            {
                this.Price = 0.99;
                this.Calories = 420;

            }
        /// <summary>
        ///able to print Meteor Mac and Cheese and its size
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} Meteor Mac and Cheese";
        }
		public string Description
		{
			get { return this.ToString(); }
		}
		public string[] Special
		{
			get
			{
				return new string[0];
			}
		}
	}
    }

