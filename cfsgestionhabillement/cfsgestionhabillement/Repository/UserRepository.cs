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
            MySqlConn.Open();
            var cmd = new MySqlCommand("SELECT * FROM secouristes;", MySqlConn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                
            }
            rdr.Dispose();
            MySqlConn.Dispose();
            return users;
        }
    }
}
