using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDIpDemo.Shapes
{
    abstract class IShape
    {
        public int x0;
        public int y0;
        public Color penColor = Color.Black;

        public abstract void show(Graphics g);
    }
}
