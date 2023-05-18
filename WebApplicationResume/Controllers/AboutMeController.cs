﻿using Microsoft.AspNetCore.Mvc;
using WebApplicationResume.Data;

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
            //IEnumerable<Project> objProjectList = _db.Project;
            return View();
            //return View(objProjectList);
        }
    }
}
