using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingPackageApp.Widgets
{
    public class EllipseWidget : Widget
    {
        private int horizontalDiameter;
        private int verticalDiameter;

        public EllipseWidget(int locationx, int locationy, int horizontalDiameter, int verticalDiameter) : base("Ellipse", locationx, locationy)
        {
            if (horizontalDiameter < 0)
            {
                throw new ArgumentOutOfRangeException("horizontalDiameter", "The Horizontal Diameter must be more than 0");
            }
            if (verticalDiameter <= 0)
            {
                throw new ArgumentOutOfRangeException("verticalDiameter", "The Vertical Diameter must be more than 0");
            }
            this.horizontalDiameter = horizontalDiameter;
            this.verticalDiameter = verticalDiameter;
        }
        public int GethorizontalDiameter()
        {
            return horizontalDiameter;
        }
        public int GetverticalDiameter()
        {
            return verticalDiameter;
        }

        public override string ToString()
        {
            return string.Format("{0} horizontalDiameter={1} verticalDiameter={2}",base.ToString(), horizontalDiameter, verticalDiameter);
        }
    }
}
