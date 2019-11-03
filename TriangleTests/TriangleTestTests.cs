using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Tests
{
    [TestClass()]
    public class TriangleTestTests
    {
        [TestMethod]
        public void IsTriangleEquilateralTriangle()
        {
            Assert.IsTrue(TriangleTest.IsTriangle(10,10,10));
        }
        [TestMethod]
        public void IsTriangleIsoscelesTriangle()
        {
            Assert.IsTrue(TriangleTest.IsTriangle(10, 10, 5));
        }
        [TestMethod]
        public void IsTriangleStandartTriangle()
        {
            Assert.IsTrue(TriangleTest.IsTriangle(6, 7, 9));
        }
        [TestMethod]
        public void IsTriangleFirstSoide0()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(0, 10, 5));
        }
        [TestMethod]
        public void IsTriangleSecondSoide0()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(10, 0, 5));
        }
        [TestMethod]
        public void IsTriangleThirdSoide0()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(10, 10, 0));
        }
        [TestMethod]
        public void IsTriangleFirstSoideNegative()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(-5, 10, 5));
        }
        [TestMethod]
        public void IsTriangleSecondSoideNegative()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(5, -10, 5));
        }
        [TestMethod]
        public void IsTriangleThirdSoideNegative()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(5, 10, -5));
        }
        [TestMethod]
        public void IsTriangleAllSoideNegative()
        {
            Assert.IsFalse(TriangleTest.IsTriangle(-10, -25, -1));
        }




    }
}