using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using YesProject.Management;
namespace YesProject.UI
{
    public partial class EmployeeDashboard : Form 
    {
        private string eid = null;
        public string eidSet
        {
            set { if (eid == null) eid = value; }
            get { return eid; }
        }

        public EmployeeDashboard()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        private void EmployeeDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Leave VALUES(@eid,@startDate,@endDate,@comments,@leaveType)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@eid",eidSet);//TO DO
            cmd.Parameters.AddWithValue("@startDate", Convert.ToDateTime(startDate.Text));
            cmd.Parameters.AddWithValue("@endDate",Convert.ToDateTime(endDate.Text));
            cmd.Parameters.AddWithValue("@comments", commentBox.Text);
            cmd.Parameters.AddWithValue("@leaveType", leaveType.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void getEmployeeId(string userName)
        {
            UserLogins userLogins = new UserLogins();
            eidSet = userLogins.getEmployeeId(userName);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TimeLogging VALUES(@eid,@startTime,@endTime,@approvalStatus)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@eid", eidSet);
            cmd.Parameters.AddWithValue("@startTime", Convert.ToDateTime(logInTime.Text));
            cmd.Parameters.AddWithValue("@endTime", Convert.ToDateTime(logOutTime.Text));
            cmd.Parameters.AddWithValue("@approvalStatus", "False");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           // string y=LoginForm.instance.UserNametxt.Text;
        }
    }
}
