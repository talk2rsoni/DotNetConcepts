using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.SolidPrinciples.SRP.CorrectImpl
{
    public class Employee
    {
        public string EmpName { get; set; }
        public int EmpId { get; set; }

    }

    public class EmployeeDB
    {
        public void InsertinDB(Employee emp)
        {
            // Insert into DB
        }

        public Employee Select()
        {
            return new Employee();

        }
    }

    public class EmployeeReport
    {
        public void GenerateReport(Employee emp)
        {
            // Generate Report.

        }
    }
}
