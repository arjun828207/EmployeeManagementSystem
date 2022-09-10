using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesProject.Management;
namespace YesProject.UI
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public  TextBox UserNametxt;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\apandey\Documents\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            UserNametxt = userNameBox;

        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            userNameBox.Clear();
            passwordBox.Clear();
            userNameBox.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            SqlCommand cmd =
                new SqlCommand(
                    "select * from UserLogins where UserName='" + userNameBox.Text + "'and Password='" +
                    passwordBox.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count > 0 && userNameBox.Text=="admin")
            {
                this.Hide();
                AdminDashboard mainForm = new AdminDashboard();
                mainForm.ShowDialog();
            }
            else if(dataTable.Rows.Count > 0 && userNameBox.Text != "admin")
            {
                this.Hide();
                EmployeeDashboard mainForm = new EmployeeDashboard();
                mainForm.getEmployeeId(userNameBox.Text);
                mainForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Credentials Incorrect");
                userNameBox.Clear();
                passwordBox.Clear();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
