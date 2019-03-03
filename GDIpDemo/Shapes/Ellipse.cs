using System;
using System.Collections.Generic;
using d = System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDIpDemo.Shapes
{
    class Ellipse : Rectangle
    {
        public override void show(d.Graphics g)
        {
            d.Pen pen = new d.Pen(this.penColor);
            pen.Width = 5;
            d.Rectangle rectangle =
                new d.Rectangle(this.x0, this.y0, this.width, this.height);
            g.DrawEllipse(pen, rectangle);
            pen.Dispose();
        }
    }
}
