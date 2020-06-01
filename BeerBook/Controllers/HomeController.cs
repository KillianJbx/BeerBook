using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeerBook.Models;
using BeerBook.BDD;

namespace BeerBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
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
        public IActionResult AddBeer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBeer(BeerFormViewModel addedBeer)
        {
            IActionResult retour;

            if (ModelState.IsValid)
            {
                BeerBDD beerBDD = new BeerBDD();
                Beer beer = addedBeer.ToBeer();
                beerBDD.Insert(beer);
                retour = RedirectToAction("Index");
            }
            else
            {
                retour = View(addedBeer);
            }
            return retour;
        }

        public IActionResult Index()
        {
            BeerBDD beerBDD = new BeerBDD();

            List<Beer> beers = beerBDD.GetAll();

            BeersViewModel model = new BeersViewModel();
            model.Beers = beers;
            return View(model);
        }

        
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
