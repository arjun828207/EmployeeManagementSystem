using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using YesProject.Management;

namespace YesProject
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
            checkBox1.CheckState = CheckState.Checked;
        }
        EmployeeNonFaculty EmployeeNonFaculty = new EmployeeNonFaculty();
        EmployeeFaculty EmployeeFaculty = new EmployeeFaculty();
        long? tax;
        private void calBtn_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                TakeInputForFaculty(out tax);
            else
                tax = TakeInputForNonFaculty();

            string res = tax.ToString();
            MessageBox.Show(res);
        }

        private void TakeInputForFaculty(out long? tax)
        {
            EmployeeFaculty.EmployeeId = eid.Text;
            EmployeeFaculty.Name = nm.Text;
            try
            {
                EmployeeFaculty.Salary = Convert.ToInt64(sal.Text);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Salary field " + e.Message);
            }
            tax = EmployeeFaculty.CalculateTax(EmployeeFaculty.Salary);
            EmployeeFaculty.QualificationOfFaculty = comboBox1.SelectedValue.ToString();
        }

        private long TakeInputForNonFaculty()
        {
            EmployeeNonFaculty.EmployeeId = eid.Text;
            EmployeeNonFaculty.Name = nm.Text;
            try
            {
                EmployeeNonFaculty.Salary = Convert.ToInt64(sal.Text);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Salary field" + e.Message);
            }

            long tax = EmployeeNonFaculty.CalculateTax(EmployeeNonFaculty.Salary);
            EmployeeNonFaculty.TypeOfDuty = comboBox1.SelectedItem.ToString();
            return tax;
        }

        private void OnCheckBox1CheckedChanged(object sender, EventArgs e) =>
            comboBox1.DataSource =
                Enum.GetValues(checkBox1.Checked ? typeof(QualificationValues) : typeof(TypeOfDutyValues));

        private void OnC1Button1Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeTable VALUES('" + nm.Text + "','" + sal.Text + "','" + eid.Text + "','" + comboBox1.Text + "','" + checkBox1.Checked + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted data succesfully");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}
