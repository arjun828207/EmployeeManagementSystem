using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesProject.Management
{
    enum  LeaveType
    {
        Maternity,
        Paternity,
        Casual,
        Sick,
        Vacation
    }

    abstract class Employees
    {
        internal string Name { get; set; }
        internal string EmployeeId { get; set; }
        internal long Salary { get; set; }
        public abstract long CalculateTax(long salary);
    }
}


