using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BBBWebMVC.Data;
using BBBWebMVC.Models;

namespace BBBWebMVC.Controllers
{
    public class EditModel : PageModel
    {
        private readonly BBBWebMVC.Data.BBBWebMVCContext _context;

        public EditModel(BBBWebMVC.Data.BBBWebMVCContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GadgetModel GadgetModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.GadgetModel == null)
            {
                return NotFound();
            }

            var gadgetmodel =  await _context.GadgetModel.FirstOrDefaultAsync(m => m.Id == id);
            if (gadgetmodel == null)
            {
                return NotFound();
            }
            GadgetModel = gadgetmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GadgetModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GadgetModelExists(GadgetModel.Id))
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

        private bool GadgetModelExists(int id)
        {
          return (_context.GadgetModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
