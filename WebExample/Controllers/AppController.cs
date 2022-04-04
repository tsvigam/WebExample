using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebExample.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            //SortedSet<string> strins = new SortedSet<string>();
            //strins.Add("abc");
            return View();
        }
        public IActionResult Details(int id)
        {
            return Ok("You have entered id = {id} " + id);
        }
    }
}
