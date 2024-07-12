using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesRecord
{
    internal class Employee
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfJoining { get; set; }

        public bool Insert()
        {
            try
            {
                string sql = "INSERT INTO employee (FirstName, LastName, Email, Occupation, PhoneNumber, DateOfBirth, DateOfJoining) VALUES ('"
                    + FirstName + "', '"
                    + LastName + "', '"
                    + Email + "', '"
                    + Occupation + "', '"
                    + PhoneNumber + "', '"
                    + DateOfBirth + "', '"
                    + DateOfJoining + "')";

                SqlConnection con = new DBConnection().openConnection();
                SqlCommand cmd = new SqlCommand(sql, con);

                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Console.WriteLine("INSERT SUCCESSFUL. RESULT IS: " + res);
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL EXCEPTION OCCURRED HERE: " + ex.Message);
                return false;
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("EXCEPTION OCCURRED HERE: " + ex.Message);
                return false;
            }

        }

        public static DataTable getAll()
        {
            string sql = "SELECT Employee, FirstName, LastName, Email, Occupation, PhoneNumber, DateOfBirth, DateOfJoining FROM employee";

            SqlConnection con = new DBConnection().openConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns.Add();
            int res = cmd.ExecuteNonQuery();

            return table;
        }

        public bool Update(int currentId)
        {
            try
            {
                string sql = "UPDATE employee SET "
                     + "FirstName = '" + FirstName + "', "
                     + "LastName = '" + LastName + "', "
                     + "Email = '" + Email + "', "
                     + "Occupation = '" + Occupation + "', "
                     + "PhoneNumber = '" + PhoneNumber + "', "
                     + "DateOfBirth = '" + DateOfBirth + "', "
                     + "DateOfJoining = '" + DateOfJoining + "' "
                     + "WHERE Employee = " + currentId;

                SqlConnection con = new DBConnection().openConnection();
                SqlCommand cmd = new SqlCommand(sql, con);

                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Console.WriteLine("INSERT SUCCESSFUL. RESULT IS: " + res);
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL EXCEPTION OCCURRED HERE: " + ex.Message);
                return false;
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("EXCEPTION OCCURRED HERE: " + ex.Message);
                return false;
            }
        }

        public static bool Delete(int currentId)
        {
            try
            {
                string sql = "DELETE FROM employee WHERE Employee = '" + currentId + "'";

                SqlConnection con = new DBConnection().openConnection();
                SqlCommand cmd = new SqlCommand(sql, con);

                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Console.WriteLine("INSERT SUCCESSFUL. RESULT IS: " + res);
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL EXCEPTION OCCURRED HERE: " + ex.Message);
                return false;
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("EXCEPTION OCCURRED HERE: " + ex.Message);
                return false;
            }
        }
    }
}
