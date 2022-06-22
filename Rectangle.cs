using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPISP1
{
    class Rectangle : Figure
    {
        int[] coordinates = new int[4];
       
        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            this.coordinates[0] = x1;
            this.coordinates[1] = y1;
            this.coordinates[2] = x2;
            this.coordinates[3] = y2;
            

        }
        public Rectangle(int x1, int y1, int x2, int y2, Graphics graphic) : base(x1, y1, x2, y2)
        {
            
        }
       
        public override void Draw(Graphics graphic, Pen pen)
        {
            DrawFig draw = new DrawFig();
            draw.DrawLineFig(coordinates[0], coordinates[1], coordinates[2], coordinates[1], graphic, pen);
            draw.DrawLineFig(coordinates[2], coordinates[1], coordinates[2], coordinates[3], graphic, pen);
            draw.DrawLineFig(coordinates[2], coordinates[3], coordinates[0], coordinates[3], graphic, pen);
            draw.DrawLineFig(coordinates[0], coordinates[3], coordinates[0], coordinates[1], graphic, pen);

        }
    }
    }

