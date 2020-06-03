using BeerBook.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBook.Models
{
    public class BeerDeleteViewModel
    {
        public Beer Beer { get; set; }
        public Categorie Categorie { get; set; }
        public Gamme Gamme { get; set; }
    }
}
