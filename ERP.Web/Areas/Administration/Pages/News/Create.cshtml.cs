using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ERP.Data;
using ERP.Models;
using Dtos.Administration.News;

namespace ERP.Web.Areas.Administration.Pages.News
{
    public class CreateModel : PageModel
    {
        private readonly ERP.Data.ERPContext _context;

        public CreateModel(ERP.Data.ERPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NewsInputModel InputModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.News.Add(News);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}