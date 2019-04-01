using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoni.Patterns.Creational;
using rsoni.Patterns.Creational.AF;

namespace rsoni.Patterns.Test
{
    [TestClass]
    public class CreationalPatternsTest
    {
        [TestMethod]
        public void SingletonTest()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void AbstractFactoryTest()
        {
            // Abstract factory #1

            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

        }
    }
}
