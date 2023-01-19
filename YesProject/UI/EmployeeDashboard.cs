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
            SetLeaveTypeValues();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");
        private EmployeeFaculty employeeFaculty = new EmployeeFaculty();

        private void EmployeeDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnEmployeeDashBoardLoad(object sender, EventArgs e)
        {
            GetLeaveRecords();
            GetAttendanceRecord();
        }

        private void SetLeaveTypeValues() => leaveType.DataSource = Enum.GetValues(typeof(LeaveType));

        private void button1_Click(object sender, EventArgs e)
        {
            string approvalStatus = "Pending";
            SqlCommand cmd = new SqlCommand("INSERT INTO Leave VALUES(@eid,@startDate,@endDate,@comments,@leaveType,@approvalStatus)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@eid",eidSet);
            cmd.Parameters.AddWithValue("@startDate", Convert.ToDateTime(startDate.Text));
            cmd.Parameters.AddWithValue("@endDate",Convert.ToDateTime(endDate.Text));
            cmd.Parameters.AddWithValue("@comments", commentBox.Text);
            cmd.Parameters.AddWithValue("@leaveType", leaveType.Text);
            cmd.Parameters.AddWithValue("@approvalStatus", approvalStatus);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetLeaveRecords();
        }

        public void getEmployeeId(string userName)
        {
            UserLogins userLogins = new UserLogins();
            eidSet = userLogins.GetEmployeeId(userName);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TimeLogging VALUES(@eid,@startTime,@endTime)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@eid", eidSet);
            cmd.Parameters.AddWithValue("@startTime", Convert.ToDateTime(logInTime.Text));
            cmd.Parameters.AddWithValue("@endTime", Convert.ToDateTime(logOutTime.Text));
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetAttendanceRecord();
        }

        private void GetLeaveRecords()
        {
            leaveRecordGrid.DataSource = employeeFaculty.GetRecordsForCurrentEmployee("leave", eidSet);
        }

        private void GetAttendanceRecord()
        {
            attendanceRecordGrid.DataSource = employeeFaculty.GetRecordsForCurrentEmployee("time", eidSet);

        }
    }
}
