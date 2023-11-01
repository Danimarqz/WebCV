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
    public class LoginController : Controller
    {
        private readonly MontecasteloContext _context;

        public LoginController(MontecasteloContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Logueate()
        {
              return _context.Logins != null ? 
                          View(await _context.Logins.ToListAsync()) :
                          Problem("Entity set 'MontecasteloContext.Logins'  is null.");
        }

        // GET: Login/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null || _context.Logins == null)
            {
                return NotFound();
            }

            var logins = await _context.Logins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logins == null)
            {
                return NotFound();
            }

            return View(logins);
        }

        public ActionResult MiCurriculum()
        {
            return View();
        }

        private bool LoginsExists(int id)
        {
          return (_context.Logins?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
