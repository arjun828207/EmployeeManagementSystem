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
    enum QualificationValues
    {
        Graduation,
        PostGraduation,
        PGT,
        TGT,
        Phd
    }
    class EmployeeFaculty:Employees
    {
        private EmployeeDataBaseManager dataBaseManager = new EmployeeDataBaseManager();

       internal string SubjectTeacher { get; set; }

        internal string QualificationOfFaculty { get; set; }

        public override long CalculateTax(long salary)
        {
            if (salary < 500000)
                return 0;
            else if (salary > 500000)
                return (long)(salary * 0.15);
            else
                return (long)0.30 * salary;
        }

        internal DataTable GetRecordsForCurrentEmployee(string tableName,string uniqueId)
        {
            SqlCommand cmd=dataBaseManager.GetRecordsForCurrentEmployee(tableName);
            return dataBaseManager.ExecuteReaderCurrentForTable(cmd, uniqueId);
        }
    }
}
