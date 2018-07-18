using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            LineHorizont UPline = new LineHorizont(0, 78, 0, '+');
            UPline.Drow();
            LineHorizont Downline = new LineHorizont(0, 78, 24, '+');
            Downline.Drow();
            LineVert Leftline = new LineVert(0, 0, 24, '+');
            Leftline.Drow();
            LineVert Rightlie = new LineVert(78, 0, 24, '+');
            Rightlie.Drow();

            Console.ReadLine();
        }

        
    }
}
