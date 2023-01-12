using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibers_project
{
    internal class DataBaseConnection
    {
        

        static string
            serversql_ = "LIMAS-PC\\MSSQLSERVER01",//сервер меняем тут
            dbsql_ = "db_project_app";//база данных


        

        SqlConnection sc = new SqlConnection($@"Data source={serversql_};Initial Catalog={dbsql_};Integrated Security=True");

        public void openConnection()
        {
            if (sc.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    sc.Open();
                }
                catch 
                {
                    MessageBox.Show("сервер или база данных указаны не верно");
                    Process.GetCurrentProcess().Kill();
                }
            }
        }
        public void closeConnection()
        {
            if (sc.State == System.Data.ConnectionState.Open)
            {
                sc.Close();
            }
        }
        public SqlConnection getConnaction()
        {
            return sc;
        }

    }
}
