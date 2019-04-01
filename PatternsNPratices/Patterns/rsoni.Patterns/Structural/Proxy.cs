using rsoni.UtilsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.Patterns.Structural
{

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }

    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Utility.LogEntry("Called RealSubject.Request()");
        }
    }

    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject _realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'

            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
