using Microsoft.AspNetCore.Mvc;

namespace WebMontecastelo.Controllers
{
    public class CurriculumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
