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

        int[] coordinates = new int[4];

        public DrawFig()
        {
           
        }
        public void DrawLineFig(int x1,int y1, int x2, int y2, Graphics graphics, Pen pen)
        {
            Point a=new Point(x1,y1);
            Point b=new Point(x2,y2);

            this.graphic = graphics;
            graphic.DrawLine(pen, a, b);
        }

    }
}