using System.Drawing;

namespace DrawingPackageApp.Widgets
{
    public abstract class Widget
    {
        protected string widgetShape;
        protected Point widgetLocation;

        public Widget(string widgetShape, int widgetLocationX, int widgetLocationY)
        {
            this.widgetShape = widgetShape;
            widgetLocation = new Point(widgetLocationX, widgetLocationY);
        }

        public override string ToString()   // Write the shape and location, common to all widgets.
        {
            return string.Format("{0} ({1},{2})", widgetShape, widgetLocation.X, widgetLocation.Y);
        }
    }
}
