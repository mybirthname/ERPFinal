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
using ERP.Services.Administration;
using ERP.Services.Interfaces;

namespace ERP.Web.Areas.Administration.Pages.News
{
    public class CreateModel : PageModel
    {
        private readonly INewsService _service;

        public CreateModel(INewsService service)
        {
            _service = service;
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
                return Page();

            await _service.CreateNewsRecord(InputModel);

            return RedirectToPage("./Index");
        }
    }
}