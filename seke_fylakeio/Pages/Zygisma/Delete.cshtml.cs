using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using seke_fylakeio.Data;

namespace seke_fylakeio.Pages.Zygisma
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public seke_fylakeio.Model.Zygisma Zygisma { get; set; }

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zygisma = await _context.Zygisma.FindAsync(id);

            if (Zygisma != null)
            {
                _context.Zygisma.Remove(Zygisma);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
