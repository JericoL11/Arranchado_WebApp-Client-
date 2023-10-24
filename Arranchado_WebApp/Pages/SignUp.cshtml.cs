using Arranchado_WebApp.GenModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Arranchado_WebApp.Pages
{
    public class SignUpModel : PageModel
    {
        private readonly Arranchado_WebApp.Data.Arranchado_WebAppContext _context;

        public SignUpModel(Arranchado_WebApp.Data.Arranchado_WebAppContext context)
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
