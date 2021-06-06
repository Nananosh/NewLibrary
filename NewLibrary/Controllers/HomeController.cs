using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NewLibrary.DataBaseConnection;
using NewLibrary.DataBaseConnection.Factory;

namespace NewLibrary.Controllers
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
            var alltovars = Factory.GetAllAuthor(DatabaseConnection.GetAllAuthor());
            List<PublicationInformation> alltov = Factory.GetAllPublication2(DatabaseConnection.GetAllPublication2());
            alltov.Reverse();
            ViewBag.AllTovars = alltov;
            ViewBag.AllAuthor = alltovars;
            ViewBag.It = 0;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
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
