using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using knockknock.readify.net;
using KnockKnock;

namespace KnockKnockUnitTest
{
    [TestClass]
    public class TriangleTypeTest
    {
        [TestMethod]
        public void EquilateralTriangle()   
        {
            RedPillService rp = new RedPillService();
            Assert.AreEqual(TriangleType.Equilateral,  rp.WhatShapeIsThis(5,5,5));
        }
        [TestMethod]
        public void IsoscelesTriangle()
        {
            RedPillService rp = new RedPillService();
            Assert.AreEqual(TriangleType.Isosceles, rp.WhatShapeIsThis(3, 5, 5));
        }
        [TestMethod]
        public void ScaleneTriangle()
        {
            RedPillService rp = new RedPillService();
            Assert.AreEqual(TriangleType.Scalene, rp.WhatShapeIsThis(3, 4, 5));
        }
        [TestMethod]
        public void Error1()
        {
            RedPillService rp = new RedPillService();
            Assert.AreEqual(TriangleType.Error, rp.WhatShapeIsThis(3, 0, 5));
        }
        [TestMethod]
        public void Error2()
        {
            RedPillService rp = new RedPillService();
            Assert.AreEqual(TriangleType.Error, rp.WhatShapeIsThis(-1, 4, 5));
        }
        [TestMethod]
        public void Error3()
        {
            RedPillService rp = new RedPillService();
            Assert.AreEqual(TriangleType.Error, rp.WhatShapeIsThis(2, 3, 6));
        }
    }
}
