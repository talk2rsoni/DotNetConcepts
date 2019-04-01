using System;
using InterfacevsAbstractClass.AbstractClasses;
using InterfacevsAbstractClass.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoni.UtilsLibrary;

namespace InterfacevsAbstractClass.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IEmployee emp;
            Emp_fulltime2 emp1 = new Emp_fulltime2();

            emp = emp1;
            emp.ID = "2234";
            emp.FirstName = "Rahman";
            emp.LastName = "Mahmoodi";
            //call add method od the object


            Utility.LogEntry(emp.Add().ToString());

            //call the CalculateWage method
            Utility.LogEntry(emp.CalculateWage().ToString());

        }

        [TestMethod]
        public void TestMethod2()
        {
            Employee emp;
            emp = new Emp_Fulltime();


            emp.ID = "2244";
            emp.FirstName = "Maria";
            emp.LastName = "Robinlius";
            Utility.LogEntry(emp.Add().ToString());

            //call the CalculateWage method
            Utility.LogEntry(emp.CalculateWage().ToString());
        }
    }
}
