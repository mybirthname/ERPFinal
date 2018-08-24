using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;
using Microsoft.AspNetCore.Authorization;
using ERP.Services.Interfaces;
using Dtos.OrderProcess;

namespace ERP.Web.Areas.OrderProcess.Controllers
{
    [Area("OrderProcess")]
    [Authorize(Policy = "OrderPolicy")]
    public class OrdersController : Controller
    {

        private readonly IOrderService _service;

        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _service.GetAllRecords();

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderInputModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _service.CreateNewRecord(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: OrderProcess/Orders/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var order = await _service.GetByID(id.Value);

            if (order == null)
                return NotFound();

            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OrderInputModel model)
        {

            if (!ModelState.IsValid)
                return View(model);

            await _service.UpdateRecord(model);

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteRecord(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
