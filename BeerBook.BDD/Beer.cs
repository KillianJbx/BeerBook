using System;

namespace BeerBook.BDD
{

    public class Beer
    {
        public int Identifiant { get; set; }
        public string Libelle { get; set; }
        public int IdentifiantCategorie { get; set; }
        public int IdentifiantGamme { get; set; }
        public float TauxAlcoolemie { get; set; }
        public float Prix { get; set; }
        public DateTime? DateProduction { get; set; }
        public string Commentaire { get; set; }
    }
}
