using System;

namespace BeerBook.BDD
{
    public class Beer
    {
        public int Identifiant { get; set; }
        public string Libelle { get; set; }
        public string Type { get; set; }
        public float TauxAlcoolemie { get; set; }
        public float Prix { get; set; }
        public DateTime DateProduction { get; set; }
        public string Description { get; set; }
    }
}
