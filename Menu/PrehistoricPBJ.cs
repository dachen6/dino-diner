using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// items for PrehistoricPBJ using base class entree
    /// </summary>
    public class PrehistoricPBJ:Entree 
    {
		


        /// <summary>
        /// for people want peanutButte and jelly
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;
		/// <summary>
		/// An event hander for PeoperyuChanged event
		/// </summary>

	
		/// <summary>
		/// get what people want for PrehistoricPBJ
		/// </summary>
		public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// we set price and Calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// for people don't want PeanutButter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// for people don't want Jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// able to print Prehistoric PB&J
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
        /// <summary>
        /// new Description for Prehistoric PB&J
        /// </summary>
        public override string Description
        {
            get{return this.ToString();}           
        }
        /// <summary>
        /// new Description for Prehistoric PB&J
        /// </summary>

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(!peanutButter) special.Add("Hold Peanut Butter");
                if(!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }


	}
}
