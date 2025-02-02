﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    /// <summary>
    /// the menu to show all the people order
    /// </summary>
    public class Menu
    {


        /// <summary>
        /// contain all kind of Ingredients
        /// </summary>
        public HashSet<string> PossibleIngredients = new HashSet<string>();
        public List<string> PossibleIngredient;
        /// <summary>
        /// list all the entree
        /// </summary>
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };
        /// <summary>
        /// list all the side
        /// </summary>
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
        };
        /// <summary>
        /// list all the drink
        /// </summary>
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new Sodasaurus(),
            new Tyrannotea(),
            new JurassicJava(),
            new Water(),
        };
        /// <summary>
        /// list all the combo
        /// </summary>
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
           new CretaceousCombo ( new Brontowurst()),
           new CretaceousCombo ( new DinoNuggets()),
           new CretaceousCombo ( new PrehistoricPBJ()),
           new CretaceousCombo ( new PterodactylWings()),
           new CretaceousCombo ( new SteakosaurusBurger()),
           new CretaceousCombo ( new TRexKingBurger()),
           new CretaceousCombo ( new VelociWrap())
        };
        /// <summary>
        /// list all the menu item
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> item = new List<IMenuItem>();
                item.AddRange(AvailableCombos);
                item.AddRange(AvailableDrinks);
                item.AddRange(AvailableSides);
                item.AddRange(AvailableEntrees);
                return item;
            }
        }
        /// <summary>
        /// stone all the PossibleIngredients into list
        /// </summary>
        /// <param name="AvailableMenuItems"></param>
        /// <returns></returns>
        public List<string> AllPossibleIngredients(List<IMenuItem> AvailableMenuItems)
        {
            foreach(IMenuItem menu in AvailableMenuItems)
            {
                foreach(string s in menu.Ingredients)
                {
                    PossibleIngredients.Add(s);
                }
            }
            return PossibleIngredient = PossibleIngredients.ToList();

        }
     


        /// <summary>
        /// print the menu item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           foreach(object i in AvailableMenuItems)
            {
                sb.Append(i.ToString()+"\n");

            }
            return sb.ToString();
        }
    }
}
