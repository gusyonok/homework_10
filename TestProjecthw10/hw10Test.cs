using System.Drawing;

namespace hw10.Tests
{
    [TestClass]
    public class hw10Test
    {
        [TestMethod]
        public void Distance_Point0_0_Point3_4_expected5()
        {
            Point X = new Point(0, 0);
            Point Y = new Point(3, 4);
            double expected = 5;

            Triangle triangle = new Triangle(X, Y, X);
            double result = triangle.Distance(X, Y);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        public void Perimeter_Point0_0_Point0_3_Point4_0_expected12()
        {
            Point X = new Point(0, 0);
            Point Y = new Point(0, 3);
            Point Z = new Point(4, 0);
            double expected = 12;

            Triangle triangle = new Triangle(X, Y, Z);
            double result = triangle.Perimeter();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        public void Area_Point0_0_Point0_3_Point4_0_expected6()
        {
            Point X = new Point(0, 0);
            Point Y = new Point(0, 3);
            Point Z = new Point(4, 0);
            double expected = 6;

            Triangle triangle = new Triangle(X, Y, Z);
            double result = triangle.Area();

            Assert.AreEqual(expected, result);
        }
    }
}