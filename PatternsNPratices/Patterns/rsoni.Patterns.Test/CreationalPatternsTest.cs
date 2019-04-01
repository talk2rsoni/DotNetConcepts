using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoni.Patterns.Creational;
using rsoni.Patterns.Creational.AF;
using rsoni.Patterns.Creational.Factory;
using rsoni.UtilsLibrary;

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

        [TestMethod]
        public void FactoryTest()
        {
            // An array of creators

            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Utility.LogEntry(string.Format("Created {0}", product.GetType().Name));
            }

        }
    }
}
