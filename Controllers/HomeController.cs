using BackEnd.Context;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeDBContext _employeeDBContext;

        public HomeController(ILogger<HomeController> logger,EmployeeDBContext employeeDBContext)
        {
            _logger = logger;
            _employeeDBContext = employeeDBContext;
        }

        public IActionResult Index()
        {
            var data = _employeeDBContext.User.ToList();
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