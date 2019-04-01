using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoni.Patterns.Creational;

namespace rsoni.Patterns.Test
{
    [TestClass]
    public class CreationalPatternsTest
    {
        [TestMethod]
        public void TestSingleton()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            Assert.AreEqual(s1, s2);

        }
    }
}
