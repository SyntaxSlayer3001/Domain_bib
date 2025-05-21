using Domain_bib.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Persistence
{
    public class Boekmapper
    {
        private readonly string _connectionString;

        public Boekmapper()
        {
            _connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
        }
        public void InsertBoek(string titel, int GenreId, string auteur, string uitgever, string taal, int graad, string isbn)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO tblboeken (Titel, GenreId, Auteur, Uitgever, Taal, Graad, ISBN) VALUES (@titel, @genreId, @auteur, @uitgever, @taal, @graad, @isbn)", connection);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@genreId", GenreId);
                command.Parameters.AddWithValue("@auteur", auteur);
                command.Parameters.AddWithValue("@uitgever", uitgever);
                command.Parameters.AddWithValue("@taal", taal);
                command.Parameters.AddWithValue("@graad", graad);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.ExecuteNonQuery();
            }
        }
        public List<Boek> GetBoeken()
        {
            var boekenlijst = new List<Boek>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("select * from tblboeken", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var boek = new Boek
                        {
                            Titel = reader["Titel"].ToString(),
                            GenreId = Convert.ToInt32(reader["GenreId"]),
                            Auteur = reader["Auteur"].ToString(),
                            Uitgever = reader["Uitgever"].ToString(),
                            Taal = reader["Taal"].ToString(),
                            Graad = Convert.ToInt32(reader["Graad"]),
                            Isbn = reader["ISBN"].ToString()
                        };
                        boekenlijst.Add(boek);
                    }
                }
            }
            return boekenlijst;
        }
        public bool ValidateLogin(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM tblgebruiker WHERE Email = @email AND Wachtwoord = @password";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password); // Let op: wachtwoorden horen gehasht te zijn!

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public int? GetRechtId(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT RechtID FROM tblgebruiker WHERE Email = @email AND Wachtwoord = @password";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int rechtId))
                        return rechtId;
                    else
                        return null;
                }
            }
        }
    }
}
