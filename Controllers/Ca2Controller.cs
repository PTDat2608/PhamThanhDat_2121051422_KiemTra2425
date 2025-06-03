using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTD_KTRA.Data;
using PTD_KTRA.Models;

namespace PTD_Ktra.Controllers
{
    public class Ca2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Ca2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ca2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ca2.ToListAsync());
        }

        // GET: Ca2/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ca2 = await _context.Ca2
                .FirstOrDefaultAsync(m => m.MyProperty == id);
            if (ca2 == null)
            {
                return NotFound();
            }

            return View(ca2);
        }

        // GET: Ca2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ca2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MyProperty,Age,Address")] Ca2 ca2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ca2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ca2);
        }

        // GET: Ca2/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ca2 = await _context.Ca2.FindAsync(id);
            if (ca2 == null)
            {
                return NotFound();
            }
            return View(ca2);
        }

        // POST: Ca2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MyProperty,Age,Address")] Ca2 ca2)
        {
            if (id != ca2.MyProperty)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ca2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Ca2Exists(ca2.MyProperty))
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
            return View(ca2);
        }

        // GET: Ca2/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ca2 = await _context.Ca2
                .FirstOrDefaultAsync(m => m.MyProperty == id);
            if (ca2 == null)
            {
                return NotFound();
            }

            return View(ca2);
        }

        // POST: Ca2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ca2 = await _context.Ca2.FindAsync(id);
            if (ca2 != null)
            {
                _context.Ca2.Remove(ca2);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Ca2Exists(string id)
        {
            return _context.Ca2.Any(e => e.MyProperty == id);
        }
    }
}
