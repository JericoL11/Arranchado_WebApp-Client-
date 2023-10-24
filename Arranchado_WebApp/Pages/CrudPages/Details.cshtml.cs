using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Arranchado_WebApp.Data;
using Arranchado_WebApp.GenModels;

namespace Arranchado_WebApp.Pages.CrudPages
{
    public class DetailsModel : PageModel
    {
        private readonly Arranchado_WebApp.Data.Arranchado_WebAppContext _context;

        public DetailsModel(Arranchado_WebApp.Data.Arranchado_WebAppContext context)
        {
            _context = context;
        }

      public ClassModel ClassModel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ClassModel == null)
            {
                return NotFound();
            }

            var classmodel = await _context.ClassModel.FirstOrDefaultAsync(m => m.id == id);
            if (classmodel == null)
            {
                return NotFound();
            }
            else 
            {
                ClassModel = classmodel;
            }
            return Page();
        }
    }
}
