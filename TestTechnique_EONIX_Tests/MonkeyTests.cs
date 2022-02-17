using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTechnique_EONIX;

namespace TestTechnique_EONIX_Tests
{
    [TestClass]
    public class MonkeyTests
    {
        [TestMethod]
        public void TestMonkey_Equals()
        {
            Monkey m1 = new Monkey("Einstein");
            Monkey m2 = new Monkey("Einstein");

            if (!m1.Equals(m2))
                Assert.Fail();
        }
    }
}
