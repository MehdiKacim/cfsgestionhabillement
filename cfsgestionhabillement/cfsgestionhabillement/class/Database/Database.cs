using SqlKata.Compilers;
using System;
using System.Data.SqlClient;
using SqlKata;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace cfsgestionhabillement.database
{
    public static class Database
    {
        public static string GetConnexionString()
        {
            return "Server=localhost;Database=cfs;Uid=root;Pwd=admin;";
        }

    }

}

