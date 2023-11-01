using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMontecastelo.Models;

namespace WebMontecastelo.Controllers
{
    public class ProfesoresController : Controller
    {
        private readonly MontecasteloContext _context;

        public ProfesoresController(MontecasteloContext context)
        {
            _context = context;
        }

        // GET: Profesores
        public async Task<IActionResult> Lista()
        {
              return _context.Profesores != null ? 
                          View(await _context.Profesores.ToListAsync()) :
                          Problem("Entity set 'MontecasteloContext.Profesores'  is null.");
        }

        // GET: Profesores/Detalles/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null || _context.Profesores == null)
            {
                return NotFound();
            }

            var profesores = await _context.Profesores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesores == null)
            {
                return NotFound();
            }

            return View(profesores);
        }
        private bool ProfesoresExists(int id)
        {
          return (_context.Profesores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
