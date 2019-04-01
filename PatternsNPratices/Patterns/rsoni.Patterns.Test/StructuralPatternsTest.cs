using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoni.Patterns.Structural;

namespace rsoni.Patterns.Test
{
    [TestClass]
    public class StructuralPatternsTest
    {
        [TestMethod]
        public void ProxyTest()
        {
            // Create proxy and request a service

            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
