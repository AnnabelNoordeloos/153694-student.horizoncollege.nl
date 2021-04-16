using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smoothboard.Data;
using Smoothboard.Models;
using Microsoft.AspNetCore.Authorization;

namespace Smoothboard.Controllers
{
    [Authorize]
    public class InteressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InteressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Interesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Interesses.ToListAsync());
        }

        // GET: Interesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesse = await _context.Interesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interesse == null)
            {
                return NotFound();
            }

            return View(interesse);
        }

        // GET: Interesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Interesses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SurfboardId,ContactId")] Interesse interesse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interesse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interesse);
        }

        // GET: Interesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesse = await _context.Interesses.FindAsync(id);
            if (interesse == null)
            {
                return NotFound();
            }
            return View(interesse);
        }

        // POST: Interesses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SurfboardId,ContactId")] Interesse interesse)
        {
            if (id != interesse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interesse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InteresseExists(interesse.Id))
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
            return View(interesse);
        }

        // GET: Interesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesse = await _context.Interesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interesse == null)
            {
                return NotFound();
            }

            return View(interesse);
        }

        // POST: Interesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interesse = await _context.Interesses.FindAsync(id);
            _context.Interesses.Remove(interesse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InteresseExists(int id)
        {
            return _context.Interesses.Any(e => e.Id == id);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateFromDetails(int SurfboardId, string Email)
        {
            var surfboard = _context.Surfboards.Find(SurfboardId);

            if (surfboard != null)
            {
                // Zoek het contact en als het nog niet bestaat dan toevoegen 
                var contact = _context.Contacten.Where(contact => contact.Email == Email).FirstOrDefault();
                if (contact == null)
                {
                    contact = new Contact
                    {
                        Email = Email
                    };
                    _context.Contacten.Add(contact);
                    await _context.SaveChangesAsync();
                }

                // Check of er al een interesse record bestaat 
                // met dezelfde ContactId en SurfboardId 
                var interesse = _context.Interesses
                    .Where(interesse =>
                        interesse.ContactId == contact.Id
                        && interesse.SurfboardId == surfboard.Id)
                    .FirstOrDefault();

                // Maak een nieuwe Interesse aan 
                if (interesse == null)
                {
                    interesse = new Interesse
                    {
                        ContactId = contact.Id,
                        SurfboardId = surfboard.Id
                    };
                    _context.Interesses.Add(interesse);
                    await _context.SaveChangesAsync();
                }

                // Vul TempData["InteresseCreated"] om aan te geven dat het gelukt is 
                TempData["InteresseCreated"] = true;


                // Keer terug naar het Details scherm van het Surfboard 
                return RedirectToAction("Details", "Surfboards", new { Id = SurfboardId });
            }
            // Surfboard bestaat niet, return NotFound() 
            return NotFound();

        }
    }
}
