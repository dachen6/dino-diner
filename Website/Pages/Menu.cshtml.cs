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
        public List<string> type { get; set; } = new List<string>();

        public Menu Menu { get; } = new Menu();

        public List<IMenuItem> AvailableMenuItems;
        public void OnGet()
        {
            AvailableMenuItems = Menu.AvailableMenuItems;
        }


        public void Onpost()
        {
            AvailableMenuItems = Menu.AvailableMenuItems;

            if (search != null && mapp.Count != 0)
            {
                Movies = MovieDatabase.SearchAndFilter(search, mapp);
            }
            else if (mapp.Count != 0)
            {
                Movies = MovieDatabase.Filter(mapp);
            }

            else if (search != null)
            {
                Movies = MovieDatabase.Search(Movies, search);
            }


            if (mapp.Count != 0)
            {
                Movies = MovieDatabase.FilterByMPAA(Movies, mapp);
            }

            if (minIMDB != null)
            {
                Movies = MovieDatabase.FilterByBinIMDB(Movies, (float)minIMDB);
            }
            if (maxIMDB != null)
            {
                Movies = MovieDatabase.FilterByMaxIMDB(Movies, (float)maxIMDB);
            }
        }
    }
}