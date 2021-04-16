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
using System.IO;
using System.Drawing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace Smoothboard.Controllers
{
    [Authorize]
    public class SurfboardsController : Controller
    {
        private const string _surfBoardIcon = "surfboard-icon.png";

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public SurfboardsController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Surfboards
        [AllowAnonymous]
        public async Task<IActionResult> Overzicht()
        {
            var applicationDbContext = _context.Surfboards.Include(s => s.Materiaal);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Surfboards.Include(s => s.Materiaal);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Surfboards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfboards = await _context.Surfboards
                .Include(s => s.Materiaal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfboards == null)
            {
                return NotFound();
            }

            return View(surfboards);
        }

        // GET: Surfboards/Create
        public IActionResult Create()
        {
            ViewData["MateriaalId"] = new SelectList(_context.Materialen, "Id", "Name");
            return View();
        }

        // POST: Surfboards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Beschrijving,Prijs,FotoUrl,MateriaalId")] Surfboards surfboards, IFormFile fotoFile)
        {
            if (ModelState.IsValid)
            {
                if (fotoFile != null && fotoFile.Length >0)
                {
                    surfboards.FotoUrl = await SaveImage(fotoFile);
                }
                if (string.IsNullOrEmpty(surfboards.FotoUrl))
                {
                    surfboards.FotoUrl = _surfBoardIcon;
                }
                _context.Add(surfboards);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MateriaalList"] = new SelectList(_context.Materialen, "Id", "Name", surfboards.MateriaalId);
            return View(surfboards);
        }

        // GET: Surfboards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfboards = await _context.Surfboards.FindAsync(id);
            if (surfboards == null)
            {
                return NotFound();
            }
            ViewData["MateriaalId"] = new SelectList(_context.Materialen, "Id", "Id", surfboards.MateriaalId);
            return View(surfboards);
        }

        // POST: Surfboards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Beschrijving,Prijs,FotoUrl,MateriaalId")] Surfboards surfboards)
        {
            if (id != surfboards.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surfboards);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurfboardsExists(surfboards.Id))
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
            ViewData["MateriaalId"] = new SelectList(_context.Materialen, "Id", "Id", surfboards.MateriaalId);
            return View(surfboards);
        }

        // GET: Surfboards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfboards = await _context.Surfboards
                .Include(s => s.Materiaal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfboards == null)
            {
                return NotFound();
            }

            return View(surfboards);
        }

        // POST: Surfboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surfboards = await _context.Surfboards.FindAsync(id);
            _context.Surfboards.Remove(surfboards);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurfboardsExists(int id)
        {
            return _context.Surfboards.Any(e => e.Id == id);
        }

        public bool ThumbnialCallBack()
        {
            return false;
        }

        private bool Thumbnail(string savedName)
        {
            int thumbnailWidth = 160;
            var imagePath = ImagePath(savedName);

            try
            {
                var original = new Bitmap(imagePath);
                var myCallBack = new Image.GetThumbnailImageAbort(ThumbnialCallBack);
                float resizeFactors = (float)thumbnailWidth / (float)original.Width;
                int thumbnailHeight = (int)(resizeFactors * original.Height);

                var thumbnail = original.GetThumbnailImage(thumbnailWidth, thumbnailHeight, myCallBack, IntPtr.Zero);

                var thumbnialName = $"thumbnail.{savedName}";
                var thumbnailPath = ImagePath(thumbnialName);

                thumbnail.Save(thumbnailPath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<String> SaveImage(IFormFile fotoFile)
        {
            var fileName = Path.GetFileName(fotoFile.FileName).Replace(' ', '-');

            int number = 0;

            var nameWithoutExtention = Path.GetFileNameWithoutExtension(fileName);
            var extention = Path.GetExtension(fileName);

            var savedName = fileName;
            string fotoPath;

            do
            {
                if (number > 0)
                {
                    savedName = $"{nameWithoutExtention}({number}){extention}";
                }
                fotoPath = ImagePath(savedName);
                number++;
            } while (System.IO.File.Exists(fotoPath));

            try
            {
                using var stream = new FileStream(fotoPath, FileMode.Create);
                await fotoFile.CopyToAsync(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }

            if (!Thumbnail(savedName))
            {
                DeleteImage(savedName);
                return string.Empty;
            }
            return savedName;
        }

        public string ImagePath(string imageFileName)
        {
            string imgPad = $"{_environment.WebRootPath}/img";
            string imagePath = Path.Combine(imgPad, imageFileName);
            return imagePath;
        }

        private bool DeleteImage(string savedName)
        {
            try
            {
                string imagePath = ImagePath(savedName);
                System.IO.File.Delete(imagePath);

                string thumbnailPath = ImagePath($"thumb.{savedName}");
                System.IO.File.Delete(thumbnailPath);

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
