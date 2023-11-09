using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BBBWebMVC.Models;

namespace BBBWebMVC.Data
{
    public class BBBWebMVCContext : DbContext
    {
        public BBBWebMVCContext (DbContextOptions<BBBWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BBBWebMVC.Models.GadgetModel> GadgetModel { get; set; } = default!;
    }
}
