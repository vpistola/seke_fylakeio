using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using seke_fylakeio.Data;

namespace seke_fylakeio.Pages.Zygisma
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public seke_fylakeio.Model.Zygisma Zygisma { get; set; }


        #region get details
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zygisma = await _context.Zygisma.FirstOrDefaultAsync(m => m.Id == id);

            if (Zygisma == null)
            {
                return NotFound();
            }
            return Page();
        }
        #endregion


    }
}
