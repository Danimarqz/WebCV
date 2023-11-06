using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMontecastelo.Data;

namespace WebMontecastelo.Controllers
{
    public class AsignaturasController : Controller
    {
        private readonly MontecasteloContext _context;

        public AsignaturasController(MontecasteloContext context)
        {
            _context = context;
        }

        // GET: Asignaturas
        public async Task<IActionResult> Lista()
        {
              return _context.Asignaturas != null ? 
                          View(await _context.Asignaturas.ToListAsync()) :
                          Problem("Entity set 'MontecasteloContext.Asignaturas'  is null.");
        }

        // GET: Asignaturas/Detalles/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null || _context.Asignaturas == null)
            {
                return NotFound();
            }

            var asignaturas = await _context.Asignaturas
                .FirstOrDefaultAsync(m => m.id == id);
            if (asignaturas == null)
            {
                return NotFound();
            }

            return View(asignaturas);
        }
        private bool AsignaturasExists(int id)
        {
          return (_context.Asignaturas?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
