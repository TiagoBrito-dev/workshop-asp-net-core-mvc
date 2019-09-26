using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Salles web MVC app from C# course";
            ViewData["Criador"] = "Tiago Brito";
            ViewData["Contact"] = "(11) 95132-8118";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Social Midia";
            ViewData["Instagram"] = "https://www.instagram.com/tiago_brievan/?hl=pt-br";
            ViewData["Facebook"] = "https://www.facebook.com/tiago.brito.94801";

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
