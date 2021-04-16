using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smoothboard.Data;
using Smoothboard.Models;

namespace Smoothboard.Controllers
{
    public class VoorraadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoorraadController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Voorraad
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Voorraaden.Include(v => v.Filiaal).Include(v => v.Surfboard);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Voorraad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voorraad = await _context.Voorraaden
                .Include(v => v.Filiaal)
                .Include(v => v.Surfboard)
                .FirstOrDefaultAsync(m => m.SurfboardId == id);
            if (voorraad == null)
            {
                return NotFound();
            }

            return View(voorraad);
        }

        // GET: Voorraad/Create
        public IActionResult Create()
        {
            ViewData["FiliaalId"] = new SelectList(_context.Filiaalen, "Id", "Aantal");
            ViewData["SurfboardId"] = new SelectList(_context.Surfboards, "Id", "Aantal");
            return View();
        }

        // POST: Voorraad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurfboardId,FiliaalId,Aantal")] Voorraad voorraad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voorraad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FiliaalId"] = new SelectList(_context.Filiaalen, "Id", "id", voorraad.FiliaalId);
            ViewData["SurfboardId"] = new SelectList(_context.Surfboards, "Id", "Aantal", voorraad.SurfboardId);
            return View(voorraad);
        }

        // GET: Voorraad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voorraad = await _context.Voorraaden.FindAsync(id);
            if (voorraad == null)
            {
                return NotFound();
            }
            ViewData["FiliaalId"] = new SelectList(_context.Filiaalen, "Id", "Aantal", voorraad.FiliaalId);
            ViewData["SurfboardId"] = new SelectList(_context.Surfboards, "Id", "Id", voorraad.SurfboardId);
            return View(voorraad);
        }

        // POST: Voorraad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurfboardId,FiliaalId,Aantal")] Voorraad voorraad)
        {
            if (id != voorraad.SurfboardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voorraad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoorraadExists(voorraad.SurfboardId))
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
            ViewData["FiliaalId"] = new SelectList(_context.Filiaalen, "Id", "Id", voorraad.FiliaalId);
            ViewData["SurfboardId"] = new SelectList(_context.Surfboards, "Id", "Id", voorraad.SurfboardId);
            return View(voorraad);
        }

        // GET: Voorraad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voorraad = await _context.Voorraaden
                .Include(v => v.Filiaal)
                .Include(v => v.Surfboard)
                .FirstOrDefaultAsync(m => m.SurfboardId == id);
            if (voorraad == null)
            {
                return NotFound();
            }

            return View(voorraad);
        }

        // POST: Voorraad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voorraad = await _context.Voorraaden.FindAsync(id);
            _context.Voorraaden.Remove(voorraad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoorraadExists(int id)
        {
            return _context.Voorraaden.Any(e => e.SurfboardId == id);
        }
    }
}
