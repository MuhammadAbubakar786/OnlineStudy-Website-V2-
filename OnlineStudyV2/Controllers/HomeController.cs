using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStudyV2.Models;

namespace OnlineStudyV2.Controllers
{
    public class HomeController : Controller
    {
        private OnlineStudyWebsiteContext orm;
            public HomeController(OnlineStudyWebsiteContext orm2)
        {
            orm = orm2;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ConatctUs conatctUs)
        {
            orm.ConatctUs.Add(conatctUs);
            orm.SaveChanges();
            return View();
        }
        public IActionResult Viewdata()
        {
            orm.ConatctUs.ToList();
            orm.SaveChanges();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
