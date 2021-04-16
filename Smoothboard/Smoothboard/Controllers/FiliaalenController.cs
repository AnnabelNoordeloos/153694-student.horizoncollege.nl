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
    public class FiliaalenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FiliaalenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Filiaalen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Filiaalen.ToListAsync());
        }

        // GET: Filiaalen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filiaal = await _context.Filiaalen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filiaal == null)
            {
                return NotFound();
            }

            return View(filiaal);
        }

        // GET: Filiaalen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Filiaalen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Adres,Woonplaats")] Filiaal filiaal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filiaal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filiaal);
        }

        // GET: Filiaalen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filiaal = await _context.Filiaalen.FindAsync(id);
            if (filiaal == null)
            {
                return NotFound();
            }
            return View(filiaal);
        }

        // POST: Filiaalen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Adres,Woonplaats")] Filiaal filiaal)
        {
            if (id != filiaal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filiaal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FiliaalExists(filiaal.Id))
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
            return View(filiaal);
        }

        // GET: Filiaalen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filiaal = await _context.Filiaalen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filiaal == null)
            {
                return NotFound();
            }

            return View(filiaal);
        }

        // POST: Filiaalen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filiaal = await _context.Filiaalen.FindAsync(id);
            _context.Filiaalen.Remove(filiaal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FiliaalExists(int id)
        {
            return _context.Filiaalen.Any(e => e.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> AddSurfboard(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            //Controleer dat het Filiaal bestaat
            var filiaal = await _context.Filiaalen
                .FirstOrDefaultAsync(m => m.Id == id);
            if(filiaal == null)
            {
                return NotFound();
            }

            //Maak een SelectList voor de dropdown van de View
            ViewData["SurfboardId"] = new SelectList(_context.Surfboards, "Id", "Naam");

            //Maak een nieuw Voorraad object en vul het FiliaalId in
            //Geef dit object mee aan de View
            var voorraad = new Voorraad { FiliaalId = filiaal.Id };

            return View(voorraad);
        }

        [HttpPost]

        public async Task<IActionResult> AddSurfboard(int id, Voorraad voorraad)
        {
            //Controleer of het meegegeven Filiaal bestaat
            if(id != voorraad.FiliaalId)
            {
                return NotFound();
            }

            //Controleer of er al een regel bestaat voor deze voorraad,
            //zo nee, maak een nieuwe voorraad
            //zo ja, pas het aantal van de bestaande voorraad aan
            var bestaandeVoorraad = await _context.Voorraaden.FindAsync(voorraad.SurfboardId, voorraad.FiliaalId);
            if(bestaandeVoorraad == null)
            {
                _context.Add(voorraad);
            }
            else
            {
                bestaandeVoorraad.Aantal += voorraad.Aantal;
                _context.Update(bestaandeVoorraad);
            }

            //Bewaar de aanpassingen en keer terug naar de Details scherm
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = voorraad.FiliaalId });
        }

    }
}
