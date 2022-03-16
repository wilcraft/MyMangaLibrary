using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMangaLibrary.Data;
using MyMangaLibrary.Models;

namespace MyMangaLibrary.Controllers
{
    public class MangakasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MangakasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Mangakas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mangaka.ToListAsync());
        }
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }
        public async Task<IActionResult> ShowSearchResults(string SearchPhrase)
        {
            return View("Index", await _context.Mangaka.Where(m => m.Name.Contains(SearchPhrase)).ToListAsync());
        }
        // GET: Mangakas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mangaka = await _context.Mangaka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mangaka == null)
            {
                return NotFound();
            }

            return View(mangaka);
        }

        // GET: Mangakas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mangakas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Age,Description")] Mangaka mangaka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mangaka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mangaka);
        }

        // GET: Mangakas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mangaka = await _context.Mangaka.FindAsync(id);
            if (mangaka == null)
            {
                return NotFound();
            }
            return View(mangaka);
        }

        // POST: Mangakas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Age,Description")] Mangaka mangaka)
        {
            if (id != mangaka.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mangaka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MangakaExists(mangaka.ID))
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
            return View(mangaka);
        }

        // GET: Mangakas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mangaka = await _context.Mangaka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mangaka == null)
            {
                return NotFound();
            }

            return View(mangaka);
        }

        // POST: Mangakas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mangaka = await _context.Mangaka.FindAsync(id);
            _context.Mangaka.Remove(mangaka);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MangakaExists(int id)
        {
            return _context.Mangaka.Any(e => e.ID == id);
        }
    }
}
