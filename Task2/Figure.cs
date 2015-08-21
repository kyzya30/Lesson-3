using System;

namespace Task2
{
    class Figure
    {
        private Point fPoint1;
        private Point fPoint2;
        private Point fPoint3;
        private Point fPoint4;
        private Point fPoint5;
        double _side1;
        double _side2;
        double _side3;
        double _side4;
        double _side5;

        public Figure(Point pt1, Point pt2, Point pt3)
        {
            fPoint1 = pt1;
            fPoint2 = pt2;
            fPoint3 = pt3;
            PerimetrCalculator();
        }
        public Figure(Point pt1, Point pt2, Point pt3, Point pt4)
        {
            fPoint1 = pt1;
            fPoint2 = pt2;
            fPoint3 = pt3;
            fPoint4 = pt4;
            PerimetrCalculator();
        }
        public Figure(Point pt1, Point pt2, Point pt3, Point pt4, Point pt5)
        {
            fPoint1 = pt1;
            fPoint2 = pt2;
            fPoint3 = pt3;
            fPoint4 = pt4;
            fPoint5 = pt5;
            PerimetrCalculator();
        }
        double LengthSide(Point A, Point B)
        {
            double lenght = Math.Sqrt((Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)));
            return lenght;
        }
        void PerimetrCalculator()
        {
            if (fPoint1 != null && fPoint2 != null && fPoint3 != null && fPoint4 == null && fPoint5 == null)
            {
                _side1 = LengthSide(fPoint1, fPoint2);
                _side2 = LengthSide(fPoint2, fPoint3);
                _side3 = LengthSide(fPoint1, fPoint3);
                Console.WriteLine("Периметр треугольника {0}", _side1 + _side2 + _side3);
            }
            else if (fPoint1 != null && fPoint2 != null && fPoint3 != null && fPoint4 != null && fPoint5 == null)
            {
                _side1 = LengthSide(fPoint1, fPoint2);
                _side2 = LengthSide(fPoint2, fPoint3);
                _side3 = LengthSide(fPoint3, fPoint4);
                _side4 = LengthSide(fPoint1, fPoint4);
                Console.WriteLine("Периметр четырехугольника {0}", _side1 + _side2 + _side3 + _side4);
            }
            else if (fPoint1 != null && fPoint2 != null && fPoint3 != null && fPoint4 != null && fPoint5 != null)
            {
                _side1 = LengthSide(fPoint1, fPoint2);
                _side2 = LengthSide(fPoint2, fPoint3);
                _side3 = LengthSide(fPoint3, fPoint4);
                _side4 = LengthSide(fPoint4, fPoint5);
                _side5 = LengthSide(fPoint1, fPoint5);
                Console.WriteLine("Периметр пятиугольника {0}", _side1 + _side2 + _side3 + _side4 + _side5);
            }


        }


    }
}
