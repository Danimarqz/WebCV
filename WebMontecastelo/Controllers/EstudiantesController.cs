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
    public class EstudiantesController : Controller
    {
        private readonly MontecasteloContext _context;

        public EstudiantesController(MontecasteloContext context)
        {
            _context = context;
        }

        // GET: Estudiantes
        public async Task<IActionResult> Lista()
        {
              return _context.Estudiantes != null ? 
                          View(await _context.Estudiantes.ToListAsync()) :
                          Problem("Entity set 'MontecasteloContext.Estudiantes'  is null.");
        }

        // GET: Estudiantes/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null || _context.Estudiantes == null)
            {
                return NotFound();
            }

            var estudiantes = await _context.Estudiantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudiantes == null)
            {
                return NotFound();
            }

            return View(estudiantes);
        }
        private bool EstudiantesExists(int id)
        {
          return (_context.Estudiantes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
