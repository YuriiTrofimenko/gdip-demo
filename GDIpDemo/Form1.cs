using GDIpDemo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIpDemo
{
    public partial class Form1 : Form
    {
        private List<Point> mPoints;
        private IEnumerable<string> shapeNames;
        public Form1()
        {
            InitializeComponent();
            mPoints = new List<Point>();
            shapeNames = Reflector.GetClasses("GDIpDemo.Shapes");
            //Console.WriteLine(shapeNames);
            foreach (var item in shapeNames)
            {
                Console.WriteLine(item);
            }
        }

        private void addShapeButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Xmax = drawPanel.Width;
            int Ymax = drawPanel.Height;
            mPoints.Add(
                new Point() {
                    X = random.Next(0, Xmax),
                    Y = random.Next(0, Ymax)
                });
            drawPanel.Refresh();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point point in mPoints)
            {
                
            }
        }
    }
}
