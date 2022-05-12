using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP1
{
    internal class FigureList
    {
        public List<Figure> list;
        public static List<Figure> listIn = new List<Figure>
        {
            new Trapezium(4,5,2,7),
            new Pentagon(15,4,12,5),
            new Rhombus(8,9,10,11),
            new Square(12,13,14,15),
            new Triangle(16,17,18,19),
            new Rectangle(17,18,19,20)
        };
        public FigureList(int x1, int y1, int x2, int y2, Graphics graphics)
        {
            list = new List<Figure>()
            {
                new Trapezium(x1, y1, x2, y2, graphics),
                new Pentagon(x1, y1, x2, y2, graphics),
                new Rhombus(x1, y1, x2, y2, graphics),
                new Square(x1, y1, x2, y2, graphics),
                new Triangle(x1, y1, x2, y2, graphics),
                new Rectangle(x1, y1, x2, y2, graphics),
            };
        }
    }
}
    

