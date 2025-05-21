using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Domain_bib.Business
{
    public class Controller
    {
        private string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";

        public bool ValidateLogin(string username, string password)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM tblgebruiker WHERE tblgebruiker = @tblgebruiker AND password = @password";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Let op: wachtwoorden horen gehasht te zijn!

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}

