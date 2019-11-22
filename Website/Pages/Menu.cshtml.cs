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

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public float? minIMDB { get; set; }

        [BindProperty]
        public float? maxIMDB { get; set; }


        public Menu Menu { get; } = new Menu();

        public List<IMenuItem> AvailableMenuItems;
        public List<IMenuItem> AvailableCombo;

        public void OnGet()
        {
            AvailableMenuItems = Menu.AvailableMenuItems;
            AvailableCombo = Menu.AvailableCombos;
        }


        public void Onpost()
        {
            AvailableMenuItems = Menu.AvailableMenuItems;
            AvailableCombo = Menu.AvailableCombos;

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
            
            
        }
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
    }
}
