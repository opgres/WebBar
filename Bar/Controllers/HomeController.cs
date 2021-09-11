using Bar.Models.E;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext db;
        public HomeController(AppDbContext context)
        {
            db = context;
        }
        
        [HttpGet]
        public ViewResult Index()
        { 
            return View("Index",db.Cocktails);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
