using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<figure> wallList;

        public Walls(int mapWidht, int MapHeight)
        {
            wallList = new List<figure>();
            LineHorizont UPline = new LineHorizont(0, mapWidht - 2, 0, '+');         
            LineHorizont Downline = new LineHorizont(0, mapWidht - 2, MapHeight - 1, '+');        
            LineVert Leftline = new LineVert(0, 0, MapHeight - 1, '+');          
            LineVert Rightline = new LineVert(mapWidht - 2, 0, MapHeight - 1, '+');

            wallList.Add(UPline);
            wallList.Add(Downline);
            wallList.Add(Leftline);
            wallList.Add(Rightline);
        }
        internal bool IsHit(figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }               
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Drow();
            }
        }

    }
}
