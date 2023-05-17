using Microsoft.AspNetCore.Mvc;

namespace WebApplicationResume.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
