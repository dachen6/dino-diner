using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu

{
	/// <summary>
	/// items for DinoNuggets using base class entree
	/// </summary>
	public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        private int count = 6;

        /// <summary>
        /// get what people want for DinoNuggets
        /// </summary>
        public override List<string> Ingredients
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// able to print Dino-Nuggets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
		public override string Description
		{
			get { return this.ToString(); }
		}
		public override string[] Special
		{
            get {
                if(count == 6)
                {
                    return new string[0];
                }
                return new string[] { $"{count - 6} Extra Nuggets" };
            }
		}
	}
}
