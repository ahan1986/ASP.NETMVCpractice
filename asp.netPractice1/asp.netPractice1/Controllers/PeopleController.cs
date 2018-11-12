using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.netPractice1.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListPeople() {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { FirstName = "Andrew", LastName = "Han", Age = 31 });
            people.Add(new Models.PersonModel { FirstName = "bob", LastName = "Dole", Age = 54 });
            people.Add(new Models.PersonModel { FirstName = "Jack", LastName = "Johnson", Age = 68 });

            return View();
        }
    }
}
