using DrawingPackageApp.Widgets;

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
                throw new ArgumentNullException("widget");
            }

            widgets.Add(widget);
        }

        public void Print()
        {
            foreach (Widget widget in widgets)
            {
                Console.WriteLine(widget.ToString());

            }

        }
    }
}
