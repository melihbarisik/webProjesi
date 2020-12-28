using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webProjeCalismasi.Models;

namespace webProjeCalismasi.Controllers
{
    public class KitaplarController : Controller
    {
        private readonly MyContext _context;

        public KitaplarController(MyContext context)
        {
            _context = context;
        }

        // GET: Kitaplar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kitaplar.ToListAsync());
        }

        // GET: Kitaplar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitaplar = await _context.Kitaplar
                .FirstOrDefaultAsync(m => m.KitaplarId == id);
            if (kitaplar == null)
            {
                return NotFound();
            }

            return View(kitaplar);
        }

        // GET: Kitaplar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kitaplar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KitaplarId,kitapIsmi,kitapFiyat,kitapResimUrl,kitapSayfaSayisi")] Kitaplar kitaplar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kitaplar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kitaplar);
        }

        // GET: Kitaplar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitaplar = await _context.Kitaplar.FindAsync(id);
            if (kitaplar == null)
            {
                return NotFound();
            }
            return View(kitaplar);
        }

        // POST: Kitaplar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KitaplarId,kitapIsmi,kitapFiyat,kitapResimUrl,kitapSayfaSayisi")] Kitaplar kitaplar)
        {
            if (id != kitaplar.KitaplarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitaplar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KitaplarExists(kitaplar.KitaplarId))
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
            return View(kitaplar);
        }

        // GET: Kitaplar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitaplar = await _context.Kitaplar
                .FirstOrDefaultAsync(m => m.KitaplarId == id);
            if (kitaplar == null)
            {
                return NotFound();
            }

            return View(kitaplar);
        }

        // POST: Kitaplar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kitaplar = await _context.Kitaplar.FindAsync(id);
            _context.Kitaplar.Remove(kitaplar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KitaplarExists(int id)
        {
            return _context.Kitaplar.Any(e => e.KitaplarId == id);
        }
    }
}
