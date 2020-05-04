using cfsgestionhabillement.database;
using cfsgestionhabillement.Entity;
using MySql.Data.MySqlClient;
using RepoDb;
using System.Linq;

namespace cfsgestionhabillement.Repository
{
    class FonctionRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public FonctionRepository()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public roleapplicatif GetFonctionCurrentUser()
        {
            using (var connection = new MySqlConnection(Database.GetConnexionString()))
            {
                var role = connection.Query<roleapplicatif>(e => e.ID_Fonction == Security.Security.CurrentUser.ID_Fonction);
                return role.First();
            }
        }
    }
}
