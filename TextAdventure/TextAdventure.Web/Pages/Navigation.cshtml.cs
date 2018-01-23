using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TextAdventure.Model;

namespace TextAdventure.Web.Pages
{
    public class NavigationModel : PageModel
    {
        public void OnGet()
        {
            CurrentLocation = new Location()
            {
                Description = "test"
            };
        }

        [BindProperty]
        public Location CurrentLocation { get; set; }
    }
}