using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YesProject.Data;
using System.Threading.Tasks;

namespace YesProject.Management
{
    enum TypeOfDutyValues
    {
        Cleaning,
        Stationary,
        Clerk,
        Security
    }
    class EmployeeNonFaculty : Employees
    {
        private EmployeeDataBaseManager employeeDataBase = new EmployeeDataBaseManager();

       internal string Department { get; set; }
       internal int DutyBlock { get; set; }
       internal string TypeOfDuty { get; set; }

        public override long CalculateTax(long salary)
        {
            if (salary < 500000)
                return 0;
            else if (salary > 500000)
                return (long)(salary * 0.25);
            else
                return (long)0.45 * salary;
        }

        internal  DataTable GetExistingEmployees(string tableName)
        {
            SqlCommand command= employeeDataBase.GetExistingEmployeeRecords(tableName);
            DataTable table = employeeDataBase.ExecuteReaderForTable(command);
            return table;
        }

        internal void RejectEmployeeLeave(string eid)
        {
            employeeDataBase.LeaveReject(eid);
        }

        internal void ApproveEmployeeLeave(string eid)
        {
            employeeDataBase.LeaveApprove(eid);
        }
    }
}
