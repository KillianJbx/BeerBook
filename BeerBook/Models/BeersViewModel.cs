using BeerBook.BDD;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBook.Models
{
    public class BeersViewModel
    {
        public List<Beer> Beers { get; set; }
        public List<Categorie> Categories { get; set; }
        public List<Gamme> Gammes { get; set; }
    }
}
