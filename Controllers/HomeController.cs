using Microsoft.AspNetCore.Mvc;
using PartProject_2.Models;
using System.Diagnostics;

namespace PartProject_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
