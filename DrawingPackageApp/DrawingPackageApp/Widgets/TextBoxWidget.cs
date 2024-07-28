using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingPackageApp.Widgets
{
    public class TextBoxWidget : Widget
    {
        private string textBoxText;
        private int textBoxWidth;
        private int textBoxHeight;
        private RectangleWidget bounding_box;

        public TextboxWidget(string text, int locationx, int locationy, int textBoxWidth, int textBoxHeight) : base("Textbox", locationx, locationy)
        {
            if (textBoxWidth < 0)
            {
                throw new ArgumentOutOfRangeException("textBoxWidth", "Arguments must be positive.");
            }

            if (textBoxHeight < 0)
            {
                throw new ArgumentOutOfRangeException("textBoxHeight", "Arguments must be positive.");
            }

            this.textBoxText = text; 
            this.textBoxWidth = textBoxWidth;
            this.textBoxHeight = textBoxHeight;
            this.bounding_box = new RectangleWidget(locationx, locationy, textBoxWidth, textBoxHeight);
        }

    }
}
