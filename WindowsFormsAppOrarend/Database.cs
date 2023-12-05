using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppOrarend
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                nyit();
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);    
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public int validUser(string name, string password)
        {
            nyit();
            int userId = -1;
            command.CommandText = "SELECT `tanarnev` , `jelszo` FROM `tanarok` WHERE tanarnev = @tanarnev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tanarnev", name);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                if (taroltJelszo.Equals(password))
                {
                    userId = reader.GetInt32("jelszo");
                }
                userId = reader.GetInt32("jelszo");
                
            }
            return userId;
            zar();
        }

        public List<Orak> getTanorak()
        {
            nyit(); 
            List<Orak> orak = new List<Orak>();
            command.CommandText = "SELECT `tantargy`, `sorszam`, `hetnapja` FROM `orak` ORDER BY tantargy";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    orak.Add(new Orak(dr.GetString("tantargy"), dr.GetInt32("sorszam"), dr.GetString("hetnapja"));
                }
            }
        }
    }
}
