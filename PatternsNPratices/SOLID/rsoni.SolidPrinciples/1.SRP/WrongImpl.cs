using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.SolidPrinciples.SRP.WrongImpl
{
    public class Employee
    {
        public string EmpName { get; set; }
        public int EmpId { get; set; }

        public void InsertinDB(Employee emp)
        {
            // Insert into DB
        }

        public void GenerateReport(Employee emp)
        {
            // Generate Report.

        }


    }


}
