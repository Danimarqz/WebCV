using Microsoft.AspNetCore.Mvc;

namespace WebMontecastelo.Controllers
{
    public class CurriculumController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index()
=======
        [HttpGet]
        public ActionResult MiCurriculum()
>>>>>>> f67c0bd (Agregar archivos de proyecto.)
        {
            return View();
        }
    }
}
