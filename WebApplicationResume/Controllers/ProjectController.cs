using Microsoft.AspNetCore.Mvc;

namespace WebApplicationResume.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
