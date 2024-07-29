namespace DrawingPackageApp.Widgets
{
    public class SquareWidget : Widget
    {
        private int squareWidth;

        public SquareWidget(int locationx, int locationy, int squareWidth) : base("Square", locationx, locationy)
        {
            if (squareWidth <= 0)
            {
                throw new ArgumentOutOfRangeException("squareWidth", "The Square width must be more than 0");
            }
            this.squareWidth = squareWidth;
        }

        public override string ToString()
        {
            return string.Format("{0} size={1}", base.ToString(), squareWidth);
        }
    }
}
