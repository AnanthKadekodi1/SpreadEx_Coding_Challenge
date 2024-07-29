using DrawingPackageApp.Logic;
using DrawingPackageApp.Widgets;
using System.Text;

namespace DrawingPackageApp.Tests
{
    [TestFixture]
    internal class DrawingTests
    {
        private Drawing drawing;
        private CircleWidget circleWidget;
        private EllipseWidget ellipseWidget;

        [SetUp]
        public void Setup()
        {
            drawing = new Drawing();
            circleWidget = new CircleWidget(1, 1, 300);
            ellipseWidget = new EllipseWidget(100, 150, 300, 200);
        }

        [Test]
        public void AddWidget_AndConfirm_WidgetIsAdded()
        {
            //Act
            drawing.AddWidget(circleWidget);

            //Assert
            var drawingOutput = drawing.PrintDrawing();

            Assert.That(drawingOutput, Does.Contain(circleWidget.ToString()));
        }

        [Test]
        public void AddNullWidget_Throws_Exception()
        {
            Assert.Throws<ArgumentNullException>(() => drawing.AddWidget(null));
        }


        [Test]
        public void DrawingPrints_Widgets_Correctly()
        {

            //arrange
            drawing.AddWidget(circleWidget);
            drawing.AddWidget(ellipseWidget);

            var expectedDrawingOutput = new StringBuilder();
            expectedDrawingOutput.AppendLine(circleWidget.ToString());
            expectedDrawingOutput.AppendLine(ellipseWidget.ToString());

            //act
            var drawingOutput = drawing.PrintDrawing();

            //assert
            Assert.AreEqual(expectedDrawingOutput.ToString(), drawingOutput);
        }
    }
}
