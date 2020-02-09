using cfsgestionhabillement.database;
using cfsgestionhabillement.Entity;
using MySql.Data.MySqlClient;

namespace cfsgestionhabillement.Repository
{
    class FonctionRepository
    {
        Database DbConn = null;
        MySqlConnection MySqlConn = null;
        public FonctionRepository(Database db)
        {
            DbConn = db;
            MySqlConn = db.GetMySqlConnection();
        }
    }
}
