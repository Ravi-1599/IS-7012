using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RAVIP1599.Data;
using RAVIP1599.Models;

namespace RAVIP1599.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RAVIP1599.Data.ApplicationDbContext _context;

        public CreateModel(RAVIP1599.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "ID", "ISIN");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "ID", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "ID", "title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
