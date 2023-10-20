using Microsoft.AspNetCore.Mvc;

namespace WebMontecastelo.Controllers
{
    public class MiCurriculumController : Controller
    {

        [HttpGet]
        public ActionResult MiCurriculum()
        {
            return View();
        }
    }
}
