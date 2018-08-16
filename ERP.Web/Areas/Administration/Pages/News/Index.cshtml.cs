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
    public class IndexModel : PageModel
    {
        private readonly ERPContext _context;

        public IndexModel(ERP.Data.ERPContext context)
        {
            _context = context;
        }

        public IList<NewsInputModel> News { get;set; }

        public async Task OnGetAsync()
        {
            var news = await _context.News.ToListAsync();
        }
    }
}
