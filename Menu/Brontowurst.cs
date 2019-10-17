using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// items for Brontowurst using base class entree
    /// </summary>
    public class Brontowurst:Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// for people who like bun, peppersand onions
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// get what people want for Brontowurst
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (onions) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }
        /// <summary>
        /// we set price and Calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// for people don't want bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// for people don't want peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// for people don't want Onion
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// able to print Brontowurst
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (bun) special.Add("Whole Wheat Bun");
                if (onions) special.Add("Onion");
                if (peppers) special.Add("Peppers");
                return special.ToArray();
            }
        }
    }
}
