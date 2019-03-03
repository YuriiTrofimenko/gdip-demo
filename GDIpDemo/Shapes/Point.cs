using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d = System.Drawing;

namespace GDIpDemo.Shapes
{
    class Point : IShape
    {
        public override void show(d.Graphics g)
        {
            d.Pen pen = new d.Pen(this.penColor);
            pen.Width = 5;
            d.Rectangle rectangle =
                new d.Rectangle(this.x0, this.y0, 3, 3);
            g.DrawEllipse(pen, rectangle);
            pen.Dispose();
        }
    }
}
