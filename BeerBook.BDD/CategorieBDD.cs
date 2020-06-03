using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BeerBook.BDD
{
    public class CategorieBDD
    {

            private string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=beerbook; Integrated Security=true;";

            public List<Categorie> GetAll()
            {

                List<Categorie>categories = new List<Categorie>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT Identifiant, Libelle FROM Categorie";

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Categorie c = new Categorie();

                            c.Identifiant = (int)reader["Identifiant"];

                            c.Libelle = reader["Libelle"] is System.DBNull ? null : reader["Libelle"].ToString();

                            categories.Add(c);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                return categories;
            }

        public Categorie Get(int id)
        {

            Categorie c = null;
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

                    c = new Categorie();

                    c.Identifiant = (int)reader["Identifiant"];

                    c.Libelle = reader["Libelle"] is System.DBNull ? null : reader["Libelle"].ToString();

                   

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return c;
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



