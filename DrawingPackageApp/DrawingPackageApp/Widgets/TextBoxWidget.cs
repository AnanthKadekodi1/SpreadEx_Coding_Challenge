namespace DrawingPackageApp.Widgets
{
    public class TextBoxWidget : Widget
    {
        private string textBoxText;
        private int textBoxWidth;
        private int textBoxHeight;

        public TextBoxWidget(string text, int locationx, int locationy, int textBoxWidth, int textBoxHeight) : base("Textbox", locationx, locationy)
        {
            if (textBoxWidth < 0)
            {
                throw new ArgumentOutOfRangeException("textBoxWidth", "The text box width must be more than 0");
            }

            if (textBoxHeight < 0)
            {
                throw new ArgumentOutOfRangeException("textBoxHeight", "The text box height must be more than 0");
            }

            this.textBoxText = text;
            this.textBoxWidth = textBoxWidth;
            this.textBoxHeight = textBoxHeight;
        }

        public override string ToString()
        {
            return string.Format("{0} width={1} height={2} Text=\"{3}\"",
                base.ToString(), textBoxWidth, textBoxHeight, textBoxText);
        }

    }
}
