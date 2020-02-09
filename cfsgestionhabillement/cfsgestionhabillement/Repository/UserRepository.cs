using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata;
using cfsgestionhabillement.database;
using cfsgestionhabillement.Entity;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

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


        public bool CheckConnexion(string username, string password)
        {
            string sql = "SELECT * FROM secouristes,fonctions where secouristes.ID_FONCTION_ENUM = fonctions.ID_FONCTIONS";
            sql +=  " AND USERNAME='" + username + "'";
            sql +=  " AND PASSWORD='" + password + "'";
            MySqlConn.Open();
            var cmd = new MySqlCommand(sql, MySqlConn);

            User user = new User();
            MySqlDataReader rdr = cmd.ExecuteReader();
            string hash;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            }
            bool outBool = false;
            while (rdr.Read())
            {
                    outBool = rdr.HasRows;
            }
            rdr.Dispose();
            MySqlConn.Dispose();
            return outBool;
        }
    }
}
