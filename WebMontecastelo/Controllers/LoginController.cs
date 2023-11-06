using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using WebMontecastelo.Data;
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


        public ActionResult Logueate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Logins model)
        {
            if (ModelState.IsValid)
            {
                var User = from m in _context.Logins select m;
                User = User.Where(s => s.Username.Contains(model.Username));
                if (User.Count() != 0)
                {
                    if (User.First().Password == model.Password)
                    {
                        return RedirectToAction("UsuarioCorrecto");
                    }
                }
            }
            return RedirectToAction("UsuarioIncorrecto");
        }
        public ActionResult UsuarioCorrecto()
        {
            return View("./Views/Home/Index.cshtml");
        }
        public ActionResult UsuarioIncorrecto() {
            return View("Logueate");
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
