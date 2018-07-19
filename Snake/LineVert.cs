using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class LineVert : figure
    {
        public LineVert(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
            public override void Drow()
         {
            
            foreach (Point p in pList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                p.Draw();
            }
        }
    }   
    
}
