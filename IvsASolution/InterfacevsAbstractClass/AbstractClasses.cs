using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacevsAbstractClass.AbstractClasses
{

    /// 


    /// Summary description for Employee.

    /// 


    public abstract class Employee
    {
        //we can have fields and properties 
        //in the Abstract class

        protected String id;
        protected String lname;
        protected String fname;

        //properties
        public abstract String ID
        {
            get;
            set;
        }

        public abstract String FirstName
        {
            get;
            set;
        }

        public abstract String LastName
        {
            get;
            set;
        }

        //completed methods
        public String Update()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " updated";
        }

        //completed methods
        public String Add()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " added";
        }

        //completed methods
        public String Delete()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " deleted";
        }

        //completed methods
        public String Search()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " found";
        }

        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore i keep it uncompleted and 
        //let each implementation 
        //complete it the way they calculate the wage.
        public abstract String CalculateWage();

    }

    //Inheriting from the Abstract class
    public class Emp_Fulltime : Employee
    {
        //uses all the properties of the 
        //Abstract class therefore no 
        //properties or fields here!

        public Emp_Fulltime()
        {
        }

        public override String ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public override String FirstName
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public override String LastName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        //common methods that are 
        //implemented in the abstract class

        public new String Add()
        {
            return base.Add();
        }
        //common methods that are implemented 
        //in the abstract class
        public new String Delete()
        {
            return base.Delete();
        }
        //common methods that are implemented 
        //in the abstract class

        public new String Search()
        {
            return base.Search();
        }
        //common methods that are implemented 
        //in the abstract class

        public new String Update()
        {
            return base.Update();
        }

        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore I override it here.

        public override String CalculateWage()
        {
            return "Full time employee " +
                  base.fname + " is calculated " +
                  "using the Abstract class...";
        }
    }
}
