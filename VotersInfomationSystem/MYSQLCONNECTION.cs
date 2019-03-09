using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TeamJocas
{
    class MYSQLCONNECTION
    {
        public MySqlConnection conn;
        public void Connection()
        {
            conn = new MySqlConnection("server = 192.168.0.10; user id = root; database = teamjocas");
            // MYSQLCONNECTION conn = new MYSQLCONNECTION ();
            // conn.Connection();
        }
    }
}
