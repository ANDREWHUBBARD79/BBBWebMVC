using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BBBWebMVC.Data;
using BBBWebMVC.Models;

namespace BBBWebMVC.Controllers
{
    public class CreateModel : PageModel
    {
        private readonly BBBWebMVC.Data.BBBWebMVCContext _context;

        public CreateModel(BBBWebMVC.Data.BBBWebMVCContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GadgetModel GadgetModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.GadgetModel == null || GadgetModel == null)
            {
                return Page();
            }

            _context.GadgetModel.Add(GadgetModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
