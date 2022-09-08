using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
