using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcBook.Models;

namespace MvcBook.Controllers
{
    public class CategoryTypeController : Controller
    {
        private readonly MvcBookContext _context;

        public CategoryTypeController(MvcBookContext context)
        {
            _context = context;
        }

        // GET: CategoryType
        public async Task<IActionResult> Index()
        {
              return View(await _context.CategoryType.ToListAsync());
        }

        // GET: CategoryType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CategoryType == null)
            {
                return NotFound();
            }

            var categoryType = await _context.CategoryType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoryType == null)
            {
                return NotFound();
            }

            return View(categoryType);
        }

        // GET: CategoryType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoryType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description")] CategoryType categoryType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryType);
        }

        // GET: CategoryType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CategoryType == null)
            {
                return NotFound();
            }

            var categoryType = await _context.CategoryType.FindAsync(id);
            if (categoryType == null)
            {
                return NotFound();
            }
            return View(categoryType);
        }

        // POST: CategoryType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Description")] CategoryType categoryType)
        {
            if (id != categoryType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryTypeExists(categoryType.Id))
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
            return View(categoryType);
        }

        // GET: CategoryType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CategoryType == null)
            {
                return NotFound();
            }

            var categoryType = await _context.CategoryType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoryType == null)
            {
                return NotFound();
            }

            return View(categoryType);
        }

        // POST: CategoryType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CategoryType == null)
            {
                return Problem("Entity set 'MvcBookContext.CategoryType'  is null.");
            }
            var categoryType = await _context.CategoryType.FindAsync(id);
            if (categoryType != null)
            {
                _context.CategoryType.Remove(categoryType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryTypeExists(int id)
        {
          return _context.CategoryType.Any(e => e.Id == id);
        }
    }
}
