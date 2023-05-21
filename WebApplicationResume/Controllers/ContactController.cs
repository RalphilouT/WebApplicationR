using Microsoft.AspNetCore.Mvc;
using WebApplicationResume.Data;
using WebApplicationResume.Models;

namespace WebApplicationResume.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> objCategoryList = _db.Contact;
            return View(objCategoryList);
        }
        public IActionResult Submit()
        {
            return View();
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Contact obj)
        {
            if (obj.name == obj.email.ToString())
            {
                ModelState.AddModelError("name", "The email cannot exactly match the name"); //Custom validation
            }
            if (ModelState.IsValid)
            {
                _db.Contact.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Contact created successfully";
                return RedirectToAction("Submit");
            }
            return View(obj);
        }


    }
}


