using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RAVIP1599.Data;
using RAVIP1599.Models;

namespace RAVIP1599.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RAVIP1599.Data.ApplicationDbContext _context;

        public IndexModel(RAVIP1599.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
