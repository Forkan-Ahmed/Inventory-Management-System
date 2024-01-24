using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class DBConnector
    {
        //@"Data Source=DESKTOP-12UDCUG\SQLEXPRESS;Initial Catalog=ManageUser;Integrated Security=True");
        string connectionString = @"Data Source=DESKTOP-12UDCUG\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ManageUser";

        SqlConnection connection = null;

        public DBConnector()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection Connection { get => connection; }
    }
}
