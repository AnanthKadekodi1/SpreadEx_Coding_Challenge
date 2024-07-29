using DrawingPackageApp.Widgets;
using System.Text;

namespace DrawingPackageApp.Logic
{
    public class Drawing
    {
        private List<Widget> widgets;

        public Drawing()
        {
            widgets = new List<Widget>();
        }

        public void AddWidget(Widget widget)
        {
            if (widget == null)
            {
                throw new ArgumentNullException("Null Widget Added");
            }

            widgets.Add(widget);
        }

        public string PrintDrawing()
        {
            var drawingOutput = new StringBuilder();

            foreach (Widget widget in widgets)
            {
                drawingOutput.Append(widget.ToString());
                drawingOutput.Append(Environment.NewLine);

            }

            return drawingOutput.ToString(); 

        }
    }
}
