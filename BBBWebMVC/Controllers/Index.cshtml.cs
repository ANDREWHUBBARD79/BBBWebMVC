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
    public class IndexModel : PageModel
    {
        private readonly BBBWebMVC.Data.BBBWebMVCContext _context;

        public IndexModel(BBBWebMVC.Data.BBBWebMVCContext context)
        {
            _context = context;
        }

        public IList<GadgetModel> GadgetModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.GadgetModel != null)
            {
                GadgetModel = await _context.GadgetModel.ToListAsync();
            }
        }
    }
}
