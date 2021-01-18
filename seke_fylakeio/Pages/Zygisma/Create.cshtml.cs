using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using seke_fylakeio.Data;
using seke_fylakeio.Model;

namespace seke_fylakeio.Pages.Zygisma
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //Movie = new Movie
            //{
            //    Genre = "Action",
            //    Price = 1.99m,
            //    ReleaseDate = DateTime.Now,
            //    Title = "Conan"
            //    , Rating = "R"
            //};
            return Page();
        }


        [BindProperty]
        public seke_fylakeio.Model.Zygisma Zygisma { get; set; }

        #region snippet
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Zygisma.Add(Zygisma);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        #endregion
    }

}
