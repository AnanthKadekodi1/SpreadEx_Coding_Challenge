namespace DrawingPackageApp.Widgets
{
    public class RectangleWidget : Widget
    {

        private int rectangleWidth;
        private int rectangleHeight;

        public RectangleWidget(int locationx, int locationy, int rectangleWidth, int rectangleHeight) : base("Rectangle", locationx, locationy)
        {
            if (rectangleWidth <= 0)
            {
                throw new ArgumentOutOfRangeException("rectangleWidth", "Rectangle width must be more than 0");
            }
            if (rectangleHeight <= 0)
            {
                throw new ArgumentOutOfRangeException("rectangleHeight", "Rectangle height must be more than 0");
            }
            this.rectangleWidth = rectangleWidth;
            this.rectangleHeight = rectangleHeight;
        }

        public int GetrectangleWidth()
        {
            return rectangleWidth;
        }

        public int GetrectangleHeight()
        {
            return rectangleHeight;
        }

        public override string ToString()
        {
            return string.Format("{0} width={1} height={2}", base.ToString(), rectangleWidth, rectangleHeight);
        }
    }
}
