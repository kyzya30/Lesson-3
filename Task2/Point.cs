using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Point
    {
        int x, y;
        string str;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Str { get { return str; } }
        public Point(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.str = str;
        }
        public Point()
        {
        }
    }
}
