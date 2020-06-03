using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeerBook.Models;
using BeerBook.BDD;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        private List<SelectListItem> populateCategorie()
        {
            CategorieBDD categorieBDD = new CategorieBDD();

            List<Categorie> categories = categorieBDD.GetAll();
            List<SelectListItem> selectListItem = new List<SelectListItem>();
            foreach (Categorie categorie in categories)
            {
                selectListItem.Add(new SelectListItem(categorie.Libelle, categorie.Identifiant.ToString()));
            }

            return selectListItem;
        }

        private List<SelectListItem> populateGamme()
        {
            GammeBDD gammeBDD = new GammeBDD();

            List<Gamme> gammes = gammeBDD.GetAll();
            List<SelectListItem> selectListItem = new List<SelectListItem>();
            foreach (Gamme gamme in gammes)
            {
                selectListItem.Add(new SelectListItem(gamme.Libelle, gamme.Identifiant.ToString()));
            }

            return selectListItem;
        }

        public IActionResult AddBeer()
        {
            BeerFormViewModel model = new BeerFormViewModel();
            model.Categories = populateCategorie();
            model.Gammes = populateGamme();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddBeer(BeerFormViewModel addedBeer)
        {

            BeerBDD beerBDD = new BeerBDD();
            addedBeer.Categories = populateCategorie();
            addedBeer.Gammes = populateGamme();

            IActionResult retour = null;
            if (ModelState.IsValid)
            {

                Beer beer = new Beer();
                
                    beer.Identifiant = addedBeer.Identifiant;
                    beer.Libelle = addedBeer.Libelle;
                    beer.DateProduction = addedBeer.DateProduction;
                    beer.TauxAlcoolemie = float.Parse(addedBeer.TauxAlcoolemie);
                    beer.IdentifiantCategorie = addedBeer.IdentifiantCategorie;
                    beer.IdentifiantGamme = addedBeer.IdentifiantGamme;
                    beer.Commentaire = addedBeer.Commentaire;


                bool isOK = beerBDD.Insert(beer);
                retour = RedirectToAction("Index");
            }
            else
            {
                retour = View(addedBeer);
            }
            return retour;
        }

        public IActionResult Delete(int id)
        {
            
            BeerBDD beerBDD = new BeerBDD();
            Beer beer = beerBDD.Get(id);
            CategorieBDD categorieBDD = new CategorieBDD();
            Categorie categorie = categorieBDD.Get(beer.IdentifiantCategorie);
            GammeBDD gammeBDD = new GammeBDD();
            Gamme gamme = gammeBDD.Get(beer.IdentifiantGamme);
            BeerDeleteViewModel model = new BeerDeleteViewModel();
            model.Beer = beer;
            model.Categorie = categorie;
            model.Gamme = gamme;
            return View(model);
        }

        [HttpPost("Home/Delete")]
        public IActionResult DeleteConfirmation(int id)
        {
            BeerBDD beerBDD = new BeerBDD();
            beerBDD.Delete(id);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            CategorieBDD categorieBDD = new CategorieBDD();
            List<Categorie> categories = categorieBDD.GetAll();
            GammeBDD gammeBDD = new GammeBDD();
            List<Gamme> gammes = gammeBDD.GetAll();
            BeerBDD beerBDD = new BeerBDD();
            List<Beer> beers = beerBDD.GetAll();

            BeersViewModel model = new BeersViewModel();
            model.Beers = beers;
            model.Categories = categories;
            model.Gammes = gammes;
            return View(model);
        }



        public IActionResult Edit(int id)
        {
            BeerBDD beerBDD = new BeerBDD();
            Beer beer = beerBDD.Get(id);
            BeerFormViewModel beerModel = new BeerFormViewModel();

            beerModel.Identifiant = beer.Identifiant;
            beerModel.Libelle = beer.Libelle;
            beerModel.DateProduction = beer.DateProduction;
            beerModel.TauxAlcoolemie = beer.TauxAlcoolemie.ToString();
            beerModel.IdentifiantCategorie = beer.IdentifiantCategorie;
            beerModel.IdentifiantGamme = beer.IdentifiantGamme;
            beerModel.Commentaire = beer.Commentaire;

            beerModel.Categories = populateCategorie();
            beerModel.Gammes = populateGamme();
     

            return View(beerModel);
        }

        [HttpPost]
        public IActionResult Edit(BeerFormViewModel modifiedBeer)
        {
            BeerBDD beerBDD= new BeerBDD();

            IActionResult retour = null;
            if (ModelState.IsValid)
            {
                Beer beer = new Beer();

                beer.Identifiant = modifiedBeer.Identifiant;
                beer.Libelle = modifiedBeer.Libelle;
                beer.DateProduction = modifiedBeer.DateProduction;
                beer.TauxAlcoolemie = float.Parse(modifiedBeer.TauxAlcoolemie);
                beer.IdentifiantCategorie = modifiedBeer.IdentifiantCategorie;
                beer.IdentifiantGamme = modifiedBeer.IdentifiantGamme;
                beer.Commentaire = modifiedBeer.Commentaire;

                bool isOK = beerBDD.Update(beer);
                retour = RedirectToAction("Index");
            }
            else
            {
                retour = View(modifiedBeer);
            }

            return retour;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
