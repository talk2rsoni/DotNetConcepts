using rsoni.UtilsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.Patterns.Creational.AF
{

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }


    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }


    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    public abstract class AbstractProductA
    {
    }

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }


    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class ProductA1 : AbstractProductA
    {
    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Utility.LogEntry(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class ProductA2 : AbstractProductA
    {
    }

    /// <summary>

    /// The 'ProductB2' class

    /// </summary>

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Utility.LogEntry(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
