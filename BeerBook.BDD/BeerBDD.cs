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

                command.Parameters.AddWithValue("@Libelle", beer.Libelle);
                command.Parameters.AddWithValue("@DateProd", beer.DateProduction);
                command.Parameters.AddWithValue("@TauxAlcool", beer.TauxAlcoolemie);
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

        public List<Beer> GetAll()
        {

            List<Beer> beers = new List<Beer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Identifiant, Libelle, DateProd, TauxAlcool, Commentaire, IdentifiantCategorie, IdentifiantGamme FROM Beers";

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Beer b = new Beer();

                        b.Identifiant = (int)reader["Identifiant"];

                        b.Libelle = reader["Libelle"] is System.DBNull ? null : reader["Libelle"].ToString();

                        b.DateProduction = (int)reader["DateProd"];

                        b.TauxAlcoolemie = (float)reader["TauxAlcool"];

                        b.Commentaire = (string)reader["Commentaire"];

                        b.IdentifiantCategorie = Int32.Parse(reader["identifiantCategorie"].ToString());

                        b.IdentifiantGamme = Int32.Parse(reader["identifiantGamme"].ToString());

                        beers.Add(b);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return beers;
        }

        public Beer Get(int id)
        {

            Beer b = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT Identifiant, Libelle, DateProd, TauxAlcool, Commentaire, IdentifiantCategorie, IdentifiantGamme FROM Beers
                  WHERE Identifiant = @identifiant";

                command.Parameters.AddWithValue("@identifiant", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    b = new Beer();

                    b.Identifiant = (int)reader["Identifiant"];

                    b.Libelle = reader["Libelle"] is System.DBNull ? null : reader["Libelle"].ToString();

                    b.DateProduction = (int)reader["DateProd"];

                    b.TauxAlcoolemie = (float)reader["TauxAlcool"];

                    b.Commentaire = (string)reader["Commentaire"];

                    b.IdentifiantCategorie = Int32.Parse(reader["identifiantCategorie"].ToString());

                    b.IdentifiantGamme = Int32.Parse(reader["identifiantGamme"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return b;
        }

        public bool Delete(int id)
        {
            int nbLignes = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "DELETE FROM beers WHERE Identifiant = @id";

                command.Parameters.AddWithValue("id", id);
                try
                {
                    connection.Open();
                    nbLignes = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }

            return nbLignes == 1;
        }

        public bool Update(Beer b)
        {
            int nbLignes = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = @"
                    UPDATE Beers
                       SET [Libelle] = @Libelle
                          ,[DateProd] = @DateProd
                          ,[TauxAlcool] = @TauxAlcool
                          ,[IdentifiantCategorie] = @IdentifiantCategorie
                          ,[IdentifiantGamme] = @IdentifiantGamme
                          ,[Commentaire] = @Commentaire
                     WHERE Identifiant = @id";
                command.Parameters.AddWithValue("@id", b.Identifiant);
                command.Parameters.AddWithValue("@Libelle", b.Libelle);
                command.Parameters.AddWithValue("@DateProd", b.DateProduction);
                command.Parameters.AddWithValue("@TauxAlcool", b.TauxAlcoolemie);
                command.Parameters.AddWithValue("@IdentifiantCategorie", b.IdentifiantCategorie);
                command.Parameters.AddWithValue("@IdentifiantGamme", b.IdentifiantGamme);
                command.Parameters.AddWithValue("@Commentaire", b.Commentaire);

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
