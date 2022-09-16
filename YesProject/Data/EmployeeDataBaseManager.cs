using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesProject.Data
{
    class EmployeeDataBaseManager
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");


        internal string QueryEmployeeId(string userName)
        {
            SqlCommand cmd = new SqlCommand("select Eid from UserLogins WHERE UserName=@userName", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", userName);
            try
            {
                con.Open();
                return (string)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }

            return "";

        }
    }
}
