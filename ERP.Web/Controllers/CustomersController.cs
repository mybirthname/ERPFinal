using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Dtos.Customer;
using Microsoft.AspNetCore.Authorization;

namespace ERP.Web.Controllers
{
    [Authorize(Policy = "CustomerPolicy")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var model = await _service.GetAllRecords();
            return View(model);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerInputeModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _service.CreateNewRecord(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var customer = await _service.GetByID(id.Value);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerInputeModel model)
        {

            if (!ModelState.IsValid)
                return View(model);

            await _service.UpdateRecord(model);

            return RedirectToAction(nameof(Index));
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteRecord(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
