using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using ERP.Services.Provider;
using Dtos.Organization;
using ERP.Services.Interfaces;
using ERP.RazorLibrary.Helpers.Messages;
using Microsoft.Extensions.Localization;

namespace ERP.Web.Controllers
{
    public class OrganizationsController : Controller
    {
        private readonly IOrganizationService _service;
        private const string _message = "__Message";
        private const string _type = "__Type";
        private readonly IStringLocalizer<SharedResources> _localizedString;

        public OrganizationsController(IOrganizationService service, IStringLocalizer<SharedResources> stringLocalizer)
        {
            _service = service;
            _localizedString = stringLocalizer;
        }


        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var organization = await _service.GetModelByID(id.Value);

            if (organization == null)
                return NotFound();


            return View(organization);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OrganizationInputeModel model)
        {
            if (!ModelState.IsValid)
            {
                string errMsg = _localizedString["ErrorOnOrganizationSave"];
                TempData[_message] = errMsg;
                TempData[_type] = "Danger";

                return View(model);
            }

            await _service.Update(model);

            string msg = _localizedString["OrganizationUpdatedSuccessfully"];

            TempData[_message] = msg;
            TempData[_type] = "Success";

            return RedirectToAction(nameof(Edit));

        }


    }
}
