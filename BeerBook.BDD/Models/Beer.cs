using System;

namespace BeerBook.BDD
{

    public class Beer
    {
        public int Identifiant { get; set; }
        public String Libelle { get; set; }
        public float TauxAlcoolemie { get; set; }
        public DateTime? DateProduction { get; set; }
        public int IdentifiantCategorie { get; set; }
        public int IdentifiantGamme { get; set; }
        public string Commentaire { get; set; }
    }
}
