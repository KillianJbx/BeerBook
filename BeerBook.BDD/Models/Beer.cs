using System;

namespace BeerBook.BDD
{

    public class Beer
    {
        public int Identifiant { get; set; }
        public String Libelle { get; set; }
        public float TauxAlcoolemie { get; set; }
        public int? DateProduction { get; set; }
        public int IdentifiantCategorie { get; set; }
        public string Categorie { get; set; }
        public int IdentifiantGamme { get; set; }
        public string Gamme { get; set; }
        public string Commentaire { get; set; }
    }
}
