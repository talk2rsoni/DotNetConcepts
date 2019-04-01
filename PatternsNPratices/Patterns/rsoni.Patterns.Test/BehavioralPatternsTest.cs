using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoni.Patterns.Behavioral;

namespace rsoni.Patterns.Test
{
    [TestClass]
    public class BehavioralPatternsTest
    {
        [TestMethod]
        public void StrategyTest()
        {
            Context context;

            // Three contexts following different strategies

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}
