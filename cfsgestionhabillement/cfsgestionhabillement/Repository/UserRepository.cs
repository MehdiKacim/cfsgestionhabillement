using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata;
using cfsgestionhabillement.database;
using cfsgestionhabillement.Entity;
using MySql.Data.MySqlClient;
namespace cfsgestionhabillement.Repository
{
    class UserRepository
    {
        Database DbConn = null;
        MySqlConnection MySqlConn = null;
        public UserRepository(Database db)
        {
            DbConn = db;
            MySqlConn = db.GetMySqlConnection();
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            User user = new User();
            Fonction fonction = new Fonction();
            MySqlConn.Open();
            var cmd = new MySqlCommand("SELECT * FROM secouristes,fonctions where secouristes.ID_FONCTION_ENUM = fonctions.ID_FONCTIONS ;", MySqlConn);
            
            MySqlDataReader rdr = cmd.ExecuteReader();
            int outInt = 0;
            bool outBool = false;
            while (rdr.Read())
            {
                int.TryParse(rdr.GetString("ID_SECOURISTE"), out outInt);
                user.ID_SECOURISTE = outInt;
                int.TryParse(rdr.GetString("ID_FONCTION_ENUM"), out outInt);
                fonction.ID_FONCTION_ENUM = outInt;
                bool.TryParse(rdr.GetString("CAUTION"), out outBool);
                user.CAUTION = outBool;
                int.TryParse(rdr.GetString("ID_FONCTIONS"), out outInt);
                fonction.ID_FONCTIONS = outInt;
                fonction.LIBELLE = rdr.GetString("LIBELLE");
                user.NOM = rdr.GetString("NOM");
                user.PRENOM = rdr.GetString("PRENOM");
                user.USERNAME = rdr.GetString("USERNAME");
                user.PASSWORD = rdr.GetString("PASSWORD");
                user.ADRESSE = rdr.GetString("ADRESSE");
                user.CODE_POSTAL = rdr.GetString("CODE_POSTAL");
                user.VILLE = rdr.GetString("VILLE");
                user.EMAIL = rdr.GetString("EMAIL");
                user.CAUTION = outBool;
                user.FONCTION = fonction;
                users.Add(user);
            }
            rdr.Dispose();
            MySqlConn.Dispose();
            return users;
        }
    }
}
