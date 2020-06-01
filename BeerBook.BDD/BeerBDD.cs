using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BeerBook.BDD
{
    public class BeerBDD
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=beerbook; Integrated Security=true;";

        public bool Insert(Beer beer)
        {
            int nbLignes = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();

                command.CommandText = @"
                INSERT INTO Beers (Libelle, DateProd, TauxAlcool, IdentifiantCategorie,IdentifiantGamme, Commentaire) 
                VALUES(@Libelle, @DateProd, @TauxAlcool, @IdentifiantCategorie, @IdentifiantGamme, @Commentaire);";

                command.Parameters.AddWithValue("@Titre", beer.Libelle);
                command.Parameters.AddWithValue("@DateBug", beer.DateProduction);
                command.Parameters.AddWithValue("@Bloquage", beer.TauxAlcoolemie);
                command.Parameters.AddWithValue("@IdentifiantCategorie", beer.IdentifiantCategorie);
                command.Parameters.AddWithValue("@IdentifiantGamme", beer.IdentifiantGamme);
                command.Parameters.AddWithValue("@Commentaire", beer.Commentaire);

                try
                {
                    connection.Open();
                    nbLignes = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return nbLignes == 1;
        }
    }
}
