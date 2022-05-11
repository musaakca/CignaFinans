using CignaFinans.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CignaFinans.Web.Controllers
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
            TempData["name"] = "asp.net core";

            var products = new List<Product>()
            {

                new (){ Id=1, Name="kalem 1", Price=100},
                 new (){ Id=2, Name="kalem 2", Price=200},
                  new (){ Id=3, Name="kalem 3", Price=300}


            };

            var products2 = new List<Product>()
            {

                new (){ Id=1, Name="kalem 1", Price=100},
                 new (){ Id=2, Name="kalem 2", Price=200},
                  new (){ Id=3, Name="kalem 3", Price=300}


            };
            ViewBag.product2 = products2;
            //var product = new Product();
            //product.Price = 100;
            //product.Name = "kalem 1";
            //product.Id = 1;


            //ViewData["product"] = product;

            //ViewData["name"] = "asp.net core";

            //ViewData["version"] = "6.0";

            //ViewBag.product2 = product;

            //

            // return View((products, products2));
            //  return View(new ProductWrapper() { ProductList1 = products, ProductList2 = products2 });
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Content()
        {

            return Content("bu bir asp.net core mvc uygulamasıdır.");
        }





        public IActionResult Json()
        {
            return Json(new { Name = "Asp.net Core", Version = "6.0" });
        }

        public IActionResult Empty()
        {

            return Empty();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });




        }


        public Tuple<int, string> Get()
        {


            return Tuple.Create(0, "ahmet");
        }

        public (int, string) Get2()
        {

            return (10, "ahmet");
        }





    }
}