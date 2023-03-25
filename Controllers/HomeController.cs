using AjaxBasedDataRetrieval.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxBasedDataRetrieval.Controllers
{
    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }

    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult GetProducts()
        {
            return View();
        }

        public IActionResult CreateProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VeriAl(AjaxData ajaxData)
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