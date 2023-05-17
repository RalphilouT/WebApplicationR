using Microsoft.AspNetCore.Mvc;
using WebApplicationResume.Data;
using WebApplicationResume.Models;

namespace WebApplicationResume.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProjectController(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public IActionResult Index()
        {
            IEnumerable<Project> objProjectList = _db.Project;
            return View(objProjectList);
        }
    }
}
