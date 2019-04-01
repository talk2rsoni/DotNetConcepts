using rsoni.UtilsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.Patterns.Behavioral
{
    public class Context

    {
        private Strategy _strategy;

        // Constructor

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
    /// <summary>

    /// The 'Strategy' abstract class

    /// </summary>

    public abstract class Strategy

    {
        public abstract void AlgorithmInterface();
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    public class ConcreteStrategyA : Strategy

    {
        public override void AlgorithmInterface()
        {
            Utility.LogEntry(
              "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    public class ConcreteStrategyB : Strategy

    {
        public override void AlgorithmInterface()
        {
            Utility.LogEntry(
              "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    public class ConcreteStrategyC : Strategy

    {
        public override void AlgorithmInterface()
        {
            Utility.LogEntry(
              "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

}
