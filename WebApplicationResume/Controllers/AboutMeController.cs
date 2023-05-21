using Microsoft.AspNetCore.Mvc;
using WebApplicationResume.Data;
using WebApplicationResume.Models;

namespace WebApplicationResume.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AboutMeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Education> objEducationList = _db.Education;
            return View(objEducationList);
        }
    }
}
