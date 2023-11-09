using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BBBWebMVC.Data;
using BBBWebMVC.Models;

namespace BBBWebMVC.Controllers
{
    public class DetailsModel : PageModel
    {
        private readonly BBBWebMVC.Data.BBBWebMVCContext _context;

        public DetailsModel(BBBWebMVC.Data.BBBWebMVCContext context)
        {
            _context = context;
        }

      public GadgetModel GadgetModel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.GadgetModel == null)
            {
                return NotFound();
            }

            var gadgetmodel = await _context.GadgetModel.FirstOrDefaultAsync(m => m.Id == id);
            if (gadgetmodel == null)
            {
                return NotFound();
            }
            else 
            {
                GadgetModel = gadgetmodel;
            }
            return Page();
        }
    }
}
