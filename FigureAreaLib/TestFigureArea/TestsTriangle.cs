using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib.TestFigureArea
{
    public class TestsTriangle
    {
        [Test]
        public void TestEmptyInputTriangle()
        {
            Assert.Catch<ArgumentException>(() => { new Triangle(new List<double>() {}); });
        }
        [Test]
        public void TestOverflowImputTriangle()
        {
            Assert.Catch<ArgumentException>(() => { new Triangle(new List<double>() { 3, 4, 5, 8 }); });
        }
        [Test]
        public void TestNegativeTriangle()
        {
            Assert.Catch<ArgumentException>(() => { new Triangle(new List<double>() { 3, 2, 1 }); });
        }
        [Test]
        public void TestTriangle()
        {
            var triangle = new Triangle(new List<double>() { 3, 4, 5 });
            Assert.That(triangle.GetArea(), Is.EqualTo(6));
        }
        [Test]
        public void TestRectangular()
        {
            var triangle = new Triangle(new List<double>() { 3, 4, 5 });
            Assert.That(triangle.IsRectangular(), Is.True);
        }
    }
}
