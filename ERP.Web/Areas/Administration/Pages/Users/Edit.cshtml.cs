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
using Dtos.User;
using ERP.Services.Administration;
using ERP.Services.Interfaces;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Extensions.Localization;

namespace ERP.Web.Areas.Administration.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly IUsersService _usersService;
        private readonly IStringLocalizer<SharedResources> _localizer;


        public EditModel(IUsersService usersService, IStringLocalizer<SharedResources> localizer)
        {
            _usersService = usersService;
            _localizer = localizer;
        }

        [BindProperty]
        public ManageAccountInputModel UserModel { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
                return NotFound();

            UserModel = await _usersService.GetUserByID(id);

            if (UserModel == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _usersService.UpdateRecord(UserModel);

            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostAddRole()
        {
            UserRoleTransferObject resultClass = GetTransferObjectData();

            var result = await _usersService.AddRole(resultClass);

            if (!string.IsNullOrEmpty(result.Message))
                result.Message = _localizer[result.Message];

            JsonResult json = new JsonResult(result);
            return json;
        }

        private UserRoleTransferObject GetTransferObjectData()
        {
            MemoryStream stream = new MemoryStream();
            Request.Body.CopyTo(stream);
            stream.Position = 0;

            UserRoleTransferObject resultClass = new UserRoleTransferObject();
            using (StreamReader reader = new StreamReader(stream))
            {
                string requestBody = reader.ReadToEnd();
                if (requestBody.Length > 0)
                {
                    resultClass = JsonConvert.DeserializeObject<UserRoleTransferObject>(requestBody);
                }
            }

            return resultClass;
        }



        public async Task<IActionResult> OnPostRemoveRole()
        {
            UserRoleTransferObject resultClass = GetTransferObjectData();

            var result = await _usersService.RemoveRole(resultClass);

            if (!string.IsNullOrEmpty(result.Message))
                result.Message = _localizer[result.Message];

            JsonResult json = new JsonResult(result);
            return json;
        }
    }
}
