using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ERP.Data;
using ERP.Models;
using Dtos.User;
using ERP.Services.Administration;
using ERP.Services.Interfaces;
using ERP.Common;

namespace ERP.Web.Areas.Administration.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly IUsersService _usersService;

        public CreateModel(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ManageAccountInputModel UserModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();


            var result = await _usersService.CreateRecord(UserModel);

            foreach(var error in result)
            {
                ModelState.AddModelError(string.Empty, error.Description);
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}