using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.SolidPrinciples.ISP.WrongImpl
{

    public interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }

    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task  
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task.  
        }
        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }
}
