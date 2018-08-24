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
    [Authorize(Policy = "InvoicePolicy")]
    public class InvoicesController : Controller
    {
        private readonly ERPContext _context;

        public InvoicesController(ERPContext context)
        {
            _context = context;
        }

        // GET: OrderProcess/Invoices
        public async Task<IActionResult> Index()
        {
            var eRPContext = _context.Invoices.Include(i => i.Order).Include(i => i.SupplierOrganization);
            return View(await eRPContext.ToListAsync());
        }

        // GET: OrderProcess/Invoices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices
                .Include(i => i.Order)
                .Include(i => i.SupplierOrganization)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // GET: OrderProcess/Invoices/Create
        public IActionResult Create()
        {
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern");
            ViewData["SupplierOrganizationID"] = new SelectList(_context.Organizations, "ID", "ID");
            return View();
        }

        // POST: OrderProcess/Invoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,SendDate,Status,AmountNet,SupplierOrganizationID,OrderID,ID,NrIntern,UserID,CreateBy,UpdateBy,CreateDate,UpdateDate,OrganizationID,Remark,Deleted")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                invoice.ID = Guid.NewGuid();
                _context.Add(invoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern", invoice.OrderID);
            ViewData["SupplierOrganizationID"] = new SelectList(_context.Organizations, "ID", "ID", invoice.SupplierOrganizationID);
            return View(invoice);
        }

        // GET: OrderProcess/Invoices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern", invoice.OrderID);
            ViewData["SupplierOrganizationID"] = new SelectList(_context.Organizations, "ID", "ID", invoice.SupplierOrganizationID);
            return View(invoice);
        }

        // POST: OrderProcess/Invoices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Title,Description,SendDate,Status,AmountNet,SupplierOrganizationID,OrderID,ID,NrIntern,UserID,CreateBy,UpdateBy,CreateDate,UpdateDate,OrganizationID,Remark,Deleted")] Invoice invoice)
        {
            if (id != invoice.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(invoice.ID))
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
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "NrIntern", invoice.OrderID);
            ViewData["SupplierOrganizationID"] = new SelectList(_context.Organizations, "ID", "ID", invoice.SupplierOrganizationID);
            return View(invoice);
        }

        // GET: OrderProcess/Invoices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices
                .Include(i => i.Order)
                .Include(i => i.SupplierOrganization)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: OrderProcess/Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceExists(Guid id)
        {
            return _context.Invoices.Any(e => e.ID == id);
        }
    }
}
