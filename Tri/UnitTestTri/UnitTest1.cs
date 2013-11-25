using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {

        [TestMethod] //Testar Point-konstruktorn som tar tre double-värden som argument
        public void PointConstructorTest()
        {
            Point point = new Point(1, 1);

            Assert.IsInstanceOfType(point, typeof(Point));
        }

        [TestMethod] //Testar Triangle-konstruktorn som tar tre double-värden som argument
        public void TriangleConstructor3DoublesTest()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);

            Assert.IsInstanceOfType(tri, typeof(Triangle));
        }

        [TestMethod] //Testar Triangle-konstruktorn som tar en Double-array som argument
        public void TriangleConstructorDoubleArrayTest()
        {
            double[] doubleArray = { 1.0, 1.0, 1.0 };
            Triangle tri = new Triangle(doubleArray);

            Assert.IsInstanceOfType(tri, typeof(Triangle));
        }

        [TestMethod] //Testar Triangle-konstruktorn som tar 3 points-objekt som argument
        public void TriangleConstructor3PointsTest()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(2, 0);
            Point point3 = new Point(2, 2);

            Triangle tri = new Triangle(point1, point2, point3);
            Assert.IsInstanceOfType(tri, typeof(Triangle));
        }

        [TestMethod] //Testar Triangle-konstruktorn som tar em Points-array som argument
        public void TriangleConstructorPointsArrayTest()
        {
            Point[] points = { new Point(0, 0), new Point(2, 0), new Point(2, 2), };
            Triangle tri = new Triangle(points);

            Assert.IsInstanceOfType(tri, typeof(Triangle));
        }


        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles());

            tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(tri.isIsosceles());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(tri.isEquilateral());

            tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isScalene());

            tri = new Triangle(1.0, 1.0, 2.0);
            Assert.IsFalse(tri.isScalene());
        }


    }
}
