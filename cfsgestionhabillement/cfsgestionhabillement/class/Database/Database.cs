using SqlKata.Compilers;
using System;
using System.Data.SqlClient;
using SqlKata;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace cfsgestionhabillement.database
{
    public class Database
    {
        MySqlConnection mSqlConn = null;
        public Database()
        {
            MySqlConnection connection = new MySqlConnection(
                "Host=127.0.0.1;Port=3306;User=root;Password=;Database=cfs_gestion_habillement;SslMode=None"
            );

            mSqlConn = connection;
        }

        public MySqlConnection GetMySqlConnection()
        {
            return this.mSqlConn;
        }


    }
}

