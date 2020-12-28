using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webProjeCalismasi.Models;

namespace webProjeCalismasi.Controllers
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
        public IActionResult Index(String bos)
        { 
            // if veri tabanı 
            return RedirectToAction("Anasayfa");
        }

     
        public IActionResult Anasayfa()
        {
            var kitaplar = new List<Kitaplar>()
            {
                 new Kitaplar{kitapIsmi="Alper'in Maceraları"},
                 new Kitaplar{kitapIsmi="Küçük Ömer Elazığ Dağlarında"}
            };


            return View(kitaplar);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
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
