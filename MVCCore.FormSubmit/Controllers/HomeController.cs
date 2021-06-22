using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCore.FormSubmit.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.FormSubmit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string firstName, string lastName, string Address)
        {
            ViewBag.Formvalue = string.Format("Form Field Value is : {0} {1} {2}", firstName, lastName, Address);
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
