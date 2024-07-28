namespace DrawingPackageApp.Widgets
{
    public class CircleWidget : Widget
    {
        private int circleSize;

        public CircleWidget(int locationx, int locationy, int circleSize) : base("Circle", locationx, locationy)
        {
            if (circleSize <= 0)
            {
                throw new ArgumentOutOfRangeException("circleSize", "The Circle Size must be more than zERO");
            }

            this.circleSize = circleSize;
        }

        public int GetCircleDiameter()
        {
            return circleSize;
        }

        public override string ToString()
        {
            return string.Format("{0} size={1}", base.ToString(), circleSize);
        }

    }
}
