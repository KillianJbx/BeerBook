using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BeerBook.BDD
{
    public class GammeBDD
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=beerbook; Integrated Security=true;";

        public List<Gamme> GetAll()
        {

            List<Gamme> gammes = new List<Gamme>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Identifiant, Libelle FROM Gamme";

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Gamme g = new Gamme();

                        g.Identifiant = (int)reader["Identifiant"];

                        g.Libelle = reader["Libelle"] is System.DBNull ? null : reader["Libelle"].ToString();

                        gammes.Add(g);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return gammes;
        }

        public Gamme Get(int id)
        {

            Gamme g = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT Identifiant, Libelle FROM Categorie
                  WHERE Identifiant = @identifiant";

                command.Parameters.AddWithValue("@identifiant", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    g = new Gamme();

                    g.Identifiant = (int)reader["Identifiant"];

                    g.Libelle = reader["Libelle"] is System.DBNull ? null : reader["Libelle"].ToString();



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return g;
        }

        public bool Insert(CategorieBDD categorie)
        {
            return true;
        }

        public bool Update(Categorie categorie)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
