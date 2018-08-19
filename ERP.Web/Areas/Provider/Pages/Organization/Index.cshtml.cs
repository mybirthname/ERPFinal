using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;

namespace ERP.Web.Areas.Provider.Pages.Organization
{
    public class IndexModel : PageModel
    {
        private readonly ERP.Data.ERPContext _context;

        public IndexModel(ERP.Data.ERPContext context)
        {
            _context = context;
        }

        public IList<ERP.Models.Organization> Organization { get;set; }

        public async Task OnGetAsync()
        {
            Organization = await _context.Organizations.ToListAsync();
        }
    }
}
