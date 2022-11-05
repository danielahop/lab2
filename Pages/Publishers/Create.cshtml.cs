using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hopirtean_Daniela_Lab3.Data;
using Hopirtean_Daniela_Lab3.Models;

namespace Hopirtean_Daniela_Lab3.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Hopirtean_Daniela_Lab3.Data.Hopirtean_Daniela_Lab3Context _context;

        public CreateModel(Hopirtean_Daniela_Lab3.Data.Hopirtean_Daniela_Lab3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
