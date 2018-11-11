using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp.netPractice1.Models;

namespace asp.netPractice1.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

/* NOTES: 
 * IActionResult is a 'view'.  The individual methods will return an IActionResult 'view'.  But right now in the beginning, it doesnt say which view to return. 
 * the 'HomeController' will go into the 'Home' folder. AND the method name Index() or About() or Contact() will be the file it returns from.
 * the process of doing this is called an Action. The result of the ActionResult is to display the View. In this case ust display the index.cshtml page. 
 */