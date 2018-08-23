using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using Dtos.User;
using ERP.Services.Administration;
using ERP.Services.Interfaces;

namespace ERP.Web.Areas.Administration.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IUsersService _service;

        public IndexModel(IUsersService service)
        {
            _service = service;
        }

        public List<User> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _service.GetAllUsersRecords();
        }

        public async Task OnPostDelete(string id)
        {
            await _service.DeleteRecord(id);
            Users = await _service.GetAllUsersRecords();
        }

    }
}
