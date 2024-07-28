using DrawingPackageApp.Logic;
using DrawingPackageApp.Widgets;

namespace DrawingPackageApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("-------------------------------------------------------------");
            PrintDrawing();
            Console.WriteLine("-------------------------------------------------------------");

        }

        private static void PrintDrawing()
        {
            Drawing drawing = new Drawing();

            drawing.AddWidget(new RectangleWidget(10, 10, 30, 40));

            drawing.AddWidget(new SquareWidget(15, 30, 35));

            drawing.AddWidget(new EllipseWidget(100, 150, 300, 200));

            drawing.AddWidget(new CircleWidget(1, 1, 300));

            drawing.AddWidget(new TextBoxWidget("sample text", 5, 5, 200, 100));

            drawing.Print();
        }
    }
}

