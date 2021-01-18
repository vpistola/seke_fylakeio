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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
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

        #region post
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if ((Zygisma.GrossWeight - Zygisma.NetWeight) != Zygisma.TareWeight)
                Zygisma.IsOk = false;
            else
                Zygisma.IsOk = true;

            _context.Attach(Zygisma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZygismaExists(Zygisma.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ZygismaExists(int id)
        {
            return _context.Zygisma.Any(e => e.Id == id);
        }
        #endregion



    }
}
