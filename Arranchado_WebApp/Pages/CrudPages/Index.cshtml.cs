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
    public class IndexModel : PageModel
    {
        private readonly Arranchado_WebApp.Data.Arranchado_WebAppContext _context;

        public IndexModel(Arranchado_WebApp.Data.Arranchado_WebAppContext context)
        {
            _context = context;
        }

        public IList<ClassModel> ClassModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ClassModel != null)
            {
                ClassModel = await _context.ClassModel.ToListAsync();
            }
        }
    }
}
