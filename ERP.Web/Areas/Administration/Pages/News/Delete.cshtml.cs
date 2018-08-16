using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using Dtos.Administration.News;

namespace ERP.Web.Areas.Administration.Pages.News
{
    public class DeleteModel : PageModel
    {
        private readonly ERP.Data.ERPContext _context;

        public DeleteModel(ERP.Data.ERPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NewsInputModel InputModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FirstOrDefaultAsync(m => m.ID == id);

            if (news == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);

            if (news != null)
            {
                _context.News.Remove(news);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
