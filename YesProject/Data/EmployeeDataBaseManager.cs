using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            return string.Empty;

        }

        internal SqlCommand GetExistingEmployeeRecords(string tableName)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();

                switch (tableName)
                {
                    case "employee":
                        cmd = new SqlCommand("select * from EmployeeTable", con);
                        break;
                    case "leave":
                        cmd = new SqlCommand("SELECT * FROM Leave", con);
                        break;
                    case "time":
                        cmd = new SqlCommand("SELECT * FROM TimeLogging ", con);
                        break;
                }

                return cmd;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                con.Close();
            }

            return cmd;

        }

        internal SqlCommand GetRecordsForCurrentEmployee(string tableName)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();

                switch (tableName)
                {
                    case "leave":
                        cmd = new SqlCommand("select * from leave where eid=@eid", con);
                        break;
                    case "time":
                        cmd = new SqlCommand("select * from timelogging where eid=@eid", con);
                        break;
                }

                return cmd;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                con.Close();
            }

            return cmd;
        }

        internal DataTable ExecuteReaderForTable(SqlCommand cmd)
        {
            DataTable dataTable = new DataTable();
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            cmd.Connection.Close();
            return dataTable;
        }

        internal DataTable ExecuteReaderCurrentForTable(SqlCommand cmd,string uniqueId)
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@eid", uniqueId);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }

        internal void LeaveApprove(string eid)
        {
            try
            {
                string query = "UPDATE Leave SET ApprovalStatus='Approved' WHERE LeaveId=@eid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@eid", eid);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Leave Approved Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        internal void LeaveReject(string eid)
        {
            try
            {
                string query = "UPDATE Leave SET ApprovalStatus='Rejected' WHERE LeaveId=@eid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@eid", eid);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Leave Rejected Successfully !!", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
