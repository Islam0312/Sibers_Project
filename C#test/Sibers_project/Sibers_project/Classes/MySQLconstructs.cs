using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibers_project
{
    internal class MySQLconstructs
    {
        DataBaseConnection database = new DataBaseConnection();


        public void qerr(string qer) //метод для обработки запросов
        {
            database.openConnection();
            var command = new SqlCommand(qer, database.getConnaction());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("действие выполнено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
