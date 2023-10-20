using Microsoft.AspNetCore.Mvc;

namespace WebMontecastelo.Controllers
{
    public class CurriculumController : Controller
    {

        [HttpGet]
        public ActionResult MiCurriculum()
        {
            return View();
        }
    }
}
