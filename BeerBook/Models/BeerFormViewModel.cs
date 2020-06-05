using BeerBook.BDD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBook.Models
{
    public class BeerFormViewModel
    {
        [HiddenInput]
        public int Identifiant { get; set; }

        [Display(Name = "Nom de la bière")]
        [Required(ErrorMessage = "Le libellé est obligatoire")]
        public string Libelle { get; set; }

        [Display(Name = "Année de mise en production")]
        [Required(ErrorMessage = "Bien que la Base de donnée accepte ce champs à valeur nulle, moi je vous oblige à le compléter.")]
        public int? DateProduction { get; set; }

        [Display(Name = "Catégorie")]
        [Required(ErrorMessage = "La Catégorie est obligatoire")]
        public int  IdentifiantCategorie { get; set; }

        public List<SelectListItem> Categories { get; set; }

        [Display(Name = "Taux d'alcoolémie")]
        [Required(ErrorMessage = "Le taux d'alcoolémie est obligatoire")]
        public string TauxAlcoolemie { get; set; }


        [Display(Name = "Gamme de prix")]
        [Required(ErrorMessage = "La Gamme de prix est obligatoire")]
        public int IdentifiantGamme{ get; set; }

        public List<SelectListItem> Gammes { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Idem que la date :D")]
        public String Commentaire { get; set; }

    }
}
