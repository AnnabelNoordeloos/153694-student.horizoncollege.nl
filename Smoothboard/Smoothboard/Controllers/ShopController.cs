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
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Shop
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Surfboards.Include(s => s.Materiaal);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Shop/Details/5
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
    }
        
}
