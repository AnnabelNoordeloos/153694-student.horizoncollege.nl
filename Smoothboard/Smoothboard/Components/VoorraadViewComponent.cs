using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smoothboard.Data;
using Smoothboard.Models;

namespace Smoothboard.Components
{
    public class VoorraadViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public VoorraadViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {
            var voorraad = await _context.Voorraaden
              .Include(v => v.Surfboard)
              .Include(v => v.Filiaal)
              .Where(v => v.FiliaalId == id)
              .ToListAsync();

            return View(voorraad);

        }
    }
}
