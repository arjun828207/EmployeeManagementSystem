using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesProject.Data;

namespace YesProject.Management
{

    class UserLogins
    {
        EmployeeDataBaseManager employeeData=new EmployeeDataBaseManager();

        internal string userName { get; set; }
        internal string name { get; set; }
        internal string eid { get; set; }

        internal string GetEmployeeId(string userName)
        {
            return employeeData.QueryEmployeeId(userName);
        }
    }
}
