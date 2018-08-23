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
using Dtos.Supplier;
using Microsoft.AspNetCore.Authorization;

namespace ERP.Web.Controllers
{
    [Authorize(Roles = "SuperAdmin, Supplier")]
    public class SuppliersController : Controller
    {
        private readonly ISupplierService _service;

        public SuppliersController(ISupplierService service)
        {
            _service = service;
        }

        // GET: Suppliers
        public async Task<IActionResult> Index()
        {
            var list = await _service.GetAllRecords();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(SupplierInputModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _service.CreateNewRecord(model);

            return RedirectToAction(nameof(Index));
        }

        // GET: Suppliers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var supplier = await _service.GetByID(id.Value);

            if (supplier == null)
                return NotFound();

            return View(supplier);
        }

        // POST: Suppliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SupplierInputModel model)
        {

            if (!ModelState.IsValid)
                return View(model);
            

            await _service.UpdateRecord(model);

            return RedirectToAction(nameof(Index));
        }



        // POST: Suppliers/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteRecord(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
