using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using knockknock.readify.net;

namespace KnockKnockUnitTest
{
    [TestClass]
    public class FiboancciTest
    {
        [TestMethod]
        public void Fib0()
        {
            Assert.AreEqual(Fibonacci.ValueAt(0), 0);
        }
        [TestMethod]
        public void Fib1()
        {
            Assert.AreEqual(Fibonacci.ValueAt(1), 1);
        }
        [TestMethod]
        public void Fib2()
        {
            Assert.AreEqual(Fibonacci.ValueAt(2), 1);
        }
        [TestMethod]
        public void Fib92()
        {
            Assert.AreEqual(Fibonacci.ValueAt(92), 7540113804746346429);
        }
        [TestMethod]
        public void FibNegative92()
        {
            Assert.AreEqual(Fibonacci.ValueAt(-92), -7540113804746346429);
        }
        [TestMethod]
        public void FibOver92()
        {
            try
            {
                Fibonacci.ValueAt(100);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(OverflowException), ex.GetType());
            }
        }
        [TestMethod]
        public void FibUnderNegative92()
        {
            try
            {
                Fibonacci.ValueAt(-100);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(OverflowException), ex.GetType());
            }
        }
    }
}
