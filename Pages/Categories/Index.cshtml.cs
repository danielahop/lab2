using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hopirtean_Daniela_Lab3.Data;
using Hopirtean_Daniela_Lab3.Models;

namespace Hopirtean_Daniela_Lab3.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Hopirtean_Daniela_Lab3.Data.Hopirtean_Daniela_Lab3Context _context;

        public IndexModel(Hopirtean_Daniela_Lab3.Data.Hopirtean_Daniela_Lab3Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
