using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPISP1
{
    internal class Pentagon : Figure
    {
        public Graphics graphic;
        public Pentagon(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
        }
        public Pentagon(int x1, int y1, int x2, int y2, Graphics graphic) : base(x1, y1, x2, y2)
        {
            this.graphic = graphic;
        }
        public override void Draw()
        {
            DrawFig draw = new DrawFig(x1, y1, x2, y2, graphic);
            draw.PrintFigure(new DrawPentagon());
        }
    }
}
