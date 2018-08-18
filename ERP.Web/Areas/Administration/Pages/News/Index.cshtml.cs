using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP.Models;
using Dtos.Administration.News;
using ERP.Services.Interfaces;

namespace ERP.Web.Areas.Administration.Pages.News
{
    public class IndexModel : PageModel
    {

        private readonly INewsService _newsService;

        public IndexModel(INewsService newsService)
        {
            _newsService = newsService;
        }

        public List<ERP.Models.News> InputNews { get; set; }

        public async Task OnGetAsync()
        {
            InputNews = await _newsService.GetAllNewsRecords();
        }

        public async Task OnPostDelete(int id)
        {
            await _newsService.DeleteRecord(id);
            InputNews = await _newsService.GetAllNewsRecords();
        }

    }
}
