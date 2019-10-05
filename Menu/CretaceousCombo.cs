using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// the combo when people want to order combo
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// the entree of the combo
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// the side of the combo
        /// </summary>
        private Side side;
        /// <summary>
        /// should get and set the side
        /// </summary>
        public Side Side {
            get { return side; }
            set {
                side = value;
                this.side.Size = this.size; } }
        /// <summary>
        /// drink of the combo
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// the price is total of entree side and drink
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price-0.25;
            }
        }
        /// <summary>
        /// the Calories is total of entree side and drink
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// the origial size is small
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// able to size of combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }
        /// <summary>
        /// list all item in combo
        /// </summary>
        public  List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// the base case of combo
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }
        /// <summary>
        /// able to print all combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree.ToString()} Combo";
        }
    }
}
