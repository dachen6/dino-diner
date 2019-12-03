using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// input search
        /// </summary>
        [BindProperty]
        public string search { get; set; }
        /// <summary>
        /// ass possible Ingredient
        /// </summary>
        public List<string> PossibleIngredient;
        /// <summary>
        /// input menuCategory
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        /// <summary>
        /// input Ingredient Filter
        /// </summary>
        [BindProperty]
        public List<string> IngredientFilter { get; set; } = new List<string>();
        /// <summary>
        /// input minIMDB
        /// </summary>
        [BindProperty]
        public float? minIMDB { get; set; }

        /// <summary>
        /// input maxIMDB
        /// </summary>
        [BindProperty]
        public float? maxIMDB { get; set; }

        public Menu Menu { get; } = new Menu();
        /// <summary>
        /// all possible Item
        /// </summary>
        public List<IMenuItem> AvailableMenuItems;
        /// <summary>
        /// all possible combo
        /// </summary>
        public List<IMenuItem> AvailableCombo;

        /// <summary>
        /// the be initial page
        /// </summary>
        public void OnGet()
        {



            AvailableMenuItems = Menu.AvailableMenuItems;
            PossibleIngredient = Menu.AllPossibleIngredients(AvailableMenuItems);

           
        }

        /// <summary>
        /// page after click
        /// </summary>
        public void Onpost()
        {
            AvailableMenuItems = Menu.AvailableMenuItems;
            PossibleIngredient = Menu.AllPossibleIngredients(AvailableMenuItems);
       

            if (search != null)
            {
                AvailableMenuItems = Search(AvailableMenuItems, search);
            }

            if (menuCategory.Count != 0)
            {
                AvailableMenuItems = FilterByMPAA(AvailableMenuItems, menuCategory);
            }

            if (minIMDB != null)
            {
                AvailableMenuItems = FilterByBinIMDB(AvailableMenuItems, (float)minIMDB);
            }

            if (maxIMDB != null)
            {
                AvailableMenuItems = FilterByMaxIMDB(AvailableMenuItems, (float)maxIMDB);
            }

            if(IngredientFilter.Count!= 0)
            {
                AvailableMenuItems = removeing(AvailableMenuItems, IngredientFilter);
            }
            
            
        }
        /// <summary>
        /// check if contain the type
        /// </summary>
        /// <param name="item"></param>
        /// <param name="mpaa"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMPAA(List<IMenuItem> item, List<string> mpaa)
        {
            List<IMenuItem> results = new List<IMenuItem>();

           if (mpaa.Contains("Combo"))
            {
                results.AddRange(Menu.AvailableCombos);
            }
            if (mpaa.Contains("Entree"))
            {
                results.AddRange(Menu.AvailableEntrees);
            }
            if (mpaa.Contains("Side"))
            {
                results.AddRange(Menu.AvailableSides);
            }
            if (mpaa.Contains("Drink"))
            {
                results.AddRange(Menu.AvailableDrinks);
            }

            return results;
        }

        /// <summary>
        /// check if the menu contain base on input title
        /// </summary>
        /// <param name="item"></param>
        /// <param name="searchstring"></param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> item, string searchstring)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem Item in item)
            {
                if (Item.ToString().Contains(searchstring, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(Item);
                }
            }
            return result;
        }
        /// <summary>
        /// menu with prive greater than minIMDB
        /// </summary>
        /// <param name="item"></param>
        /// <param name="minIMDB"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByBinIMDB(List<IMenuItem> item, float minIMDB)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem Item in item)
            {
                if (Item.Price >= minIMDB)
                {
                    results.Add(Item);
                }
            }

            return results;
        }
        /// <summary>
        /// menu with prive less than maxIMDB
        /// </summary>
        /// <param name="item"></param>
        /// <param name="maxIMDB"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMaxIMDB(List<IMenuItem> item , float maxIMDB)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem Item in item)
            {
                if (Item.Price <= maxIMDB)
                {
                    results.Add(Item);
                }
            }

            return results;
        }
        /// <summary>
        /// remove item with Ingredients
        /// </summary>
        /// <param name="item"></param>
        /// <param name="remove"></param>
        /// <returns></returns>
        public static List<IMenuItem> removeing (List<IMenuItem> item,List<string> remove)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            int x = 1;
            foreach (IMenuItem Item in item)
            {
                foreach (string s in remove)
                {
                    if (Item.Ingredients.Contains(s))
                    {
                        x = 2;
                    }
                }
                if(x == 1)
                {
                    results.Add(Item);
                    
                }
                x = 1;
            }
                return results;
        }
    }
}
