using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesRecord
{
    internal class DBConnection
    {
        private string connString;
        private SqlConnection sqlConnection;

        public SqlConnection openConnection()
        {
            try
            {
                connString = "Data Source=NASRR;Initial Catalog=employee;Integrated Security=True;Encrypt=False";
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();
                System.Diagnostics.Debug.WriteLine("CONNECTION PASSED!");

            }

            catch (Exception ex)
            { 
                System.Diagnostics.Debug.WriteLine("ERROR OCCURED IN DATABASE CONNECTION: " + ex.Message); 
            }
            
            return sqlConnection;
        }
    }
}
