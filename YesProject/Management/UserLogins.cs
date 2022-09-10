using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesProject.Management
{

    class UserLogins
    {
        internal string userName { get; set; }
        internal string name { get; set; }
        internal string eid { get; set; }

        internal string getEmployeeId(string userName)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");
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
