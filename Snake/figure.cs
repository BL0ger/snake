using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class figure
    {
        protected List<Point> pList;

        public virtual void Drow()
        {

            foreach (Point p in pList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                p.Draw();
            }
        }    
        internal bool IsHit(figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach(var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    
    }
}
