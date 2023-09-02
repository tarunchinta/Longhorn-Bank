using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using Microsoft.AspNetCore.Authorization;

namespace fa22_finalproject_32.Controllers
{
    [Authorize]
    public class StockTransactionsController : Controller
    {
        private readonly AppDbContext _context;

        public StockTransactionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StockTransactions
        public async Task<IActionResult> Index()
        {
              return View(await _context.StockTransaction.ToListAsync());
        }

        // GET: StockTransactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockTransaction == null)
            {
                return NotFound();
            }

            var stockTransaction = await _context.StockTransaction
                .FirstOrDefaultAsync(m => m.StockTransactionID == id);
            if (stockTransaction == null)
            {
                return NotFound();
            }

            return View(stockTransaction);
        }

        // GET: StockTransactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockTransactionID,NumofShares,Pricepershare,StockTransactionDate")] StockTransaction stockTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockTransaction);
        }

        // GET: StockTransactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockTransaction == null)
            {
                return NotFound();
            }

            var stockTransaction = await _context.StockTransaction.FindAsync(id);
            if (stockTransaction == null)
            {
                return NotFound();
            }
            return View(stockTransaction);
        }

        // POST: StockTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StockTransactionID,NumofShares,Pricepershare,StockTransactionDate")] StockTransaction stockTransaction)
        {
            if (id != stockTransaction.StockTransactionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockTransactionExists(stockTransaction.StockTransactionID))
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
            return View(stockTransaction);
        }

        // GET: StockTransactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockTransaction == null)
            {
                return NotFound();
            }

            var stockTransaction = await _context.StockTransaction
                .FirstOrDefaultAsync(m => m.StockTransactionID == id);
            if (stockTransaction == null)
            {
                return NotFound();
            }

            return View(stockTransaction);
        }

        // POST: StockTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockTransaction == null)
            {
                return Problem("Entity set 'AppDbContext.StockTransaction'  is null.");
            }
            var stockTransaction = await _context.StockTransaction.FindAsync(id);
            if (stockTransaction != null)
            {
                _context.StockTransaction.Remove(stockTransaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockTransactionExists(int id)
        {
          return _context.StockTransaction.Any(e => e.StockTransactionID == id);
        }
    }
}
