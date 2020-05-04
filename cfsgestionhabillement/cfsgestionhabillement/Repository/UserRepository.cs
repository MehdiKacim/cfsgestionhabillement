using System.Linq;
using cfsgestionhabillement.database;
using cfsgestionhabillement.Entity;
using MySql.Data.MySqlClient;
using RepoDb;
using System.Collections.Generic;

namespace cfsgestionhabillement.Repository
{
    class UserRepository
    {
        public UserRepository()
        {
            RepoDb.MySqlBootstrap.Initialize();
        }

        /// <summary>
        /// Connexion
        /// </summary>
        /// <param name="pUSERNAME"></param>
        /// <param name="pPASSWORD"></param>
        /// <returns></returns>
        public bool Connection(string pUSERNAME, string pPASSWORD)
        {
            using (var connection = new MySqlConnection(Database.GetConnexionString()))
            {
                var person = connection.Query<Secouriste>(e => e.Username_Secouriste == pUSERNAME && e.Password_Secouriste == pPASSWORD);
                if (person.Any())
                {
                    Security.Security.CurrentUser = person.First();
                    Security.Security.IsAuth = person.Any();
                }
                return person.Any();
            }
        }

        /// <summary>
        /// CheckRow
        /// </summary>
        /// <param name="secouriste"></param>
        /// <returns></returns>
        public Dictionary<string,bool> CheckRow(Secouriste secouriste)
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();
            result.Add("CodePostal_Secouriste", true);
            result.Add("Num_Tel", true);
            result.Add("Email", true);

            if(secouriste.CodePostal_Secouriste.Length != 5)
            {
                result["CodePostal_Secouriste"] = false;
            }

            if(secouriste.NumeroTel_Secouriste.Length != 10)
            {
                result["Num_Tel"] = false;
            }

            if(!secouriste.Email_Secouriste.Contains("@") || !secouriste.Email_Secouriste.Contains("."))
            {
                result["Email"] = false;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pRow"></param>
        public bool Update(Secouriste pRow)
        {
            using (var connection = new MySqlConnection(Database.GetConnexionString()))
            {
                var updatedRows = connection.Update<Secouriste>(pRow);
                return updatedRows == 1;
            }
        }

    }
}
