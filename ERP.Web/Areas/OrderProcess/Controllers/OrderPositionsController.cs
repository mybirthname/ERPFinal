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

namespace ERP.Web.Areas.OrderProcess.Controllers
{
    [Area("OrderProcess")]
    [Authorize(Policy ="OrderPolicy")]
    public class OrderPositionsController : Controller
    {
        private readonly ERPContext _context;

        public OrderPositionsController(ERPContext context)
        {
            _context = context;
        }

        // GET: OrderProcess/OrderPositions
        public async Task<IActionResult> Index()
        {
            var eRPContext = _context.OrderPositions.Include(o => o.Order);
            return View(await eRPContext.ToListAsync());
        }

        // GET: OrderProcess/OrderPositions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPosition = await _context.OrderPositions
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (orderPosition == null)
            {
                return NotFound();
            }

            return View(orderPosition);
        }

        // GET: OrderProcess/OrderPositions/Create
        public IActionResult Create()
        {
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern");
            return View();
        }

        // POST: OrderProcess/OrderPositions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Quantity,Price,OrderID,AttachmentPath,Description,ID,NrIntern,UserID,CreateBy,UpdateBy,CreateDate,UpdateDate,OrganizationID,Remark,Deleted")] OrderPosition orderPosition)
        {
            if (ModelState.IsValid)
            {
                orderPosition.ID = Guid.NewGuid();
                _context.Add(orderPosition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern", orderPosition.OrderID);
            return View(orderPosition);
        }

        // GET: OrderProcess/OrderPositions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPosition = await _context.OrderPositions.FindAsync(id);
            if (orderPosition == null)
            {
                return NotFound();
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern", orderPosition.OrderID);
            return View(orderPosition);
        }

        // POST: OrderProcess/OrderPositions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Title,Quantity,Price,OrderID,AttachmentPath,Description,ID,NrIntern,UserID,CreateBy,UpdateBy,CreateDate,UpdateDate,OrganizationID,Remark,Deleted")] OrderPosition orderPosition)
        {
            if (id != orderPosition.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderPosition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderPositionExists(orderPosition.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern", orderPosition.OrderID);
            return View(orderPosition);
        }

        // GET: OrderProcess/OrderPositions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPosition = await _context.OrderPositions
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (orderPosition == null)
            {
                return NotFound();
            }

            return View(orderPosition);
        }

        // POST: OrderProcess/OrderPositions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var orderPosition = await _context.OrderPositions.FindAsync(id);
            _context.OrderPositions.Remove(orderPosition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderPositionExists(Guid id)
        {
            return _context.OrderPositions.Any(e => e.ID == id);
        }
    }
}
