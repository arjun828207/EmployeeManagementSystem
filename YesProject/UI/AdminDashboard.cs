using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using YesProject.Management;

namespace YesProject.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            checkFaculty.CheckState = CheckState.Checked;
        }

        internal string leaveId;
        EmployeeNonFaculty employeeNonFaculty = new EmployeeNonFaculty();

        SqlConnection con =
            new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        private long? tax;

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            GetEmployeesRecords();
            GetLeaveRecords();
            GetTimeRecords();
        }

        private void GetEmployeesRecords()
        {
            employeeRecordView.DataSource = employeeNonFaculty.GetExistingEmployees("employee");
        }

        private void GetLeaveRecords()
        {
            leaveGridView.DataSource = employeeNonFaculty.GetExistingEmployees("leave");
        }

        private void GetTimeRecords()
        {
            timeRecordView.DataSource = employeeNonFaculty.GetExistingEmployees("time");
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            if (!validateValues())
                return;

            if (checkFaculty.Checked)
                CalculateTaxForFacutly(out tax);
            else
                tax =
                    CalculateTaxForNonFacutly();

            string taxCalculated = tax.ToString();

            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeTable VALUES(@name,@salary,@Id,@type,@faculty,@tax)",
                con);
            cmd.CommandType = CommandType.Text;
            SqlCommand cmdUser =
                new SqlCommand("INSERT INTO UserLogins VALUES(@userName,@userPassword,@name,@employeeId)", con);
            cmdUser.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@type", comboType.Text);
            cmd.Parameters.AddWithValue("@faculty", checkFaculty.Text);
            cmd.Parameters.AddWithValue("@tax", taxCalculated);
            cmdUser.Parameters.AddWithValue("@userName", userName.Text);
            cmdUser.Parameters.AddWithValue("@userPassword", userPass.Text);
            cmdUser.Parameters.AddWithValue("@name", txtName.Text);
            cmdUser.Parameters.AddWithValue("@employeeId", txtId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            cmdUser.ExecuteNonQuery();
            con.Close();
            GetEmployeesRecords();
            ResetFormControl();
            MessageBox.Show("Inserted Sucessfully");

        }

        private bool validateValues()
        {
            if (txtName.Text == "" || txtId.Text == "" || txtSalary.Text == "" || string.IsNullOrEmpty(comboType.Text)
                || checkFaculty.Text == "" || userName.Text == "" || userPass.Text == "")
            {
                MessageBox.Show("Values cannot be Empty", "Please ReEnter Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CalculateTaxForFacutly(out long? tax)
        {
            EmployeeFaculty employeeFaculty = new EmployeeFaculty();
            try
            {
                employeeFaculty.Salary = Convert.ToInt64(txtSalary.Text);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Salary field " + e.Message);
            }
            tax = employeeFaculty.CalculateTax(employeeFaculty.Salary);
        }

        private long CalculateTaxForNonFacutly()
        {
            EmployeeNonFaculty employeeNonFaculty = new EmployeeNonFaculty();
            try
            {
                employeeNonFaculty.Salary = Convert.ToInt64(txtSalary.Text);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Salary field" + e.Message);
            }

            return employeeNonFaculty.CalculateTax(employeeNonFaculty.Salary);
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            ResetFormControl();
        }

        private void ResetFormControl()
        {
            txtId.Clear();
            txtName.Clear();
            comboType.Clear();
            txtSalary.Clear();
            userName.Clear();
            userPass.Clear();
            txtName.Focus();
        }

        private void employeeRecordView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text= employeeRecordView.SelectedRows[0].Cells[2].Value.ToString();
            txtName.Text = employeeRecordView.SelectedRows[0].Cells[0].Value.ToString();
            txtSalary.Text = employeeRecordView.SelectedRows[0].Cells[1].Value.ToString();
            comboType.Text = employeeRecordView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void c1Button2_Click(object sender, EventArgs e)
        {
            if (checkFaculty.Checked)
                CalculateTaxForFacutly(out tax);
            else
                tax =
                    CalculateTaxForNonFacutly();

            string taxCalculated = tax.ToString();

            if (txtId.Text !="")
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE  EmployeeTable SET Name=@name,salary=@salary,[Type of work]=@type,[Faculty Member]=@faculty,[Tax]=@tax WHERE [Employee Id]=@Id",
                        con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@type", comboType.Text);
                cmd.Parameters.AddWithValue("@faculty", checkFaculty.Text);
                cmd.Parameters.AddWithValue("@tax", taxCalculated);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetEmployeesRecords();
                ResetFormControl();
                MessageBox.Show("Updated sucessfully");

            }
            else
            {
                MessageBox.Show("select any record");
            }
        }

        private void c1Button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "DELETE  EmployeeTable  WHERE [Employee Id]=@Id",
                        con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetEmployeesRecords();
                ResetFormControl();
                MessageBox.Show("Deleted sucessfully");
            }
            else
            {
                MessageBox.Show("select any record");
            }
        }

        private void checkFaculty_CheckedChanged(object sender, EventArgs e) =>
            comboType.ItemsDataSource=Enum.GetValues(checkFaculty.Checked ? typeof(QualificationValues) : typeof(TypeOfDutyValues));

        private void leaveRejectBtn_Click(object sender, EventArgs e)
        {
            if (leaveId != "")
            {
                employeeNonFaculty.RejectEmployeeLeave(leaveId);
                GetLeaveRecords();
            }
        }

        private void leaveApproveBtn_Click(object sender, EventArgs e)
        {
            if (leaveId != "")
            {
                employeeNonFaculty.ApproveEmployeeLeave(leaveId);
                GetLeaveRecords();
            }
        }
        
        private void leaveGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            leaveId = leaveGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

    }
}
