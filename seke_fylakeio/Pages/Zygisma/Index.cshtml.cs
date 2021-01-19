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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<seke_fylakeio.Model.Zygisma> Zygisma{ get; set; }


        public async Task OnGetAsync()
        {
            var zygisma = _context.Zygisma.Where(x => x.Active).OrderByDescending(x => x.DateCreated);

            Zygisma = await zygisma.ToListAsync();

            foreach (var item in Zygisma)
            {
                if ((item.GrossWeight - item.NetWeight) != item.TareWeight)
                    item.IsOk = false;
                else
                    item.IsOk = true;
            }
        }

    }
}
