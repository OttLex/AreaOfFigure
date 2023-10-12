using NUnit.Framework;

namespace TestFigureArea
{
    public class TestsCircle
    {
        [Test]
        public void TestCircle()
        {
            var circle = new Circle(new List<double>() { 5 });
            Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 25));
        }
        [Test]
        public void TestNegativeCircle()
        {
            Assert.Catch<ArgumentException>(() => { new Circle(new List<double>() { -5 }); });
        }
        [Test]
        public void TestEmptyImputCircle()
        {
            Assert.Catch<ArgumentException>(() => { new Circle(new List<double>() { }); });
        }
        [Test]
        public void TestOverflowImputCircle()
        {
            Assert.Catch<ArgumentException>(() => { new Circle(new List<double>() { 1, 2 }); });
        }        
    }
}
