using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOTPISP1
{
    internal class DrawFig
    {
        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
        int[] coordinates = new int[4];

        public DrawFig(int x1, int y1, int x2, int y2, Graphics graphics)
        {
            graphic = graphics;

            this.coordinates[0] = x1;
            this.coordinates[1] = y1;
            this.coordinates[2] = x2;
            this.coordinates[3] = y2;
        }
        public void PrintFigure(Tool tool)
        {
            tool.Create(coordinates, pen, graphic);
        }
    }
    public interface Tool
    {
        void Create(int[] coordinates, Pen pen, Graphics graphics);
    }
    class DrawRectangle : Tool          
    {
        public void Create(int[] coordinates, Pen pen, Graphics graphics)
        {
            Point a = new Point(coordinates[0], coordinates[1]);
            Point b = new Point(coordinates[2], coordinates[1]);
            Point c = new Point(coordinates[2], coordinates[3]);
            Point d = new Point(coordinates[0], coordinates[3]);

            graphics.DrawLine(pen, a, b);
            graphics.DrawLine(pen, b, c);
            graphics.DrawLine(pen, c, d);
            graphics.DrawLine(pen, d, a);
        }
    }
    class DrawTrapezium : Tool
    {
        public void Create(int[] coordinates, Pen pen, Graphics graphics)
        {
            Point a = new Point(coordinates[0]+(coordinates[2]-coordinates[0])/4,coordinates[1]);
            Point b = new Point(coordinates[2]-(coordinates[2] - coordinates[0]) / 4, coordinates[1]);
            Point c = new Point(coordinates[2], coordinates[3]);
            Point d = new Point(coordinates[0], coordinates[3]);

            graphics.DrawLine(pen, a, b);
            graphics.DrawLine(pen, b, c);
            graphics.DrawLine(pen, c, d);
            graphics.DrawLine(pen, d, a);
        }
    }
    class DrawPentagon : Tool
    {
        public void Create(int[] coordinates, Pen pen, Graphics graphics)
        {
            Point a = new Point((coordinates[2] + coordinates[0]) / 2, coordinates[3]);
            Point b = new Point(coordinates[0], (coordinates[1] + coordinates[3]) / 2);
            Point c = new Point(coordinates[0]+(coordinates[2]-coordinates[0])/3, coordinates[1]);
            Point d = new Point(coordinates[0] + (coordinates[2] - coordinates[0])*2/3, coordinates[1]);
            Point e = new Point(coordinates[2], (coordinates[1] + coordinates[3]) / 2);

            graphics.DrawLine(pen, a, b);
            graphics.DrawLine(pen, b, c);
            graphics.DrawLine(pen, c, d);
            graphics.DrawLine(pen, d, e);
            graphics.DrawLine(pen, e, a);
        }
    }
    class DrawSquare : Tool
    {
        public void Create(int[] coordinates, Pen pen, Graphics graphics)
        {
            Point a = new Point(coordinates[0], coordinates[1]);
            Point b = new Point(coordinates[2], coordinates[1]);
            Point c = new Point(coordinates[2], coordinates[3]);
            Point d = new Point(coordinates[0], coordinates[3]);

            graphics.DrawLine(pen, a, b);
            graphics.DrawLine(pen, b, c);
            graphics.DrawLine(pen, c, d);
            graphics.DrawLine(pen, d, a);
        }
    }
    class DrawTriangle : Tool
    {
        public void Create(int[] coordinates, Pen pen, Graphics graphics)
        {
            Point a = new Point((coordinates[2] + coordinates[0]) / 2, coordinates[1]);
            Point b = new Point(coordinates[0], coordinates[3]);
            Point c = new Point(coordinates[2], coordinates[3]);

            graphics.DrawLine(pen, a, b);
            graphics.DrawLine(pen, b, c);
            graphics.DrawLine(pen, c, a);
        }
    }
    class DrawRhombus : Tool
    {
        public void Create(int[] coordinates, Pen pen, Graphics graphics)
        {
            Point a = new Point((coordinates[2] + coordinates[0]) / 2, coordinates[1]);
            Point b = new Point(coordinates[2], (coordinates[3] + coordinates[1]) / 2);
            Point c = new Point((coordinates[2] + coordinates[0]) / 2, coordinates[3]);
            Point d = new Point(coordinates[0], (coordinates[3] + coordinates[1]) / 2);

            graphics.DrawLine(pen, a, b);
            graphics.DrawLine(pen, b, c);
            graphics.DrawLine(pen, c, d);
            graphics.DrawLine(pen, d, a);
        }
    }
}
