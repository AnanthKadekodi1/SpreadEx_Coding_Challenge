using DrawingPackageApp.Widgets;
using NUnit.Framework;

namespace DrawingPackageApp.Tests.Widgets
{
    [TestFixture]
    internal class WidgetTests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateCircleWidget_ReturnsCircleWidgetInstanceType()
        {
            //arrange
            var x = 1;
            var y = 1;
            var size = 300;

            //act
            var circleWidget = new CircleWidget(x, y, size);

            //assert
            Assert.That(circleWidget, Is.InstanceOf<CircleWidget>());
        }

        [Test]
        public void ThrowArgumentException_WhenCircleWidgetSize_NotPositive()
        {
            //arrange
            var x = 1;
            var y = 1;
            var size = 0;

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new CircleWidget(x, y, size));
        }

        [Test]
        public void CreateEllipseWidget_ReturnsEllipseWidgetInstance()
        {
            //arrange
            var x = 100;
            var y = 150;
            var horizontalD = 300;
            var verticalD = 200;

            //act
            var ellipseWidget = new EllipseWidget(x, y, horizontalD, verticalD);

            //assert
            Assert.That(ellipseWidget, Is.InstanceOf<EllipseWidget>());
        }

        [Test]
        [TestCase(100, 150, 0, 200)]
        [TestCase(100, 150, 300, 0)]
        public void ThrowArgumentException_WhenEllipseWidget_Has_NonPositive_Values(int x, int y, int horizontalD, int verticalD)
        {

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new EllipseWidget(x, y, horizontalD, verticalD));
        }

        [Test]
        public void CreateRectangleWidget_ReturnsRectangleWidgetInstance()
        {
            //arrange
            var x = 10;
            var y = 10;
            var width = 30;
            var height = 40;

            //act
            var rectangleWidget = new RectangleWidget(x, y, 30, 40);

            //assert
            Assert.That(rectangleWidget, Is.InstanceOf<RectangleWidget>());
        }

        [Test]
        [TestCase(10, 10, 0, 40)]
        [TestCase(10, 10, 30, 0)]
        public void ThrowArgumentException_WhenRectangulareWidget_Has_NonPositive_Values(int x, int y, int width, int height)
        {
            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new RectangleWidget(x, y, width, height));
        }

        [Test]
        public void CreateSquareWidget_ReturnsSquareWidgetInstance()
        {
            //arrange
            var x = 15;
            var y = 30;
            var size = 35;

            //act
            var SquareWidget = new SquareWidget(x, y, size);

            //assert
            Assert.That(SquareWidget, Is.InstanceOf<SquareWidget>());
        }

        [Test]
        public void ThrowArgumentException_WhenSquareWidget_Has_NonPositive_Values()
        {

            //act
            var x = 15;
            var y = 30;
            var size = 0;


            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new SquareWidget(x, y, size));
        }


        [Test]
        public void CreateTextBoxWidget_ReturnsTextBoxWidgetInstance()
        {
            //arrange
            var x = 5;
            var y = 5;
            var width = 200;
            var height = 100;
            var text = "sample text";

            //act
            var TextBoxWidget = new TextBoxWidget(text, x, y, width, height);

            //assert
            Assert.That(TextBoxWidget, Is.InstanceOf<TextBoxWidget>());
        }

        [Test]
        [TestCase(5, 5, 0, 100, "sample text")]
        [TestCase(5, 5, 200, 0, "sample text")]
        public void ThrowArgumentException_WhenTextBoxWidget_Has_NonPositive_Values(int x, int y, int width, int height, string text)
        {
            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new TextBoxWidget(text, x, y, width, height));
        }
    }
}