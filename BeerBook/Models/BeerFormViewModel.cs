using BeerBook.BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBook.Models
{
    public class BeerFormViewModel
    {
        public int Identifiant { get; set; }

        [Display(Name = "Libellé")]
        [Required(ErrorMessage = "Le libellé est obligatoire")]
        public string Libelle { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime? DateProduction { get; set; }

        [Display(Name = "Catégorie")]
        [Required(ErrorMessage = "La Catégorie est obligatoire")]
        public int IdentifiantCategorie { get; set; }

        [Display(Name = "Alcoolémie")]
        [Required(ErrorMessage = "Le Taux d'alcoolémie est obligatoire")]
        public float TauxAlcoolemie { get; set; }

        [Display(Name = "Gamme")]
        [Required(ErrorMessage = "La Gamme de prix est obligatoire")]
        public int IdentifiantGamme{ get; set; }

        [Display(Name = "Description")]
        public String Commentaire { get; set; }

        public Beer ToBeer()
        {
            Beer beer = new Beer();
            beer.Libelle = this.Libelle;
            beer.DateProduction = this.DateProduction;
            beer.TauxAlcoolemie = this.TauxAlcoolemie;
            beer.IdentifiantCategorie = this.IdentifiantCategorie;
            beer.IdentifiantGamme = this.IdentifiantGamme;
            beer.Commentaire = this.Commentaire;
            beer.Identifiant = this.Identifiant;

            return beer;
        }
    }
}
