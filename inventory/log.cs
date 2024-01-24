using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class log
    {
        private string userName;
        private string pw;

        public string UserName { get => userName; set => userName = value; }
        public string Pw { get => pw; set => pw = value; }
    }

    class logGatway
    {
        DBConnector connector = null;
        SqlConnection connection = null;

        public logGatway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }

        public bool checkadmin(log lg)
        {
            connection.Open();

                string queryString = "SELECT * FROM userTb";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
            //    departments = new List<Department>();
            while (dataReader.Read())
            {
                log lo = new log();
                lo.UserName = dataReader["UserName"].ToString();
                lo.Pw = dataReader["UserPassword"].ToString();
                if (lg.UserName == lo.UserName && lg.Pw == lo.Pw)
                {
                    connection.Close();
                    return true;
                }

                
            }
            connection.Close();
            return false;

            
        
        }
    }


}
