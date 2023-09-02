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
    public class StockTypesController : Controller
    {
        private readonly AppDbContext _context;

        public StockTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StockTypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.StockType.ToListAsync());
        }

        // GET: StockTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockType == null)
            {
                return NotFound();
            }

            var stockType = await _context.StockType
                .FirstOrDefaultAsync(m => m.StockTypeID == id);
            if (stockType == null)
            {
                return NotFound();
            }

            return View(stockType);
        }

        // GET: StockTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockTypeID,StockTypeName")] StockType stockType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockType);
        }

        // GET: StockTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockType == null)
            {
                return NotFound();
            }

            var stockType = await _context.StockType.FindAsync(id);
            if (stockType == null)
            {
                return NotFound();
            }
            return View(stockType);
        }

        // POST: StockTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StockTypeID,StockTypeName")] StockType stockType)
        {
            if (id != stockType.StockTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockTypeExists(stockType.StockTypeID))
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
            return View(stockType);
        }

        // GET: StockTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockType == null)
            {
                return NotFound();
            }

            var stockType = await _context.StockType
                .FirstOrDefaultAsync(m => m.StockTypeID == id);
            if (stockType == null)
            {
                return NotFound();
            }

            return View(stockType);
        }

        // POST: StockTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockType == null)
            {
                return Problem("Entity set 'AppDbContext.StockType'  is null.");
            }
            var stockType = await _context.StockType.FindAsync(id);
            if (stockType != null)
            {
                _context.StockType.Remove(stockType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockTypeExists(int id)
        {
          return _context.StockType.Any(e => e.StockTypeID == id);
        }
    }
}
