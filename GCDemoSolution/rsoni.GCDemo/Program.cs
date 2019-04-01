using rsoni.UtilsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string executionMode = "Release";
#if DEBUG
            executionMode = "Debug";
#endif
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Utility.LogEntry("--------------------------------------  Application Started [" + executionMode + "] ------------------------------------------------------");
                DateTime start = DateTime.Now;
                Utility.LogEntry("GC Maximum Generations:" + GC.MaxGeneration);
                CheckBaseGC();
                CheckGCGenerations();
                Console.ForegroundColor = ConsoleColor.White;
                Utility.LogEntry("Total Completion Duration in (ms):  " + (DateTime.Now - start).TotalMilliseconds);
                Utility.LogEntry2(string.Format("Successfully Completed."));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Utility.LogEntry(string.Format("Exception : {0} , Stack Trace: {1}", ex.Message, Utility.GetFullException(ex)));
                Utility.LogEntry(string.Format("Failed."));
                Console.ForegroundColor = ConsoleColor.White;
            }
            // If working in debug mode , need to see the output at console so let it wait there.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("\nPress any key to exit... ");
                Console.ReadKey(true);
            }
            Console.Write("\nPress any key to exit... ");
            Console.ReadKey(true);
        }

        public static void CheckBaseGC()
        {
            //GetTotalMemory shows the total number of memory occupied by the various resources.
            Utility.LogEntry("Total Memory:" + GC.GetTotalMemory(false));
            BaseGC oBaseGC = new BaseGC();
            Utility.LogEntry("BaseGC Generation is :" + GC.GetGeneration(oBaseGC));
            Utility.LogEntry("Total Memory:" + GC.GetTotalMemory(false));
        }

        public static void CheckGCGenerations()
        {
            Calci oCalci = new Calci();
            Console.WriteLine("Calci object is now on " + GC.GetGeneration(oCalci) + " Generation");
            Console.WriteLine("Garbage Collection Occured in 0th Generation:" + GC.CollectionCount(0));
            Console.WriteLine("Garbage Collection Occured in 1th Generation:" + GC.CollectionCount(1));
            Console.WriteLine("Garbage Collection Occured in 2th Generation:" + GC.CollectionCount(2));
            GC.Collect(0);
            Console.WriteLine("Garbage Collection Occured in 0th Generation:" + GC.CollectionCount(0));
        }

        public static void AdditionalGC()
        {
            //
        }



    }

    #region Additional Classes

    class Calci
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Multi(int a, int b)
        {
            return (a * b);
        }
        public int Divide(int a, int b)
        {
            return (a / b);
        }
    }

    public class BaseGC
    {
        public void Display()
        {
            Utility.LogEntry("Example Method");
        }
    }
    #endregion
}
