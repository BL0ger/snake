using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class LineHorizont : figure
    {

        public LineHorizont(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <=xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void Drow()
        {
           
            foreach(Point p in pList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                p.Draw();
            }
        }       
    }
}
