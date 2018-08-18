using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using Dtos.Administration.News;
using ERP.Services.Interfaces;

namespace ERP.Web.Areas.Administration.Pages.News
{
    public class EditModel : PageModel
    {
        private readonly INewsService _service;

        public EditModel(INewsService service)
        {
            _service = service;
        }

        [BindProperty]
        public NewsInputModel InputModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            InputModel = await _service.GetNewsByID(id.Value);

            if (InputModel == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.UpdateRecord(InputModel);

            return RedirectToPage("./Index");
        }
    }
}
