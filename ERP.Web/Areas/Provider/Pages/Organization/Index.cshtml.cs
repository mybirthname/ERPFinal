using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using ERP.Services.Provider;
using ERP.Services.Interfaces;

namespace ERP.Web.Areas.Provider.Pages.Organization
{
    public class IndexModel : PageModel
    {
        private readonly IOrganizationService _serivce;

        public IndexModel(IOrganizationService serivce)
        {
            _serivce = serivce;
        }

        public IList<ERP.Models.Organization> Organization { get;set; }

        public async Task OnGetAsync()
        {
            Organization = await _serivce.GetAllOrganizationRecords();
        }
    }
}
