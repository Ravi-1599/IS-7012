using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RAVIP1599.Data;
using RAVIP1599.Models;

namespace RAVIP1599.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RAVIP1599.Data.ApplicationDbContext _context;

        public IndexModel(RAVIP1599.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
