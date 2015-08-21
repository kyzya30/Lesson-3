using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(3,4,"one");
            Point pt2 = new Point(5,6,"two");
            Point pt3 = new Point(5,2,"three");
            Point pt4 = new Point(6,3,"four");
            Point pt5 = new Point(4,6,"five");
            Figure firstFigure = new Figure(pt1, pt2, pt3,pt4);
            Figure secondFigure = new Figure(pt1, pt2, pt3);
            Figure thirtFigure = new Figure(pt1, pt2, pt3,pt4,pt5);
        }
    }
    
    
}
