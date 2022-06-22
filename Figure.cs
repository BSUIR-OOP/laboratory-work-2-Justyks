using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace OOTPISP1
{
    public class Figure
    {    
        public int x1;
        public int x2;
        public int y1;
        public int y2;
        public String figureName;
        public String getFigureName()
        {
            
            return figureName;
        }
        //static
        public double getX1()
        {
            return x1;
        }

        public double getX2()
        {
            return x2;
        }

        public double getY1()
        {
            return y1;
        }

        public double getY2()
        {
            return y2;
        }

        public Figure(int x1, int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.figureName = GetType().FullName;
            this.figureName= figureName.Remove(0,9);

        }
        public virtual void Draw(Graphics graphic,Pen pen)
        {
            
        }
    }
}
