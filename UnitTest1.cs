
using UserShapes;

namespace TestProjectShapes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test()]
        public void TestCircleArea()
        {
            var circle = new Circle(9.5);
            Assert.That(circle.Area(), Is.EqualTo((Math.PI*9.5*9.5)));
        }
        [Test()]
        public void TestTriangleDoesntExist()
        {
            Assert.Throws<Exception>(delegate() { new Triangle(8, 2, 5); });
        }
        [Test()]
        public void TestTriangleIsRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRight(), Is.EqualTo(true));
        }
        [Test()]
        public void TestTriangleNotRight()
        {
            var triangle = new Triangle(7, 4, 5);
            Assert.That(triangle.IsRight(), Is.EqualTo(false));
        }
        [Test()]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.Area(), Is.EqualTo(6));
        }
    }
}