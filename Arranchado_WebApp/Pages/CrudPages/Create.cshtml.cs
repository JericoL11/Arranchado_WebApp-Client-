using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Arranchado_WebApp.Data;
using Arranchado_WebApp.GenModels;

namespace Arranchado_WebApp.Pages.CrudPages
{
    public class CreateModel : PageModel
    {
        private readonly Arranchado_WebApp.Data.Arranchado_WebAppContext _context;

        public CreateModel(Arranchado_WebApp.Data.Arranchado_WebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClassModel ClassModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ClassModel == null || ClassModel == null)
            {
                return Page();
            }

            _context.ClassModel.Add(ClassModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
